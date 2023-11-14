namespace Tim_MBKM___Muiz
{
    partial class KonversiSKS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KonversiSKS));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penerimaanMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembagianTugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiSKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiNIlaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informasiAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_daftarmahasiswa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramStudi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMItra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosisiKegiatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.penerimaanMitraToolStripMenuItem,
            this.pembagianTugasToolStripMenuItem,
            this.konversiSKSToolStripMenuItem,
            this.konversiNIlaiToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // penerimaanMitraToolStripMenuItem
            // 
            this.penerimaanMitraToolStripMenuItem.Name = "penerimaanMitraToolStripMenuItem";
            this.penerimaanMitraToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.penerimaanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            this.penerimaanMitraToolStripMenuItem.Click += new System.EventHandler(this.penerimaanMitraToolStripMenuItem_Click);
            // 
            // pembagianTugasToolStripMenuItem
            // 
            this.pembagianTugasToolStripMenuItem.Name = "pembagianTugasToolStripMenuItem";
            this.pembagianTugasToolStripMenuItem.Size = new System.Drawing.Size(168, 29);
            this.pembagianTugasToolStripMenuItem.Text = "Pembagian Tugas";
            this.pembagianTugasToolStripMenuItem.Click += new System.EventHandler(this.pembagianTugasToolStripMenuItem_Click);
            // 
            // konversiSKSToolStripMenuItem
            // 
            this.konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            this.konversiSKSToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            this.konversiSKSToolStripMenuItem.Click += new System.EventHandler(this.konversiSKSToolStripMenuItem_Click);
            // 
            // konversiNIlaiToolStripMenuItem
            // 
            this.konversiNIlaiToolStripMenuItem.Name = "konversiNIlaiToolStripMenuItem";
            this.konversiNIlaiToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.konversiNIlaiToolStripMenuItem.Text = "Konversi Nilai";
            this.konversiNIlaiToolStripMenuItem.Click += new System.EventHandler(this.konversiNIlaiToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informasiAkunToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // informasiAkunToolStripMenuItem
            // 
            this.informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            this.informasiAkunToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            this.informasiAkunToolStripMenuItem.Click += new System.EventHandler(this.informasiAkunToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.logoutToolStripMenuItem.Text = "Log out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lbl_daftarmahasiswa
            // 
            this.lbl_daftarmahasiswa.AutoSize = true;
            this.lbl_daftarmahasiswa.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daftarmahasiswa.Location = new System.Drawing.Point(13, 50);
            this.lbl_daftarmahasiswa.Name = "lbl_daftarmahasiswa";
            this.lbl_daftarmahasiswa.Size = new System.Drawing.Size(359, 64);
            this.lbl_daftarmahasiswa.TabIndex = 1;
            this.lbl_daftarmahasiswa.Text = "Daftar Mahasiswa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.NIM,
            this.ProgramStudi,
            this.NamaMItra,
            this.PosisiKegiatan,
            this.SKS});
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(945, 321);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            // 
            // NIM
            // 
            this.NIM.HeaderText = "NIM";
            this.NIM.MinimumWidth = 8;
            this.NIM.Name = "NIM";
            // 
            // ProgramStudi
            // 
            this.ProgramStudi.HeaderText = "Program Studi";
            this.ProgramStudi.MinimumWidth = 8;
            this.ProgramStudi.Name = "ProgramStudi";
            // 
            // NamaMItra
            // 
            this.NamaMItra.HeaderText = "Nama Mitra";
            this.NamaMItra.MinimumWidth = 8;
            this.NamaMItra.Name = "NamaMItra";
            // 
            // PosisiKegiatan
            // 
            this.PosisiKegiatan.HeaderText = "Posisi Kegiatan/Tema";
            this.PosisiKegiatan.MinimumWidth = 8;
            this.PosisiKegiatan.Name = "PosisiKegiatan";
            // 
            // SKS
            // 
            this.SKS.HeaderText = "SKS";
            this.SKS.MinimumWidth = 8;
            this.SKS.Name = "SKS";
            this.SKS.Text = "Detail";
            // 
            // KonversiSKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_daftarmahasiswa);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KonversiSKS";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penerimaanMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembagianTugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiSKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiNIlaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.Label lbl_daftarmahasiswa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramStudi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMItra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosisiKegiatan;
        private System.Windows.Forms.DataGridViewButtonColumn SKS;
        private System.Windows.Forms.ToolStripMenuItem informasiAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}