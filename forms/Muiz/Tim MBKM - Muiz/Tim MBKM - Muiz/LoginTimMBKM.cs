using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tim_MBKM___Muiz
{
    public partial class LoginTimMBKM : Form
    {
        public LoginTimMBKM()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void tbx_NIDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_katasandi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnk_lupasandi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnk_loginsebagaiyanglain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
