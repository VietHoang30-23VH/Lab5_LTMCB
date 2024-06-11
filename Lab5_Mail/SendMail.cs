using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using static Lab5_Mail.Bai6;
using System.Net.Mail;
using System.Security.Cryptography;

namespace Lab5_Mail
{
    public partial class SendMail : Form
    {
        private string FilePath = string.Empty;
        public SendMail()
        {
            InitializeComponent();
            txtFrom.Text = Account.TaiKhoan;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string html = "<h2>Phần nội dung này được gửi dưới dạng HTML<h2>";
            string attach = "<h1>Gửi mail với nội dung đính kèm</h1>";
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient(Account.SMTPType);
                mail.From = new MailAddress(Account.TaiKhoan);
                mail.To.Add(txtTo.Text);
                mail.Subject = txtSubject.Text;
                System.Net.Mail.Attachment Att = new System.Net.Mail.Attachment(txtAttachment.Text);
                mail.Attachments.Add(Att);
                if (checkHTML.Checked)
                {
                    mail.IsBodyHtml = true;
                    if (!string.IsNullOrEmpty(txtAttachment.Text))
                        mail.Body = attach + html + txtBody.Text;
                    else
                        mail.Body = html + txtBody.Text;
                }
                else
                {
                    mail.Body = txtBody.Text;
                }
                smtp.Port = Account.SMTPPort;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential(Account.TaiKhoan, Account.MatKhau);
                smtp.Send(mail);
                MessageBox.Show("Gửi mail thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = ofd.FileName;
            }
        }
    }
}