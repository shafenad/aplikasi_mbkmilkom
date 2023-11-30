namespace Baskom.View
{
    partial class v_MemvalidasiKonversiSks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_MemvalidasiKonversiSks));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            penerimaanMitraToolStripMenuItem = new ToolStripMenuItem();
            daftarMitraToolStripMenuItem = new ToolStripMenuItem();
            pengajuanMOAToolStripMenuItem = new ToolStripMenuItem();
            pembagianTugasToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNIlaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            lbl_daftarmahasiswa = new Label();
            dataGridView1 = new DataGridView();
            Nama = new DataGridViewTextBoxColumn();
            NIM = new DataGridViewTextBoxColumn();
            ProgramStudi = new DataGridViewTextBoxColumn();
            NamaMItra = new DataGridViewTextBoxColumn();
            PosisiKegiatan = new DataGridViewTextBoxColumn();
            SKS = new DataGridViewButtonColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, penerimaanMitraToolStripMenuItem, pembagianTugasToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNIlaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1069, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(116, 29);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // penerimaanMitraToolStripMenuItem
            // 
            penerimaanMitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daftarMitraToolStripMenuItem, pengajuanMOAToolStripMenuItem });
            penerimaanMitraToolStripMenuItem.Name = "penerimaanMitraToolStripMenuItem";
            penerimaanMitraToolStripMenuItem.Size = new Size(165, 29);
            penerimaanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            penerimaanMitraToolStripMenuItem.Click += penerimaanMitraToolStripMenuItem_Click;
            // 
            // daftarMitraToolStripMenuItem
            // 
            daftarMitraToolStripMenuItem.Name = "daftarMitraToolStripMenuItem";
            daftarMitraToolStripMenuItem.Size = new Size(220, 34);
            daftarMitraToolStripMenuItem.Text = "Daftar Mitra";
            daftarMitraToolStripMenuItem.Click += daftarMitraToolStripMenuItem_Click;
            // 
            // pengajuanMOAToolStripMenuItem
            // 
            pengajuanMOAToolStripMenuItem.Name = "pengajuanMOAToolStripMenuItem";
            pengajuanMOAToolStripMenuItem.Size = new Size(220, 34);
            pengajuanMOAToolStripMenuItem.Text = "Validasi MOA";
            pengajuanMOAToolStripMenuItem.Click += pengajuanMOAToolStripMenuItem_Click;
            // 
            // pembagianTugasToolStripMenuItem
            // 
            pembagianTugasToolStripMenuItem.Name = "pembagianTugasToolStripMenuItem";
            pembagianTugasToolStripMenuItem.Size = new Size(168, 29);
            pembagianTugasToolStripMenuItem.Text = "Pembagian Tugas";
            pembagianTugasToolStripMenuItem.Click += pembagianTugasToolStripMenuItem_Click;
            // 
            // konversiSKSToolStripMenuItem
            // 
            konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            konversiSKSToolStripMenuItem.Size = new Size(130, 29);
            konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            konversiSKSToolStripMenuItem.Click += konversiSKSToolStripMenuItem_Click;
            // 
            // konversiNIlaiToolStripMenuItem
            // 
            konversiNIlaiToolStripMenuItem.Name = "konversiNIlaiToolStripMenuItem";
            konversiNIlaiToolStripMenuItem.Size = new Size(134, 29);
            konversiNIlaiToolStripMenuItem.Text = "Konversi Nilai";
            konversiNIlaiToolStripMenuItem.Click += konversiNIlaiToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logoutToolStripMenuItem });
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(69, 29);
            profilToolStripMenuItem.Text = "Profil";
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(235, 34);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(235, 34);
            logoutToolStripMenuItem.Text = "Log out";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // lbl_daftarmahasiswa
            // 
            lbl_daftarmahasiswa.AutoSize = true;
            lbl_daftarmahasiswa.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_daftarmahasiswa.Location = new Point(14, 62);
            lbl_daftarmahasiswa.Name = "lbl_daftarmahasiswa";
            lbl_daftarmahasiswa.Size = new Size(321, 40);
            lbl_daftarmahasiswa.TabIndex = 1;
            lbl_daftarmahasiswa.Text = "Daftar Mahasiswa";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nama, NIM, ProgramStudi, NamaMItra, PosisiKegiatan, SKS });
            dataGridView1.Location = new Point(13, 146);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1050, 401);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 8;
            Nama.Name = "Nama";
            // 
            // NIM
            // 
            NIM.HeaderText = "NIM";
            NIM.MinimumWidth = 8;
            NIM.Name = "NIM";
            // 
            // ProgramStudi
            // 
            ProgramStudi.HeaderText = "Program Studi";
            ProgramStudi.MinimumWidth = 8;
            ProgramStudi.Name = "ProgramStudi";
            // 
            // NamaMItra
            // 
            NamaMItra.HeaderText = "Nama Mitra";
            NamaMItra.MinimumWidth = 8;
            NamaMItra.Name = "NamaMItra";
            // 
            // PosisiKegiatan
            // 
            PosisiKegiatan.HeaderText = "Program";
            PosisiKegiatan.MinimumWidth = 8;
            PosisiKegiatan.Name = "PosisiKegiatan";
            // 
            // SKS
            // 
            SKS.HeaderText = "SKS";
            SKS.MinimumWidth = 8;
            SKS.Name = "SKS";
            SKS.Resizable = DataGridViewTriState.True;
            // 
            // v_MemvalidasiKonversiSks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 562);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_daftarmahasiswa);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_MemvalidasiKonversiSks";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem penerimaanMitraToolStripMenuItem;
        private ToolStripMenuItem pembagianTugasToolStripMenuItem;
        private ToolStripMenuItem konversiSKSToolStripMenuItem;
        private ToolStripMenuItem konversiNIlaiToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private Label lbl_daftarmahasiswa;
        private DataGridView dataGridView1;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem daftarMitraToolStripMenuItem;
        private ToolStripMenuItem pengajuanMOAToolStripMenuItem;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn NIM;
        private DataGridViewTextBoxColumn ProgramStudi;
        private DataGridViewTextBoxColumn NamaMItra;
        private DataGridViewTextBoxColumn PosisiKegiatan;
        private DataGridViewButtonColumn SKS;
    }
}