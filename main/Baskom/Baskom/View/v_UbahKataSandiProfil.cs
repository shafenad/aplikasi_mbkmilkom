using Baskom.Controller;
using Baskom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    partial class v_UbahKataSandiProfil : Form
    {
        private c_UbahKataSandiProfil c_UbahKataSandiProfil;
        private int panjang_sandi;
        private int index_kata_sandi;
        private object[] atribut_data_akun;
        public v_UbahKataSandiProfil(m_DataAkunMahasiswa data_akun_pengguna)
        {
            InitializeComponent();
            this.c_UbahKataSandiProfil = new c_UbahKataSandiProfil(data_akun_pengguna);
            this.atribut_data_akun = data_akun_pengguna.getAttributes();
            this.index_kata_sandi = 8;
            this.panjang_sandi = ((string)atribut_data_akun[this.index_kata_sandi]).Length;
            this.sembunyikanKataSandi();

        }
        public v_UbahKataSandiProfil(m_DataAkunTimmbkm data_akun_pengguna)
        {
            InitializeComponent();
            this.c_UbahKataSandiProfil = new c_UbahKataSandiProfil(data_akun_pengguna);
            this.atribut_data_akun = data_akun_pengguna.getDosenAttributes();
            this.index_kata_sandi = 6;
            this.panjang_sandi = ((string)atribut_data_akun[this.index_kata_sandi]).Length;
            this.sembunyikanKataSandi();
        }
        public v_UbahKataSandiProfil(m_DataAkunAdmin data_akun_pengguna)
        {
            InitializeComponent();
            this.c_UbahKataSandiProfil = new c_UbahKataSandiProfil(data_akun_pengguna);
            this.atribut_data_akun = data_akun_pengguna.getAttributes();
            this.index_kata_sandi = 3;
            this.panjang_sandi = ((string)atribut_data_akun[this.index_kata_sandi]).Length;
            this.sembunyikanKataSandi();
        }

        private void sembunyikanKataSandi()
        {
            lbl_katasandilama.Text = String.Concat(Enumerable.Repeat('*', this.panjang_sandi));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            string kata_sandi_baru = tbx_katasandibaru.Text;
            if (kata_sandi_baru == tbx_konfirmasikatasandibaru.Text)
            {
                message = c_UbahKataSandiProfil.ubahKataSandiProfil((int)atribut_data_akun[0], kata_sandi_baru);
                this.atribut_data_akun[8] = kata_sandi_baru;
                this.panjang_sandi = kata_sandi_baru.Length;
                this.sembunyikanKataSandi();
                tbx_katasandibaru.Text = "";
                tbx_konfirmasikatasandibaru.Text = "";
            }
            if (message.Length > 0)
            {
                MessageBox.Show(message);
                this.Close();
            }
        }

        private void btn_lihat_Click(object sender, EventArgs e)
        {
            string kata_sandi = lbl_katasandilama.Text;
            if (kata_sandi[0] == '*')
            {
                lbl_katasandilama.Text = (string)atribut_data_akun[this.index_kata_sandi];
            }
            else
            {
                this.sembunyikanKataSandi();
            }
        }
    }
}
