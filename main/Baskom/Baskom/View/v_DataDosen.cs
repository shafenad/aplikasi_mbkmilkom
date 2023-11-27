using Baskom.Controller;
using Baskom.Model;

namespace Baskom.View
{
    partial class v_DataDosen : Form
    {
        c_Dashboard c_Dashboard;
        c_DataDosen c_DataDosen;
        private List<object> array_data;

        public v_DataDosen(c_Dashboard c_Dashboard, m_DataAkunDosen m_DataAkunDosen)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_DataDosen = new c_DataDosen(m_DataAkunDosen);
            this.initDataGridView();
        }
        public void initDataGridView()
        {
            tbl_daftardosenadmin.Rows.Clear();
            array_data = this.c_DataDosen.initDataGridView();
            foreach (object[] item in array_data)
            {
                tbl_daftardosenadmin.Rows.Add(item[3], item[1]);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c_Dashboard.setTambahDosenTimmbkm();
            this.initDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDataMahasiswa();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardAdmin();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setProfilAdmin();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setLogout();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tambagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMataKuliah();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahProgram();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMataKuliah();
        }

        private void tambahMitraProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMitraProgram();
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahProgramMataKuliah();
        }
    }
}