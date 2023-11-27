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
        private c_Akun c_Akun;
        private v_LoginAdmin v_LoginAdmin;
        private v_LoginMahasiswa v_LoginMahasiswa;
        private v_LoginTimmbkm v_LoginTimmbkm;

        public c_Login (v_Login v_Login)
        {
            this.c_Akun = new c_Akun(v_Login);
            this.v_LoginAdmin = new v_LoginAdmin(v_Login, c_Akun);
            this.v_LoginTimmbkm = new v_LoginTimmbkm(v_Login, c_Akun);
            this.v_LoginMahasiswa = new v_LoginMahasiswa(v_Login, c_Akun);
        }
        public void setLoginAdmin()
        {
            v_LoginAdmin.Show();
        }

        public void setLoginMahasiswa()
        {
            v_LoginMahasiswa.Show();
        }

        public void setLoginTimmbkm()
        {
            v_LoginTimmbkm.Show();
        }
    }
}
