using Baskom.Controller;
using Baskom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    partial class v_PenerimaanMitra : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_PenerimaanMitra c_PenerimaanMitra;
        private object[] data_mahasiswa;
        private bool available = false;
        public v_PenerimaanMitra(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataBkp m_DataBkp, m_DataAkunDosen m_DataAkunDosen, m_DataMitra m_DataMitra, m_DataPenerimaanMitra m_DataPenerimaanMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_Dashboard = c_Dashboard;
            this.c_PenerimaanMitra = new c_PenerimaanMitra(m_DataBkp, m_DataAkunDosen, m_DataMitra, m_DataPenerimaanMitra);
            this.data_akun_pengguna = data_akun_pengguna;
            data_mahasiswa = data_akun_pengguna.getAttributes();
            this.setDataAkun();
            this.cekDiterimaBelum();
        }
        private void cekDiterimaBelum()
        {
            List<object[]> data_penerimaan = c_PenerimaanMitra.getAllPenerimaanMitra();

            object[] mitra_mahasiswa = new object[9];
            foreach (object[] item in data_penerimaan)
            {
                if ((int)item[8] == (int)data_mahasiswa[0])
                {
                    this.available = true;
                    mitra_mahasiswa = item;
                    break;
                }
            }

            if (available)
            {
                cbx_bkp.Enabled = false;
                cbx_dpa.Enabled = false;
                cbx_mitra.Enabled = false;
                cbx_pkl.Enabled = false;
                tbx_nowa.Enabled = false;
                tbx_bukti.Enabled = false;
                tbx_sks.Enabled = false;

                object[] data_bkp = c_PenerimaanMitra.getDataBKPbyId((int)mitra_mahasiswa[6]);
                object[] data_mitra = c_PenerimaanMitra.getMitrabyId((int)mitra_mahasiswa[8]);
                object[] data_dpa = c_PenerimaanMitra.getDPAbyId((int)mitra_mahasiswa[7]);
                cbx_bkp.Text = (string)data_bkp[1];
                cbx_dpa.Text = (string)data_dpa[3];
                cbx_mitra.Text = (string)data_mitra[1];

                if (Convert.ToInt32(mitra_mahasiswa[1]) == 0)
                {
                    cbx_pkl.Checked = false;
                }
                else
                {
                    cbx_pkl.Checked = true;
                }

                tbx_nowa.Text = (string)mitra_mahasiswa[2];
                tbx_sks.Text = (string)mitra_mahasiswa[3];
                tbx_bukti.Text = (string)mitra_mahasiswa[4];

            }
            else
            {
                this.setComboBoxBKP();
                this.setComboBoxDosen();
                this.setComboBoxMitra();
            }
        }

        private void setDataAkun()
        {
            lbl_namamahasiswa.Text = (string)data_mahasiswa[2];
            lbl_nim.Text = (string)data_mahasiswa[1];

            string inisial = (string)data_mahasiswa[2];

            string[] pisahkan = { " " };
            Int32 count = 2;

            String[] strlist = inisial.Split(pisahkan, count,
               StringSplitOptions.RemoveEmptyEntries);

            string inisialfiks = "";

            foreach (String s in strlist)
            {
                inisialfiks += s[0];
            }

            lbl_inisial.Text = inisialfiks;
        }

        public void setComboBoxBKP()
        {
            List<object[]> data_BKP = c_PenerimaanMitra.getAllDataBKP();

            cbx_bkp.Items.Clear();
            cbx_bkp.ResetText();
            foreach (object[] item in data_BKP)
            {
                cbx_bkp.Items.Add(item[1]);
            }
        }

        public void setComboBoxDosen()
        {
            List<object[]> data_dosen = c_PenerimaanMitra.getAllDataDosen();

            cbx_dpa.Items.Clear();
            cbx_dpa.ResetText();
            foreach (object[] item in data_dosen)
            {
                cbx_dpa.Items.Add(item[3]);
            }
        }

        public void setComboBoxMitra()
        {
            List<object[]> data_mitra = c_PenerimaanMitra.getAllDataMitra();

            cbx_mitra.Items.Clear();
            cbx_mitra.ResetText();
            foreach (object[] item in data_mitra)
            {
                cbx_mitra.Items.Add(item[1]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_simpanmitra_Click(object sender, EventArgs e)
        {
            if (available)
            {
                MessageBox.Show("Datamu sudah terdaftar!");
            }
            else
            {
                object[] penerimaan_mitra = new object[8];

                object bkp = cbx_bkp.SelectedItem;
                object mitra = cbx_mitra.SelectedItem;
                object dpa = cbx_dpa.SelectedItem;

                object bkpDipilih = cbx_bkp.GetItemText(bkp);
                object mitraDipilih = cbx_bkp.GetItemText(mitra);
                object dpaDipilih = cbx_bkp.GetItemText(dpa);

                if (bkpDipilih.ToString() == "")
                {
                    string message = "Pilih BKP Yang Tersedia!";
                    MessageBox.Show(message);
                }
                else if (mitraDipilih.ToString() == "")
                {
                    string message = "Pilih Mitra Yang Tersedia!";
                    MessageBox.Show(message);
                }
                else if (dpaDipilih.ToString() == "")
                {
                    string message = "Pilih DPA Yang Tersedia!";
                    MessageBox.Show(message);
                }
                else if (tbx_sks.Text == "" || tbx_bukti.Text == "" || tbx_nowa.Text == "")
                {
                    string message = "Data harus terisi!";
                    MessageBox.Show(message);
                }
                else if (!int.TryParse(tbx_sks.Text, out _))
                {
                    string message = "Jumlah SKS Bernilai Angka!";
                    MessageBox.Show(message);
                }
                else if (int.Parse(tbx_sks.Text) > 20)
                {
                    string message = "Maksimal Konversi 20 SKS!";
                    MessageBox.Show(message);
                }
                else if (!char.IsDigit(tbx_nowa.Text.ToCharArray()[0]))
                {
                    string message = "Nomor WA Bernilai Angka!";
                    MessageBox.Show(message);

                }
                else if (tbx_nowa.Text.Count() > 13)
                {
                    string message = "Nomor Melebihi Nilai Maksimal!";
                    MessageBox.Show(message);

                }
                else
                {
                    penerimaan_mitra[0] = cbx_pkl.Checked;
                    penerimaan_mitra[1] = tbx_nowa.Text;
                    penerimaan_mitra[2] = tbx_sks.Text;
                    penerimaan_mitra[3] = tbx_bukti.Text;
                    List<object[]> data_BKP = c_PenerimaanMitra.getAllDataBKP();
                    List<object[]> data_mitra = c_PenerimaanMitra.getAllDataMitra();
                    List<object[]> data_dosen = c_PenerimaanMitra.getAllDataDosen();
                    foreach (object[] item in data_BKP)
                    {
                        if ((string)item[1] == (string)bkpDipilih)
                        {
                            penerimaan_mitra[4] = item[0];
                        }
                    }

                    foreach (object[] item in data_mitra)
                    {
                        if ((string)item[1] == (string)mitraDipilih)
                        {
                            penerimaan_mitra[5] = item[0];
                        }
                    }

                    foreach (object[] item in data_dosen)
                    {
                        if ((string)item[3] == (string)dpaDipilih)
                        {
                            penerimaan_mitra[6] = item[0];
                        }
                    }

                    penerimaan_mitra[7] = (int)data_mahasiswa[0];

                    c_PenerimaanMitra.tambahPenerimaanMitra(penerimaan_mitra);

                    this.cekDiterimaBelum();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void lbl_tambahmitra_Click_1(object sender, EventArgs e)
        {
            if (available)
            {
                MessageBox.Show("Datamu sudah terdaftar!");
            }
            else
            {
                this.Hide();
                c_Dashboard.setTambahPengajuanMitra();
            }
        }


        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void statusMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setStatusMOA();
        }

        private void konversiNilaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahKonversiNilai();
        }

        private void informasiAkunToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilMahasiswa();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliahTempuh();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahKonversiSks();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mitraToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

        }
    }
}

