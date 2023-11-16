namespace Baskom.View
{
    public partial class v_DataDosen : Form
    {
        public v_DataDosen()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DataDosen v_DataDosen = new v_DataDosen();
            v_DataDosen.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*new profiledosen().Show();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*new v_TambahDataDosen().Show();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DataMahasiswa v_DataMahasiswa = new v_DataMahasiswa();
            v_DataMahasiswa.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardAdmin v_DashboardAdmin = new v_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilAdmin v_ProfilAdmin = new v_ProfilAdmin();
            v_ProfilAdmin.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginAdmin v_LoginAdmin = new v_LoginAdmin();
            v_LoginAdmin.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}