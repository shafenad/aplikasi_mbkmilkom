using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bismillah_duarr
{
    public partial class statusmitra : Form
    {
        public statusmitra()
        {
            InitializeComponent();
        }

        private void btn_simpanstatus_Click(object sender, EventArgs e)
        {
            mitra form1 = new mitra();
            form1.Show();
            this.Hide();
        }

        private void statusmitra_Load(object sender, EventArgs e)
        {

        }
    }
}
