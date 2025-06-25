namespace httptime_winform_zh
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.epsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.syncButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_40 = new System.Windows.Forms.Button();
            this.button_60 = new System.Windows.Forms.Button();
            this.button_80 = new System.Windows.Forms.Button();
            this.button_100 = new System.Windows.Forms.Button();
            this.button_baidu = new System.Windows.Forms.Button();
            this.button_163 = new System.Windows.Forms.Button();
            this.button_120 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epsUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(52, 21);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(222, 21);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "http://baidu.com";
            // 
            // epsUpDown
            // 
            this.epsUpDown.Location = new System.Drawing.Point(105, 60);
            this.epsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.epsUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.epsUpDown.Name = "epsUpDown";
            this.epsUpDown.Size = new System.Drawing.Size(76, 21);
            this.epsUpDown.TabIndex = 1;
            this.epsUpDown.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "允许误差（ms）";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_120);
            this.groupBox1.Controls.Add(this.button_100);
            this.groupBox1.Controls.Add(this.button_80);
            this.groupBox1.Controls.Add(this.button_163);
            this.groupBox1.Controls.Add(this.button_baidu);
            this.groupBox1.Controls.Add(this.button_60);
            this.groupBox1.Controls.Add(this.button_40);
            this.groupBox1.Controls.Add(this.epsUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.urlBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(12, 116);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(373, 33);
            this.syncButton.TabIndex = 4;
            this.syncButton.Text = "同步";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(316, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "- by wongxy";
            // 
            // button_40
            // 
            this.button_40.Location = new System.Drawing.Point(188, 58);
            this.button_40.Name = "button_40";
            this.button_40.Size = new System.Drawing.Size(25, 25);
            this.button_40.TabIndex = 3;
            this.button_40.Text = "40";
            this.button_40.UseVisualStyleBackColor = true;
            // 
            // button_60
            // 
            this.button_60.Location = new System.Drawing.Point(220, 58);
            this.button_60.Name = "button_60";
            this.button_60.Size = new System.Drawing.Size(25, 25);
            this.button_60.TabIndex = 3;
            this.button_60.Text = "60";
            this.button_60.UseVisualStyleBackColor = true;
            // 
            // button_80
            // 
            this.button_80.Location = new System.Drawing.Point(252, 58);
            this.button_80.Name = "button_80";
            this.button_80.Size = new System.Drawing.Size(25, 25);
            this.button_80.TabIndex = 3;
            this.button_80.Text = "80";
            this.button_80.UseVisualStyleBackColor = true;
            // 
            // button_100
            // 
            this.button_100.Location = new System.Drawing.Point(284, 58);
            this.button_100.Name = "button_100";
            this.button_100.Size = new System.Drawing.Size(35, 25);
            this.button_100.TabIndex = 3;
            this.button_100.Text = "100";
            this.button_100.UseVisualStyleBackColor = true;
            // 
            // button_baidu
            // 
            this.button_baidu.Location = new System.Drawing.Point(280, 20);
            this.button_baidu.Name = "button_baidu";
            this.button_baidu.Size = new System.Drawing.Size(37, 25);
            this.button_baidu.TabIndex = 3;
            this.button_baidu.Text = "百度";
            this.button_baidu.UseVisualStyleBackColor = true;
            // 
            // button_163
            // 
            this.button_163.Location = new System.Drawing.Point(323, 20);
            this.button_163.Name = "button_163";
            this.button_163.Size = new System.Drawing.Size(37, 25);
            this.button_163.TabIndex = 3;
            this.button_163.Text = "网易";
            this.button_163.UseVisualStyleBackColor = true;
            // 
            // button_120
            // 
            this.button_120.Location = new System.Drawing.Point(326, 58);
            this.button_120.Name = "button_120";
            this.button_120.Size = new System.Drawing.Size(35, 25);
            this.button_120.TabIndex = 3;
            this.button_120.Text = "120";
            this.button_120.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 173);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "时间同步";
            ((System.ComponentModel.ISupportInitialize)(this.epsUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.NumericUpDown epsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_100;
        private System.Windows.Forms.Button button_80;
        private System.Windows.Forms.Button button_60;
        private System.Windows.Forms.Button button_40;
        private System.Windows.Forms.Button button_baidu;
        private System.Windows.Forms.Button button_120;
        private System.Windows.Forms.Button button_163;
    }
}

