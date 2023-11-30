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
    partial class v_DetailValidasiKonversiSks : Form
    {
        c_DetailValidasiKonversiSKS c_DetailValidasiKonversiSKS;
        public v_DetailValidasiKonversiSks(string nama_mhs, string nim, string nama_mitra, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataKonversiSks m_DataKonversiSks, m_DataMataKuliah m_DataMataKuliah)
        {
            InitializeComponent();
            lbl_NamaOrang.Text = nama_mhs;
            lbl_NIM.Text = nim;
            lbl_namamitra.Text = nama_mitra;
            this.c_DetailValidasiKonversiSKS = new c_DetailValidasiKonversiSKS(m_DataAkunMahasiswa, m_DataKonversiSks, m_DataMataKuliah);
            this.init();
        }
        public void init()
        {
            dataGridView1.Rows.Clear();
            List<object[]> data = c_DetailValidasiKonversiSKS.initDataGridView();
            foreach (object[] item in data)
            {
                bool status_validasi = (Convert.ToInt32(item[4])) == 1 ? true : false;
                dataGridView1.Rows.Add(item[0], item[1], item[2], item[3], true);
            }
        }
        private void btn_simpan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
