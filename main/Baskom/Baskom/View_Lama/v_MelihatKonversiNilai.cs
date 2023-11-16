using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_MelihatKonversiNilai
    {
        private c_KonversiNilai c_KonversiNilai = new c_KonversiNilai();

        public v_MelihatKonversiNilai()
        {
            // constructor
        }

        public void klikDetail()
        {
            c_KonversiNilai.showKonversiNilai();
        }
    }
}
