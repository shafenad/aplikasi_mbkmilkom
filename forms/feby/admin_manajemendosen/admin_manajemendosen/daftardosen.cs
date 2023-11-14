namespace admin_manajemendosen
{
    public partial class daftardosen : Form
    {
        public daftardosen()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new profiledosen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new tambahdosen().Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new daftarmahasiswa().Show();
        }
    }
}