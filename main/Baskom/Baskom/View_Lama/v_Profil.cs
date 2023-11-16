using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_Profil
    {
        private c_Profil c_Profil = new c_Profil();

        public void klikUbahKataSandi()
        {
            c_Profil.setFormUbahKataSandi();
        }
    }
}
