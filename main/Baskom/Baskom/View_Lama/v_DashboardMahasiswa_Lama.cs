using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_DashboardMahasiswa_Lama
    {
        private c_Dashboard c_Dashboard = new c_Dashboard();
        private object data_akun_pengguna = null;

        public v_DashboardMahasiswa_Lama()
        {
            //construktor
        }

        public void klikKonversiNilai()
        {
            c_Dashboard.setTambahKonversiNilai();
        }

        public void klikKonversiSks()
        {
            c_Dashboard.setTambahKonversiSks();
        }

        public void klikLogout()
        {
            c_Dashboard.logout();
        }

        public void klikMataKuliah()
        {
            c_Dashboard.setMataKuliah();
        }

        public void klikMitra()
        {
            c_Dashboard.setTambahMitra();
        }

        public void klikProfil()
        {
            c_Dashboard.setProfil(data_akun_pengguna);
        }
    }
}
