using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
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
using System.IO;

namespace Lab5_Mail
{
    public partial class Bai5_Invitation : Form
    {
        public Bai5_Invitation()
        {
            InitializeComponent();
        }

        public class EmailInfo
        {
            public string Id { get; set; }
            public string From { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
            public string FileAttactment { get; set; }
        }

        private async void Bai5_Invitation_Load(object sender, EventArgs e)
        {
            var listEmail = new List<EmailInfo>();
            var mailClient = new ImapClient();
            mailClient.Connect("imap.gmail.com", 993);
            mailClient.Authenticate(Constants.EMAIL, Constants.PASSWORD);
            var folder = await mailClient.GetFolderAsync(Constants.FOLDER_READ);
            await folder.OpenAsync(FolderAccess.ReadWrite);

            var searchQuery = SearchQuery.SubjectContains("You have an invitation");
            IList<UniqueId> uids = await folder.SearchAsync(searchQuery);

            foreach (UniqueId uid in uids)
            {
                MimeMessage message = await folder.GetMessageAsync(uid);
                var emailInfo = new EmailInfo();
                emailInfo.Id = uid.ToString();
                emailInfo.From = message.From.ToString();
                emailInfo.TimeReceive = message.Date;
                emailInfo.Subject = message.Subject;
                emailInfo.Body = message.GetTextBody(MimeKit.Text.TextFormat.Text);
                var fileAttactment = new List<string>();

                foreach (MimeEntity attachment in message.Attachments)
                {
                    var fileName = attachment.ContentDisposition?.FileName ?? attachment.ContentType.Name;
                    fileAttactment.Add(fileName);

                    using (var stream = File.Create(fileName))
                    {
                        if (attachment is MessagePart)
                        {
                            var rfc822 = (MessagePart)attachment;
                            await rfc822.Message.WriteToAsync(stream);
                        }
                        else
                        {
                            var part = (MimePart)attachment;
                            await part.Content.DecodeToAsync(stream);
                        }
                    }
                }
                emailInfo.FileAttactment = string.Join("; ", fileAttactment);
                listEmail.Add(emailInfo);
            }
            dataGridView1.DataSource = listEmail;
        }
    }
}
