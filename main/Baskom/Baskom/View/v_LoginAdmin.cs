using Baskom.Controller;
using Baskom.Model;

namespace Baskom.View
{
    partial class v_LoginAdmin : Form
    {
        private c_Akun c_Akun;
        private m_DataAkunAdmin m_DataAkunAdmin = new();

        public v_LoginAdmin(c_Akun c_Akun)
        {
            InitializeComponent();
            this.c_Akun = c_Akun;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_katasandi_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nidn = tbx_email.Text;
            string kata_sandi = tbx_katasandi.Text;
            c_Akun.loginAdmin(nidn, kata_sandi,this);
            this.Close();
        }

        private void lnk_loginsebagaiyanglain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            v_Login v_Login = new();
            v_Login.Show();
            this.Close();
        }

        public bool loginAdmin(string email_admin, string kata_sandi)
        {
            if (email_admin.Length == 0 || kata_sandi.Length == 0)
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