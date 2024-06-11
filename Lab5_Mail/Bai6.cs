using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MailKit;
using MailKit.Net;
using MailKit.Security;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using static System.Net.Mime.MediaTypeNames;

namespace Lab5_Mail
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            btnSend.Visible = false;
            btnRefresh.Visible = false;
            btnOut.Visible = false;
            dataGridView.Columns.Add("", "");
            dataGridView.Columns[""].Width = 0;
        }
        public static class Account
        {
            public static string TaiKhoan { get; set; }
            public static string MatKhau { get; set; }
            public static string SMTPType { get; set; }
            public static int SMTPPort { get; set; }

        }
        public class EmailInfo
        {
            public int SequenceNumber { get; set; }
            public string From { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text) && !string.IsNullOrEmpty(txtMatKhau.Text))
            {
                try
                {
                    Account.TaiKhoan = txtTaiKhoan.Text.Trim();
                    Account.MatKhau = txtMatKhau.Text.Trim();
                    var client = new ImapClient();
                    client.Connect(txtIMAP.Text.Trim(), int.Parse(txtPort1.Text.Trim()));
                    client.Authenticate(Account.TaiKhoan, Account.MatKhau);
                    MessageBox.Show("Đăng nhập thành công!");
                    btnDangNhap.Visible = false;
                    btnSend.Visible = true;
                    btnRefresh.Visible = true;
                    btnOut.Visible = true;
                    GetMail();
                }
                catch
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại.");
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin!");
            }
        }
        private void GetMail()
        {
            Account.TaiKhoan = txtTaiKhoan.Text.Trim();
            Account.MatKhau = txtMatKhau.Text.Trim();
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate(Account.TaiKhoan, Account.MatKhau);
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            int sequenceNumber = 1;
            List<EmailInfo> emailList = new List<EmailInfo>();

            for (int i = inbox.Count - 1; i > 0; i--)
            {
                var mess = inbox.GetMessage(i);
                var emailInfo = CreateEmailInfoFromMimeMessage(mess, sequenceNumber);
                emailList.Add(emailInfo);

                dataGridView.Rows.Add(sequenceNumber, mess.Subject, mess.From.ToString(), mess.Date.ToString("dd-MM-yyyy HH:mm:ss"));
                sequenceNumber++;
            }
            dataGridView.DataSource = emailList;
            dataGridView.CellClick += dataGridView_CellClick;
        }
        private EmailInfo CreateEmailInfoFromMimeMessage(MimeMessage message, int sequenceNumber)
        {
            return new EmailInfo
            {
                SequenceNumber = sequenceNumber,
                From = message.From.ToString(),
                Subject = message.Subject,
                Body = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody : message.TextBody
            };
        }
        private string GetEmailHtml(EmailInfo emailInfo)
        {
            return $@"
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        margin: 20px;
                    }}
                    .header {{
                        font-weight: bold;
                        margin-bottom: 10px;
                    }}
                    .body {{
                        margin-top: 20px;
                    }}
                </style>
            </head>
            <body>
                <div class='header'>From: {emailInfo.From}</div>
                <div class='header'>Subject: {emailInfo.Subject}</div>
                <hr/>
                <div class='body'>{emailInfo.Body}</div>
            </body>
            </html>";
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Account.TaiKhoan = txtTaiKhoan.Text.Trim();
            Account.MatKhau = txtMatKhau.Text.Trim();
            Account.SMTPType = txtSMTP.Text.Trim();
            Account.SMTPPort = int.Parse(txtPort2.Text.Trim());
            SmtpClient smtpClient = new SmtpClient(Account.SMTPType);
            smtpClient.Port = Account.SMTPPort;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential(Account.TaiKhoan, Account.MatKhau);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            SendMail sendMail = new SendMail();
            sendMail.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            btnSend.Visible = false;
            btnRefresh.Visible = false;
            btnOut.Visible = false;
            btnDangNhap.Visible = true;
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtIMAP.Text = string.Empty;
            txtPort1.Text = string.Empty;
            txtSMTP.Text = string.Empty;
            txtPort2.Text = string.Empty; ;
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var emailInfo = dataGridView.Rows[e.RowIndex].DataBoundItem as EmailInfo;
                if (emailInfo != null)
                {
                    string emailHtml = GetEmailHtml(emailInfo);
                    webBrowser1.DocumentText = emailHtml;
                }
            }
        }
    }
}