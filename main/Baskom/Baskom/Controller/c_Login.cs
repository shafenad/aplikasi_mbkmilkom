using Baskom.Model;
using Baskom.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_Login
    {
        protected c_Akun c_akun = new c_Akun();

        public void setLoginAdmin()
        {
            v_LoginAdmin v_LoginAdmin = new v_LoginAdmin();
            v_LoginAdmin.Show();
        }

        public void setLoginMahasiswa()
        {
            v_LoginMahasiswa v_LoginMahasiswa = new v_LoginMahasiswa();
            v_LoginMahasiswa.Show();
        }

        public void setLoginTimmbkm()
        {
            v_LoginTimmbkm v_LoginTimmbkm = new v_LoginTimmbkm();
            v_LoginTimmbkm.Show();
        }
    }
}
