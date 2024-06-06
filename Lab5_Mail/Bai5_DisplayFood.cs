using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Mail
{
    public partial class Bai5_DisplayFood : Form
    {
        int a = 0;
        string in4 = "";
        public Bai5_DisplayFood(Control selectedControl, string s, int dem)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(selectedControl);
            in4 = s;
            a = dem;
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            if (!EmailSetting.IsEmailConfigured)
            {
                MessageBox.Show("Bạn cần cài đặt Email Server để sử dụng tính năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailSetting emailSetting = new EmailSetting();
                emailSetting.Show();
            }
            else
            {
                Control controlToMove = flowLayoutPanel1.Controls[0];
                Bai5_Invite invite = new Bai5_Invite(controlToMove, in4);
                invite.Show();
            }
            a++;
        }
    }
}
