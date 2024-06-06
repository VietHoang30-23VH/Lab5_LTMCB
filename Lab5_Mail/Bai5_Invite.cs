using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;
using MailKit.Net.Smtp;

namespace Lab5_Mail
{
    public partial class Bai5_Invite : Form
    {
        private string in4 = "";
        public Bai5_Invite(Control control, string s)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(control);
            in4 = s;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string content = textBox1.Text;
            if (!string.IsNullOrEmpty(content))
            {
                ListViewItem item = new ListViewItem(content);
                listView1.Items.Add(item);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập email của bạn bè mà bạn muốn mời");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool a = false;
            Config config = ConfigHelper.GetConfig();
            if (config.SSL == "true")
            {
                a = true;
            }
            string b = config.MailServer;
            int c = config.Port;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Connect(b, c, a);
                try
                {
                    smtpClient.Authenticate(config.Username, config.Password);
                    MimeMessage mimeMessage = new MimeMessage();
                    mimeMessage.From.Add(new MailboxAddress("", config.Username));
                    mimeMessage.To.Add(new MailboxAddress("", listView1.Items[i].Text));
                    mimeMessage.Subject = "Bạn có một lời mời đi ăn";
                    string[] chuoi = in4.Split(',');
                    string monan = chuoi[0];
                    string gia = chuoi[1];
                    string diachi = chuoi[2];
                    string imgurl = chuoi[4];
                    mimeMessage.Body = new TextPart("html")
                    {
                        Text = $@"<html>
                            <head>
                                <style>
                                    /* Định dạng cho phần tử chứa hình ảnh và các dòng thông tin */
                                    .container {{
                                        text-align: center; /* Căn giữa nội dung */
                                    }}
                                    /* Định dạng cho hình ảnh */
                                    .email-image {{
                                        max-width: 100%; /* Chỉnh kích thước tối đa của hình ảnh */
                                        height: auto; /* Tự động điều chỉnh chiều cao */
                                    }}
                                </style>
                            </head>
                            <body>
                                <div class='container'>
                                     <img src=""{imgurl}"" alt=""Your Image"">
                                    <h1>{monan}</h1>
                                    <p>{gia}</p>
                                    <p>{diachi}</p>
                                </div>
                            </body>
                         </html>"
                    };
                    smtpClient.Send(mimeMessage);
                    MessageBox.Show("Connection successful");
                }
                catch
                {
                    MessageBox.Show("Connection failed");
                }
            }
        }
    }
}
