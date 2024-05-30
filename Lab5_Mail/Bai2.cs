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
using MailKit.Net.Imap;
using MailKit;

namespace Lab5_Mail
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate(tbEmail.Text, tbPass.Text);
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            labeltotal.Text = inbox.Count.ToString();
            labelRecent.Text = inbox.Recent.ToString();
            for (int i = 0; i < inbox.Count; i++)
            {
                var mess = inbox.GetMessage(i);
                dataGridView1.Rows.Add(mess.Subject, mess.From, mess.Date);
            }
        }
        private void ConfigureDataGridView()
        {


            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("From", "From");
            dataGridView1.Columns.Add("Date", "Date");


            dataGridView1.Columns["From"].Width = 200;
            dataGridView1.Columns["Subject"].Width = 300;
            dataGridView1.Columns["Date"].Width = 150;
        }
    }
}
