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
        private string nama_admin = "";
        private string nidn = "";
        private string nim = "";
        private v_DashboardAdmin_Lama v_DashboardAdmin = new v_DashboardAdmin_Lama();
        private v_DashboardMahasiswa_Lama v_DashboardMahasiswa = new v_DashboardMahasiswa_Lama();
        private v_DashboardTimmbkm_Lama v_DashboardTimmbkm = new v_DashboardTimmbkm_Lama();

        public c_Akun()
        {
            //constructor
        }

        public bool cekLoginAdmin(string nama_admin, string kata_sandi)
        {
            string[] dataAdmin = m_DataAkunAdmin.getAdminByNama(nama_admin, kata_sandi);
            return dataAdmin.Length != 0;
        }

        public bool cekLoginMahasiswa(string nim, string kata_sandi)
        {
            string[] dataMahasiswa = m_DataAkunMahasiswa.getMahasiswaByNim(nim, kata_sandi);
            return dataMahasiswa.Length != 0;
        }

        public bool cekLoginTimmbkm(string nidn, string kata_sandi)
        {
            string[] dataTimmbkm = m_DataAkunTimmbkm.getTimmbkmByNidn(nidn, kata_sandi);
            return dataTimmbkm.Length != 0;
        }

        public void loginAdmin(object m_DataAkunAdmin)
        {
            v_DashboardAdmin v_DashboardAdmin = new v_DashboardAdmin();
            // v_DashboardAdmin.data_akun_pengguna(m_DataAkunAdmin);
            this.setDashboard(v_DashboardAdmin);
        }

        public void loginMahasiswa(object m_DataAkunMahasiswa)
        {
            v_DashboardMahasiswa v_DashboardMahasiswa = new v_DashboardMahasiswa();
            // v_DashboardMahasiswa.data_akun_pengguna(m_DataAkunMahasiswa);
            this.setDashboard(v_DashboardMahasiswa);
        }

        public void loginTimmbkm(object m_DataTimmbkm)
        {
            v_DashboardTimmbkm v_DashboardTimmbkm = new v_DashboardTimmbkm();
            // v_DashboardTimmbkm.data_akun_pengguna(m_DataAkunTimmbkm);
            this.setDashboard(v_DashboardTimmbkm);
        }

        public void setDashboard(Form v_Dashboard)
        {
            v_Dashboard.ShowDialog();
        }
    }
}
