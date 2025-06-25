using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httptime_winform_zh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MinimumSize = MaximumSize = Size;

            button_40.Click += button_click;
            button_60.Click += button_click;
            button_80.Click += button_click;
            button_100.Click += button_click;
            button_120.Click += button_click;

            button_baidu.Click += button_click;
            button_163.Click += button_click;
        }

        private void button_click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == button_40)
            {
                epsUpDown.Value = 40;
            }
            else if (button == button_60)
            {
                epsUpDown.Value = 60;
            }
            else if (button == button_80)
            {
                epsUpDown.Value = 80;
            }
            else if (button == button_100)
            {
                epsUpDown.Value = 100;
            }
            else if (button == button_120)
            {
                epsUpDown.Value = 120;
            }
            else if (button == button_baidu)
            {
                urlBox.Text = "http://www.baidu.com";
            }
            else if (button == button_163)
            {
                urlBox.Text = "http://www.163.com";
            }
        }

        private async void syncButton_Click(object sender, EventArgs e)
        {
            syncButton.Enabled = false;
            syncButton.Text = "处理中";

            try
            {
                await SyncTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "同步失败: " + ex.Message,
                    "错误",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                syncButton.Enabled = true;
                syncButton.Text = "同步";
            }
        }

        private async Task SyncTime()
        {
            var url = urlBox.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show(
                    "请输入有效的URL",
                    "错误",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            var eps = (int)epsUpDown.Value;
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (
                    HttpRequestMessage req,
                    X509Certificate2 cert,
                    X509Chain chain,
                    SslPolicyErrors errors
                ) => true,
            };
            var client = new HttpClient(handler) { Timeout = TimeSpan.FromSeconds(1) };

            var retryCount = 0;

            while (true)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(50 + retryCount));

                retryCount++;
                if (retryCount > 10)
                {
                    MessageBox.Show(
                        "同步失败，请重试。或者增大误差值、使用连接更快的地址。",
                        "错误",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;
                }

                try
                {
                    var sendTime = DateTime.Now;

                    var resp = await client.SendAsync(
                        new HttpRequestMessage
                        {
                            Method = HttpMethod.Head,
                            RequestUri = new Uri(url),
                        }
                    );
                    var recvTime = DateTime.Now;

                    resp.Headers.TryGetValues("Date", out var dateValues);
                    if (dateValues == null || !dateValues.Any())
                    {
                        retryCount++;
                        continue;
                    }
                    var dateValue = dateValues.FirstOrDefault();
                    var serverTime = DateTime.Parse(dateValue);

                    var rtt = (recvTime - sendTime).TotalMilliseconds;
                    if (Math.Abs(rtt) > eps * 2)
                    {
                        continue;
                    }
                    var offset = serverTime - recvTime.Add(TimeSpan.FromMilliseconds(rtt / 2));

                    var newTime = DateTime.Now.Add(offset);

                    var message =
                        $"确定同步至 {newTime:yyyy-MM-dd HH:mm:ss} 吗? 误差大概 {rtt / 2 / 1000:F2} 秒";
                    var result = MessageBox.Show(
                        message,
                        "确认同步",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if (result == DialogResult.Yes)
                    {
                        var ret = SetTime(offset);
                        if (ret)
                        {
                            MessageBox.Show(
                                "时间同步成功！",
                                "成功",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "时间同步失败，请检查权限或系统设置。",
                                "错误",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }

                    break;
                }
                catch (Exception ex)
                {
                    retryCount++;
                }
            }
        }

        private bool SetTime(TimeSpan offset)
        {
            var newTime = DateTime.UtcNow.Add(offset);

            SYSTEMTIME st = new SYSTEMTIME
            {
                Year = (ushort)newTime.Year,
                Month = (ushort)newTime.Month,
                Day = (ushort)newTime.Day,
                Hour = (ushort)newTime.Hour,
                Minute = (ushort)newTime.Minute,
                Second = (ushort)newTime.Second,
                Milliseconds = (ushort)newTime.Millisecond,
            };

            bool result = SetSystemTime(ref st);
            return result;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Milliseconds;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime(ref SYSTEMTIME st);
    }
}
