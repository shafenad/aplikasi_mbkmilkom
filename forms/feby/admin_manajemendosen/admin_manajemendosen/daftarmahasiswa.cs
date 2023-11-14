using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_manajemendosen
{
    public partial class daftarmahasiswa : Form
    {
        public daftarmahasiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambahdaftarmhsadmin_Click(object sender, EventArgs e)
        {
            new tambahmahasiswa().Show();
        }

        private void tbl_daftarmhsadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new profilemhs().Show();
        }
    }
}
