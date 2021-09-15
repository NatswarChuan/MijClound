namespace Login_Live_v1._0
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
            this.GChinh = new System.Windows.Forms.GroupBox();
            this.btnOpenUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GProxy = new System.Windows.Forms.GroupBox();
            this.rBtnIPPort = new System.Windows.Forms.RadioButton();
            this.rBtnTinsoft = new System.Windows.Forms.RadioButton();
            this.rBtnNoneProxy = new System.Windows.Forms.RadioButton();
            this.GCaptcha = new System.Windows.Forms.GroupBox();
            this.rbtnNoneCaptcha = new System.Windows.Forms.RadioButton();
            this.rBtnAntiCaptcha = new System.Windows.Forms.RadioButton();
            this.GCauHinhChay = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labelKEY = new System.Windows.Forms.Label();
            this.btnCoppyKey = new System.Windows.Forms.Button();
            this.GChucNang = new System.Windows.Forms.GroupBox();
            this.resultView = new System.Windows.Forms.ListView();
            this.cKhac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProxy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtApiAntiCaptcha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenProxy = new System.Windows.Forms.Button();
            this.txtApiTinsoft = new System.Windows.Forms.TextBox();
            this.GChinh.SuspendLayout();
            this.GProxy.SuspendLayout();
            this.GCaptcha.SuspendLayout();
            this.GCauHinhChay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).BeginInit();
            this.GChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // GChinh
            // 
            this.GChinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GChinh.Controls.Add(this.btnOpenUser);
            this.GChinh.Controls.Add(this.label1);
            this.GChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GChinh.ForeColor = System.Drawing.Color.Black;
            this.GChinh.Location = new System.Drawing.Point(8, 32);
            this.GChinh.Name = "GChinh";
            this.GChinh.Size = new System.Drawing.Size(225, 55);
            this.GChinh.TabIndex = 1;
            this.GChinh.TabStop = false;
            this.GChinh.Text = "Cấu hình Chính";
            this.GChinh.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnOpenUser
            // 
            this.btnOpenUser.Location = new System.Drawing.Point(137, 15);
            this.btnOpenUser.Name = "btnOpenUser";
            this.btnOpenUser.Size = new System.Drawing.Size(75, 23);
            this.btnOpenUser.TabIndex = 2;
            this.btnOpenUser.Text = "Mở";
            this.btnOpenUser.UseVisualStyleBackColor = true;
            this.btnOpenUser.Click += new System.EventHandler(this.btnOpenUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File.txt (User)";
            // 
            // GProxy
            // 
            this.GProxy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GProxy.Controls.Add(this.txtApiTinsoft);
            this.GProxy.Controls.Add(this.btnOpenProxy);
            this.GProxy.Controls.Add(this.rBtnIPPort);
            this.GProxy.Controls.Add(this.rBtnTinsoft);
            this.GProxy.Controls.Add(this.rBtnNoneProxy);
            this.GProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GProxy.Location = new System.Drawing.Point(10, 111);
            this.GProxy.Name = "GProxy";
            this.GProxy.Size = new System.Drawing.Size(225, 105);
            this.GProxy.TabIndex = 2;
            this.GProxy.TabStop = false;
            this.GProxy.Text = "Cấu hình Proxy Tùy Chỉnh";
            // 
            // rBtnIPPort
            // 
            this.rBtnIPPort.AutoSize = true;
            this.rBtnIPPort.Location = new System.Drawing.Point(6, 46);
            this.rBtnIPPort.Name = "rBtnIPPort";
            this.rBtnIPPort.Size = new System.Drawing.Size(71, 17);
            this.rBtnIPPort.TabIndex = 2;
            this.rBtnIPPort.TabStop = true;
            this.rBtnIPPort.Text = "IP | Port";
            this.rBtnIPPort.UseVisualStyleBackColor = true;
            // 
            // rBtnTinsoft
            // 
            this.rBtnTinsoft.AutoSize = true;
            this.rBtnTinsoft.Location = new System.Drawing.Point(6, 75);
            this.rBtnTinsoft.Name = "rBtnTinsoft";
            this.rBtnTinsoft.Size = new System.Drawing.Size(64, 17);
            this.rBtnTinsoft.TabIndex = 1;
            this.rBtnTinsoft.TabStop = true;
            this.rBtnTinsoft.Text = "Tinsoft";
            this.rBtnTinsoft.UseVisualStyleBackColor = true;
            // 
            // rBtnNoneProxy
            // 
            this.rBtnNoneProxy.AutoSize = true;
            this.rBtnNoneProxy.Checked = true;
            this.rBtnNoneProxy.Location = new System.Drawing.Point(6, 20);
            this.rBtnNoneProxy.Name = "rBtnNoneProxy";
            this.rBtnNoneProxy.Size = new System.Drawing.Size(55, 17);
            this.rBtnNoneProxy.TabIndex = 0;
            this.rBtnNoneProxy.TabStop = true;
            this.rBtnNoneProxy.Text = "None";
            this.rBtnNoneProxy.UseVisualStyleBackColor = true;
            this.rBtnNoneProxy.CheckedChanged += new System.EventHandler(this.rBtnNone_CheckedChanged);
            // 
            // GCaptcha
            // 
            this.GCaptcha.BackColor = System.Drawing.Color.DarkSalmon;
            this.GCaptcha.Controls.Add(this.label2);
            this.GCaptcha.Controls.Add(this.txtApiAntiCaptcha);
            this.GCaptcha.Controls.Add(this.rbtnNoneCaptcha);
            this.GCaptcha.Controls.Add(this.rBtnAntiCaptcha);
            this.GCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCaptcha.Location = new System.Drawing.Point(10, 222);
            this.GCaptcha.Name = "GCaptcha";
            this.GCaptcha.Size = new System.Drawing.Size(225, 87);
            this.GCaptcha.TabIndex = 3;
            this.GCaptcha.TabStop = false;
            this.GCaptcha.Text = "Cấu hình giải Captcha";
            // 
            // rbtnNoneCaptcha
            // 
            this.rbtnNoneCaptcha.AutoSize = true;
            this.rbtnNoneCaptcha.Location = new System.Drawing.Point(126, 20);
            this.rbtnNoneCaptcha.Name = "rbtnNoneCaptcha";
            this.rbtnNoneCaptcha.Size = new System.Drawing.Size(59, 17);
            this.rbtnNoneCaptcha.TabIndex = 1;
            this.rbtnNoneCaptcha.Text = "None ";
            this.rbtnNoneCaptcha.UseVisualStyleBackColor = true;
            this.rbtnNoneCaptcha.CheckedChanged += new System.EventHandler(this.rbtnNoneCaptcha_CheckedChanged);
            // 
            // rBtnAntiCaptcha
            // 
            this.rBtnAntiCaptcha.AutoSize = true;
            this.rBtnAntiCaptcha.Checked = true;
            this.rBtnAntiCaptcha.Location = new System.Drawing.Point(7, 20);
            this.rBtnAntiCaptcha.Name = "rBtnAntiCaptcha";
            this.rBtnAntiCaptcha.Size = new System.Drawing.Size(94, 17);
            this.rBtnAntiCaptcha.TabIndex = 0;
            this.rBtnAntiCaptcha.TabStop = true;
            this.rBtnAntiCaptcha.Text = "AntiCaptcha";
            this.rBtnAntiCaptcha.UseVisualStyleBackColor = true;
            // 
            // GCauHinhChay
            // 
            this.GCauHinhChay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GCauHinhChay.Controls.Add(this.label4);
            this.GCauHinhChay.Controls.Add(this.txtPass);
            this.GCauHinhChay.Controls.Add(this.label3);
            this.GCauHinhChay.Controls.Add(this.nSoLuong);
            this.GCauHinhChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GCauHinhChay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GCauHinhChay.Location = new System.Drawing.Point(8, 315);
            this.GCauHinhChay.Name = "GCauHinhChay";
            this.GCauHinhChay.Size = new System.Drawing.Size(225, 76);
            this.GCauHinhChay.TabIndex = 4;
            this.GCauHinhChay.TabStop = false;
            this.GCauHinhChay.Text = "Cấu hình Chạy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(94, 45);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Luồng";
            // 
            // nSoLuong
            // 
            this.nSoLuong.Location = new System.Drawing.Point(94, 19);
            this.nSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSoLuong.Name = "nSoLuong";
            this.nSoLuong.Size = new System.Drawing.Size(43, 20);
            this.nSoLuong.TabIndex = 0;
            this.nSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(10, 397);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(99, 32);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Chạy";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(134, 397);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 32);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelKEY
            // 
            this.labelKEY.AutoSize = true;
            this.labelKEY.ForeColor = System.Drawing.Color.Red;
            this.labelKEY.Location = new System.Drawing.Point(103, 428);
            this.labelKEY.Name = "labelKEY";
            this.labelKEY.Size = new System.Drawing.Size(138, 13);
            this.labelKEY.TabIndex = 7;
            this.labelKEY.Text = "Nhấn vào đây để hiện KEY";
            this.labelKEY.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCoppyKey
            // 
            this.btnCoppyKey.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCoppyKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoppyKey.ForeColor = System.Drawing.Color.Transparent;
            this.btnCoppyKey.Location = new System.Drawing.Point(12, 418);
            this.btnCoppyKey.Name = "btnCoppyKey";
            this.btnCoppyKey.Size = new System.Drawing.Size(75, 32);
            this.btnCoppyKey.TabIndex = 8;
            this.btnCoppyKey.Text = "Coppy Key";
            this.btnCoppyKey.UseVisualStyleBackColor = false;
            this.btnCoppyKey.Click += new System.EventHandler(this.btnCoppyKey_Click);
            // 
            // GChucNang
            // 
            this.GChucNang.Controls.Add(this.GChinh);
            this.GChucNang.Controls.Add(this.GProxy);
            this.GChucNang.Controls.Add(this.GCaptcha);
            this.GChucNang.Controls.Add(this.btnStop);
            this.GChucNang.Controls.Add(this.btnRun);
            this.GChucNang.Controls.Add(this.GCauHinhChay);
            this.GChucNang.Location = new System.Drawing.Point(539, 12);
            this.GChucNang.Name = "GChucNang";
            this.GChucNang.Size = new System.Drawing.Size(246, 440);
            this.GChucNang.TabIndex = 9;
            this.GChucNang.TabStop = false;
            this.GChucNang.Text = "Chức Năng";
            // 
            // resultView
            // 
            this.resultView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.resultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cKhac,
            this.cUsername,
            this.cPassword,
            this.cProxy,
            this.cResult,
            this.cStatus});
            this.resultView.HideSelection = false;
            this.resultView.Location = new System.Drawing.Point(12, 27);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(521, 379);
            this.resultView.TabIndex = 10;
            this.resultView.UseCompatibleStateImageBehavior = false;
            this.resultView.View = System.Windows.Forms.View.Details;
            this.resultView.SelectedIndexChanged += new System.EventHandler(this.resultView_SelectedIndexChanged);
            // 
            // cKhac
            // 
            this.cKhac.Text = "#";
            // 
            // cUsername
            // 
            this.cUsername.Text = "Username";
            // 
            // cPassword
            // 
            this.cPassword.Text = "Password";
            // 
            // cProxy
            // 
            this.cProxy.Text = "Proxy";
            this.cProxy.Width = 58;
            // 
            // cResult
            // 
            this.cResult.Text = "Kết quả";
            // 
            // cStatus
            // 
            this.cStatus.Text = "Status";
            // 
            // txtApiAntiCaptcha
            // 
            this.txtApiAntiCaptcha.Location = new System.Drawing.Point(51, 43);
            this.txtApiAntiCaptcha.Name = "txtApiAntiCaptcha";
            this.txtApiAntiCaptcha.Size = new System.Drawing.Size(159, 20);
            this.txtApiAntiCaptcha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "API";
            // 
            // btnOpenProxy
            // 
            this.btnOpenProxy.Location = new System.Drawing.Point(92, 43);
            this.btnOpenProxy.Name = "btnOpenProxy";
            this.btnOpenProxy.Size = new System.Drawing.Size(75, 23);
            this.btnOpenProxy.TabIndex = 3;
            this.btnOpenProxy.Text = "Mở";
            this.btnOpenProxy.UseVisualStyleBackColor = true;
            this.btnOpenProxy.Click += new System.EventHandler(this.btnOpenProxy_Click);
            // 
            // txtApiTinsoft
            // 
            this.txtApiTinsoft.Location = new System.Drawing.Point(71, 72);
            this.txtApiTinsoft.Name = "txtApiTinsoft";
            this.txtApiTinsoft.Size = new System.Drawing.Size(139, 20);
            this.txtApiTinsoft.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 464);
            this.Controls.Add(this.resultView);
            this.Controls.Add(this.GChucNang);
            this.Controls.Add(this.btnCoppyKey);
            this.Controls.Add(this.labelKEY);
            this.Name = "Form1";
            this.Text = "Mij Cloud | Create Hotmail v1.0 | 033.832.4057 | Mijcloud.com | Fb.com/mij001";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GChinh.ResumeLayout(false);
            this.GChinh.PerformLayout();
            this.GProxy.ResumeLayout(false);
            this.GProxy.PerformLayout();
            this.GCaptcha.ResumeLayout(false);
            this.GCaptcha.PerformLayout();
            this.GCauHinhChay.ResumeLayout(false);
            this.GCauHinhChay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).EndInit();
            this.GChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GChinh;
        private System.Windows.Forms.Button btnOpenUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GProxy;
        private System.Windows.Forms.RadioButton rBtnIPPort;
        private System.Windows.Forms.RadioButton rBtnTinsoft;
        private System.Windows.Forms.RadioButton rBtnNoneProxy;
        private System.Windows.Forms.GroupBox GCaptcha;
        private System.Windows.Forms.RadioButton rbtnNoneCaptcha;
        private System.Windows.Forms.RadioButton rBtnAntiCaptcha;
        private System.Windows.Forms.GroupBox GCauHinhChay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nSoLuong;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelKEY;
        private System.Windows.Forms.Button btnCoppyKey;
        private System.Windows.Forms.GroupBox GChucNang;
        private System.Windows.Forms.ListView resultView;
        private System.Windows.Forms.ColumnHeader cKhac;
        private System.Windows.Forms.ColumnHeader cUsername;
        private System.Windows.Forms.ColumnHeader cPassword;
        private System.Windows.Forms.ColumnHeader cProxy;
        private System.Windows.Forms.ColumnHeader cResult;
        private System.Windows.Forms.ColumnHeader cStatus;
        private System.Windows.Forms.TextBox txtApiTinsoft;
        private System.Windows.Forms.Button btnOpenProxy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApiAntiCaptcha;
    }
}

