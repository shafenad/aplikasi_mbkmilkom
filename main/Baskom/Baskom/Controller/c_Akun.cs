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
        private string kata_sandi = "";
        protected m_DataAkunAdmin m_DataAkunAdmin = new m_DataAkunAdmin();
        protected m_DataAkunMahasiswa m_DataAkunMahasiswa = new m_DataAkunMahasiswa();
        protected m_DataAkunTimmbkm m_DataAkunTimmbkm = new m_DataAkunTimmbkm();
        private v_DashboardAdmin_Lama v_DashboardAdmin = new v_DashboardAdmin_Lama();
        private v_DashboardMahasiswa_Lama v_DashboardMahasiswa = new v_DashboardMahasiswa_Lama();
        private v_DashboardTimmbkm_Lama v_DashboardTimmbkm = new v_DashboardTimmbkm_Lama();

        public c_Akun()
        {
            //constructor
        }
        public void loginAdmin(string email, string kata_sandi)
        {
            bool check = this.m_DataAkunAdmin.cekLoginAdmin(email, kata_sandi);
            if (check)
            {
                v_DashboardAdmin v_DashboardAdmin = new v_DashboardAdmin();
                this.setDashboard(v_DashboardAdmin);
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
            }
        }

        public void loginMahasiswa(string nim, string kata_sandi)
        {
            bool check = this.m_DataAkunMahasiswa.cekLoginMahasiswa(nim, kata_sandi);
            if (check)
            {
                v_DashboardMahasiswa v_DashboardMahasiswa = new v_DashboardMahasiswa();
                this.setDashboard(v_DashboardMahasiswa);
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
            }
        }

        public void loginTimmbkm(string nidn, string kata_sandi)
        {
            bool check = this.m_DataAkunTimmbkm.cekLoginTimmbkm(nidn, kata_sandi);
            if (check)
            {
                v_DashboardTimmbkm v_DashboardTimmbkm = new v_DashboardTimmbkm();
                this.setDashboard(v_DashboardTimmbkm);
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
            }
        }

        public void setDashboard(Form v_Dashboard)
        {
            v_Dashboard.ShowDialog();
        }
    }
}
