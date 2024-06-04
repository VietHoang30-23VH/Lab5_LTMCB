using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using MimeKit;
using System.Xml.Linq;

namespace Lab5_Mail
{
    public partial class Datve : Form
    {
        public Datve()
        {
            InitializeComponent();
            this.Load += new EventHandler(Datve_Load); // Ensure Datve_Load is assigned
        }

        public Dictionary<string, int> dsphim { get; set; }
        private string[] sogheedachon;

        private void btxuatve_Click(object sender, EventArgs e)
        {
            sogheedachon = LayPhanTuDaChon();
            string vitringoi = string.Join("\n", sogheedachon);
            if (comboBox1.SelectedItem != null && dsphim.ContainsKey(comboBox1.Text))
            {
                MessageBox.Show(string.Format("Khách hàng: {2}\nPhim: {0}\nPhòng: {4}\nVị trí ngồi: {3}\nGiá: {1}",

               comboBox1.Text, dsphim[comboBox1.Text], txbhoten.Text, vitringoi, cbphong.Text));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phim hợp lệ.");
            }
            SendMail(tbemail.Text,comboBox1.Text, dsphim[comboBox1.Text], txbhoten.Text, vitringoi, cbphong.Text);
        }
        string smtp_pass = "abjj grnr pvih qdgo";
        private void SendMail(string mail, string phim, int Giave, string Hoten, string vitringoi, string phong)
        {
            try
            {
                using (var client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("nguyentaihieu004@gmail.com", smtp_pass);
                    client.EnableSsl = true;

                    using (var message = new MailMessage(new MailAddress("nguyentaihieu004@gmail.com"), new MailAddress(tbemail.Text)))
                    {
                        message.Subject = "Bạn đã đặt vé thành công đây là thông tin vé của bạn";
                        message.Body = "Xin chào," + Environment.NewLine +
                                       "Cảm ơn bạn đã đặt vé phim. Dưới đây là thông tin chi tiết:" + Environment.NewLine +
                                       "Khách hàng: " + Hoten + Environment.NewLine +
                                       "Phim: " + phim + Environment.NewLine +
                                       "Phòng: " + phong + Environment.NewLine +
                                       "Vị trí ngồi: " + vitringoi + Environment.NewLine +
                                       "Giá vé: " + Giave + Environment.NewLine +
                                       "Xin cảm ơn!";

                        client.Send(message);
                        MessageBox.Show("Email sent successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private string[] LayPhanTuDaChon()
        {
            List<string> phanTuDaChon = new List<string>();

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                string phanTu = itemChecked.ToString();
                phanTuDaChon.Add(phanTu);
            }

            return phanTuDaChon.ToArray();
        }

        private void Datve_Load(object sender, EventArgs e)
        {
            if (dsphim != null)
            {
                foreach (string phim in dsphim.Keys)
                {
                    comboBox1.Items.Add(phim);
                }
            }
            else
            {
                MessageBox.Show("Danh sách phim trống.");
            }
        }

        private void Datve_Load_1(object sender, EventArgs e)
        {

        }
    }
}
