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
        protected m_DataAkunAdmin m_DataAkunAdmin = new m_DataAkunAdmin();
        protected m_DataAkunMahasiswa m_DataAkunMahasiswa = new m_DataAkunMahasiswa();
        protected m_DataAkunTimmbkm m_DataAkunTimmbkm = new m_DataAkunTimmbkm();
        private c_Dashboard c_Dashboard;

        public c_Akun()
        {
            //constructor
        }
        public void loginAdmin(string email, string kata_sandi, v_LoginAdmin form)
        {
            bool check = this.m_DataAkunAdmin.cekLoginAdmin(email, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(m_DataAkunAdmin);
                this.c_Dashboard = c_Dashboard;
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
            bool check = this.m_DataAkunMahasiswa.cekLoginMahasiswa(nim, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(m_DataAkunMahasiswa);
                this.c_Dashboard = c_Dashboard;
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
            bool check = this.m_DataAkunTimmbkm.cekLoginTimmbkm(nidn, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(m_DataAkunTimmbkm);
                this.c_Dashboard = c_Dashboard;
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
