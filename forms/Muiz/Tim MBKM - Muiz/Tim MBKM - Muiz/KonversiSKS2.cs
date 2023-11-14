using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tim_MBKM___Muiz
{
    public partial class KonversiSKS2 : Form
    {
        public KonversiSKS2()
        {
            InitializeComponent();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            new KonversiSKS().Show(); 
            this.Hide();
        }
    }
}
