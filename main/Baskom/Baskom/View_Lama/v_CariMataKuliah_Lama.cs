using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_CariMataKuliah_Lama
    {
        private c_CariMataKuliah c_CariMataKuliah = new c_CariMataKuliah();

        public v_CariMataKuliah_Lama()
        {
            // constructor
        }

        public void klikCari()
        {
            c_CariMataKuliah.cariMataKuliah("dummy");
        }

        public void klikKembali()
        {
            // this.Close();
        }
    }
}
