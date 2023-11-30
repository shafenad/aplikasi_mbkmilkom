using Baskom.Controller;
using Baskom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    partial class v_LoginTimmbkm : Form
    {
        private c_Akun c_Akun;
        private m_DataAkunTimmbkm m_DataAkunTimmbkm = new();

        public v_LoginTimmbkm(c_Akun c_Akun)
        {
            InitializeComponent();
            this.c_Akun = c_Akun;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nidn = tbx_NIDN.Text;
            string kata_sandi = tbx_katasandi.Text;
            this.Close();
            c_Akun.loginTimmbkm(nidn, kata_sandi, this);
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
            this.Close();
            v_Login v_Login = new();
            v_Login.Show();
        }

        private void pic_logobaskom_Click(object sender, EventArgs e)
        {

        }

        public bool loginTimmbkm(string nidn_timmbkm, string kata_sandi)
        {
            if (nidn_timmbkm.Length == 0 || kata_sandi.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
