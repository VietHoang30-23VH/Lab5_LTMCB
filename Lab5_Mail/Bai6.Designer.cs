namespace Lab5_Mail
{
    partial class Bai6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPort2 = new System.Windows.Forms.TextBox();
            this.lbPort2 = new System.Windows.Forms.Label();
            this.txtPort1 = new System.Windows.Forms.TextBox();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.lbSMTP = new System.Windows.Forms.Label();
            this.txtIMAP = new System.Windows.Forms.TextBox();
            this.lbPort1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnOut);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(173, 151);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Tải lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(338, 151);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(146, 32);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Đăng xuất";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(338, 113);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(146, 32);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(92, 75);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(392, 22);
            this.txtMatKhau.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(6, 151);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(146, 32);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Gửi thư";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(92, 33);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(392, 22);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPort2);
            this.groupBox2.Controls.Add(this.lbPort2);
            this.groupBox2.Controls.Add(this.txtPort1);
            this.groupBox2.Controls.Add(this.txtSMTP);
            this.groupBox2.Controls.Add(this.lbSMTP);
            this.groupBox2.Controls.Add(this.txtIMAP);
            this.groupBox2.Controls.Add(this.lbPort1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(523, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt";
            // 
            // txtPort2
            // 
            this.txtPort2.Location = new System.Drawing.Point(469, 75);
            this.txtPort2.Name = "txtPort2";
            this.txtPort2.Size = new System.Drawing.Size(104, 22);
            this.txtPort2.TabIndex = 9;
            // 
            // lbPort2
            // 
            this.lbPort2.AutoSize = true;
            this.lbPort2.Location = new System.Drawing.Point(408, 81);
            this.lbPort2.Name = "lbPort2";
            this.lbPort2.Size = new System.Drawing.Size(34, 16);
            this.lbPort2.TabIndex = 8;
            this.lbPort2.Text = "Port:";
            // 
            // txtPort1
            // 
            this.txtPort1.Location = new System.Drawing.Point(67, 75);
            this.txtPort1.Name = "txtPort1";
            this.txtPort1.Size = new System.Drawing.Size(104, 22);
            this.txtPort1.TabIndex = 7;
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(469, 33);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(270, 22);
            this.txtSMTP.TabIndex = 5;
            // 
            // lbSMTP
            // 
            this.lbSMTP.AutoSize = true;
            this.lbSMTP.Location = new System.Drawing.Point(408, 39);
            this.lbSMTP.Name = "lbSMTP";
            this.lbSMTP.Size = new System.Drawing.Size(48, 16);
            this.lbSMTP.TabIndex = 6;
            this.lbSMTP.Text = "SMTP:";
            // 
            // txtIMAP
            // 
            this.txtIMAP.Location = new System.Drawing.Point(67, 33);
            this.txtIMAP.Name = "txtIMAP";
            this.txtIMAP.Size = new System.Drawing.Size(270, 22);
            this.txtIMAP.TabIndex = 4;
            // 
            // lbPort1
            // 
            this.lbPort1.AutoSize = true;
            this.lbPort1.Location = new System.Drawing.Point(6, 81);
            this.lbPort1.Name = "lbPort1";
            this.lbPort1.Size = new System.Drawing.Size(34, 16);
            this.lbPort1.TabIndex = 4;
            this.lbPort1.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "IMAP:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(764, 202);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(535, 533);
            this.webBrowser1.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 202);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(745, 516);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 778);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.Label lbSMTP;
        private System.Windows.Forms.TextBox txtIMAP;
        private System.Windows.Forms.Label lbPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort2;
        private System.Windows.Forms.Label lbPort2;
        private System.Windows.Forms.TextBox txtPort1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}