using Baskom.Model;
using Baskom.View;
using Baskom.View_Lama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_Akun
    {
        private m_DataAkunAdmin m_DataAkunAdmin;
        private m_DataAkunMahasiswa m_DataAkunMahasiswa;
        private m_DataAkunTimmbkm m_DataAkunTimmbkm;
        private v_Login v_Login;

        public c_Akun(v_Login v_Login)
        {
            this.v_Login = v_Login;
        }
        public void loginAdmin(string email, string kata_sandi, v_LoginAdmin form)
        {
            this.m_DataAkunAdmin = new m_DataAkunAdmin();
            bool check = this.m_DataAkunAdmin.cekLoginAdmin(email, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(this.v_Login,this.m_DataAkunAdmin);
                c_Dashboard.setDashboardAdmin();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
            }
        }

        public void loginMahasiswa(string nim, string kata_sandi, v_LoginMahasiswa form)
        {
            this.m_DataAkunMahasiswa = new m_DataAkunMahasiswa();
            bool check = this.m_DataAkunMahasiswa.cekLoginMahasiswa(nim, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(this.v_Login,this.m_DataAkunMahasiswa);
                c_Dashboard.setDashboardMahasiswa();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
            }
        }

        public void loginTimmbkm(string nidn, string kata_sandi, v_LoginTimmbkm form)
        {
            this.m_DataAkunTimmbkm = new m_DataAkunTimmbkm();
            bool check = this.m_DataAkunTimmbkm.cekLoginTimmbkm(nidn, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(this.v_Login,this.m_DataAkunTimmbkm);
                c_Dashboard.setDashboardTimmbkm();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
            }
        }
    }
}
