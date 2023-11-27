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
    partial class v_TambahDosenTimmbkm : Form
    {
        c_TambahDosenTimmbkm c_TambahDosenTimmbkm;
        public v_TambahDosenTimmbkm(m_DataAkunTimmbkm m_DataAkunTimmbkm, m_DataAkunDosen m_DataAkunDosen)
        {
            InitializeComponent();
            this.c_TambahDosenTimmbkm = new c_TambahDosenTimmbkm(m_DataAkunTimmbkm, m_DataAkunDosen);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void daftardosen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_tambahtambahdosen_Click(object sender, EventArgs e)
        {
            string message = "";
            object[] dosen = new object[9];
            dosen[0] = tbx_niptambahdosen.Text;
            dosen[1] = tbx_nidntambahdosen.Text;
            dosen[2] = tbx_namatambahdosen.Text;
            dosen[3] = tbx_nowatambahdosen.Text;
            dosen[4] = tbx_emailtambahdosen.Text;
            dosen[5] = tbx_katasanditambahdosen.Text;
            dosen[6] = cbx_jabatandosen.Text;
            message = this.c_TambahDosenTimmbkm.tambahDosenBaru(dosen);
            if (dosen[6].ToString() == "Tim MBKM")
            {
                this.c_TambahDosenTimmbkm.tambahTimmbkmBaru(dosen);
            }
            if (message.Length > 0)
            {
                MessageBox.Show(message);
            }
            else
            {
                this.Close();
            }
        }
    }
}
