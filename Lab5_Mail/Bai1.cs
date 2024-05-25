using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Mail
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private string smtp_pass = "ayhm pqkp huic oskz";
        private void btnSend_Click(object sender, EventArgs e)
        {
            using (var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("22521124@gm.uit.edu.vn", smtp_pass),
                EnableSsl = true
            })
            using (var message = new MailMessage(new MailAddress(txtFrom.Text), new MailAddress(txtTo.Text))
            {
                Subject = txtSubject.Text,
                Body = txtBody.Text
            })
            {
                try
                {
                    client.Send(message);
                    MessageBox.Show("Email sent successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
