using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_DashboardTimmbkm_Lama
    {
        private c_Dashboard c_Dashboard = new c_Dashboard();
        private object data_akun_pengguna = null;

        public v_DashboardTimmbkm_Lama() { }

        public void klikMelihatKonversiNilai()
        {
            c_Dashboard.setMelihatKonversiNilai();
        }

        public void klikMelihatKonversiSks()
        {
            c_Dashboard.setMelihatKonversiSks();
        }

        public void klikMemvalidasiPengajuanMitra()
        {
            c_Dashboard.setValidasiPengajuanMitra();
        }

        public void klikPembagianTugas()
        {
            c_Dashboard.setPembagianTugas();
        }
    }
}
