using Baskom.Controller;
using Baskom.Model;

namespace Baskom.View
{
    public partial class v_LoginAdmin : Form
    {
        private c_Akun c_Akun = new c_Akun();
        private m_DataAkunAdmin m_DataAkunAdmin = new m_DataAkunAdmin();

        public v_LoginAdmin()
        {
            InitializeComponent();
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
            c_Akun.loginAdmin(nidn, kata_sandi);
        }

        private void lnk_loginsebagaiyanglain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            v_Login v_Login = new v_Login();
            v_Login.Show();
            this.Hide();
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