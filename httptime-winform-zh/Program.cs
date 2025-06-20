using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace httptime_winform_zh
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsAdministrator())
            {
                var result = MessageBox.Show(
                    "需要管理员权限，重启软件？",
                    "权限提示",
                    MessageBoxButtons.YesNo
                );

                if (result == DialogResult.Yes)
                {
                    RestartAsAdmin();
                    return;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static bool IsAdministrator()
        {
            using (var identity = WindowsIdentity.GetCurrent())
            {
                return new WindowsPrincipal(identity).IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        static void RestartAsAdmin()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = Assembly.GetEntryAssembly().Location,
                UseShellExecute = true,
                Verb = "runas",
            };

            try
            {
                Process.Start(startInfo);
                Environment.Exit(0);
            }
            catch
            {
                MessageBox.Show("管理员权限请求被拒绝");
            }
        }
    }
}
