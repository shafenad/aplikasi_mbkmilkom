using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gajelas
{
    public partial class ProfilTimMBKM : Form
    {
        public ProfilTimMBKM()
        {
            InitializeComponent();
        }

        private void lnk_ubahsandi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UbahKataSandi ubah_sandi = new UbahKataSandi();
            ubah_sandi.Show();
        }
    }
}
