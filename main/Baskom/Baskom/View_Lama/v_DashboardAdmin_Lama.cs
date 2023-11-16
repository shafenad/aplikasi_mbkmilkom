using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_DashboardAdmin_Lama
    {
        private c_Dashboard c_Dashboard = new c_Dashboard();
        private object data_akun_pengguna = null;

        public v_DashboardAdmin_Lama()
        {
            // construkcor
        }

        public void klikManajemenProfilDosen()
        {
            c_Dashboard.setManajemenProfilDosen();
        }

        public void klikManajemenProfilMahasiswa()
        {
            c_Dashboard.setManajemenProfilMahasiswa();
        }
    }
}
