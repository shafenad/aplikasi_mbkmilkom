using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_FormUbahKataSandi_Lama : c_Profil
    {
        public void klikSimpan()
        {
            string kata_sandi = "dummy";
            string kata_sandi_baru = "dummy";

            ubahKataSandi(kata_sandi, kata_sandi_baru);
        }
    }
}
