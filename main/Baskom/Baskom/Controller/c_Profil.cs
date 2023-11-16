using Baskom.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_Profil
    {
        public void setFormUbahKataSandi()
        {
            Form v_FormUbahKataSandi = new Form();
            v_FormUbahKataSandi.ShowDialog();
        }

        public void ubahKataSandi(string kata_sandi, string kata_sandi_baru)
        {
            // Tempat ngubah kata sandi
        }
    }
}
