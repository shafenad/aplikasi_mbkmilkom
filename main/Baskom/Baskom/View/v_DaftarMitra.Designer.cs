namespace Baskom.View
{
    partial class v_DaftarMitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DaftarMitra));
            menuStrip1 = new MenuStrip();
            berandaToolStripMenuItem = new ToolStripMenuItem();
            penerimaanMitraToolStripMenuItem = new ToolStripMenuItem();
            daftarMitraToolStripMenuItem = new ToolStripMenuItem();
            mitraBaruToolStripMenuItem = new ToolStripMenuItem();
            pembagianTugasToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNilaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tbl_daftarmitra = new DataGridView();
            clm_mitra = new DataGridViewTextBoxColumn();
            clm_deskmitra = new DataGridViewTextBoxColumn();
            clm_bkp = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarmitra).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { berandaToolStripMenuItem, penerimaanMitraToolStripMenuItem, pembagianTugasToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNilaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(1403, 43);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // berandaToolStripMenuItem
            // 
            berandaToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            berandaToolStripMenuItem.Name = "berandaToolStripMenuItem";
            berandaToolStripMenuItem.Size = new Size(131, 35);
            berandaToolStripMenuItem.Text = "Dashboard";
            berandaToolStripMenuItem.Click += berandaToolStripMenuItem_Click;
            // 
            // penerimaanMitraToolStripMenuItem
            // 
            penerimaanMitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daftarMitraToolStripMenuItem, mitraBaruToolStripMenuItem });
            penerimaanMitraToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            penerimaanMitraToolStripMenuItem.Name = "penerimaanMitraToolStripMenuItem";
            penerimaanMitraToolStripMenuItem.Size = new Size(191, 35);
            penerimaanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            penerimaanMitraToolStripMenuItem.Click += penerimaanMitraToolStripMenuItem_Click;
            // 
            // daftarMitraToolStripMenuItem
            // 
            daftarMitraToolStripMenuItem.Name = "daftarMitraToolStripMenuItem";
            daftarMitraToolStripMenuItem.Size = new Size(234, 40);
            daftarMitraToolStripMenuItem.Text = "Daftar Mitra";
            daftarMitraToolStripMenuItem.Click += daftarMitraToolStripMenuItem_Click;
            // 
            // mitraBaruToolStripMenuItem
            // 
            mitraBaruToolStripMenuItem.Name = "mitraBaruToolStripMenuItem";
            mitraBaruToolStripMenuItem.Size = new Size(234, 40);
            mitraBaruToolStripMenuItem.Text = "Validasi MOA";
            mitraBaruToolStripMenuItem.Click += mitraBaruToolStripMenuItem_Click;
            // 
            // pembagianTugasToolStripMenuItem
            // 
            pembagianTugasToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pembagianTugasToolStripMenuItem.Name = "pembagianTugasToolStripMenuItem";
            pembagianTugasToolStripMenuItem.Size = new Size(194, 35);
            pembagianTugasToolStripMenuItem.Text = "Pembagian Tugas";
            pembagianTugasToolStripMenuItem.Click += pembagianTugasToolStripMenuItem_Click;
            // 
            // konversiSKSToolStripMenuItem
            // 
            konversiSKSToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            konversiSKSToolStripMenuItem.Size = new Size(144, 35);
            konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            konversiSKSToolStripMenuItem.Click += konversiSKSToolStripMenuItem_Click;
            // 
            // konversiNilaiToolStripMenuItem
            // 
            konversiNilaiToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            konversiNilaiToolStripMenuItem.Size = new Size(148, 35);
            konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            konversiNilaiToolStripMenuItem.Click += konversiNilaiToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(73, 35);
            profilToolStripMenuItem.Text = "Profil";
            profilToolStripMenuItem.Click += profilToolStripMenuItem_Click;
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(270, 40);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(270, 40);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.96907F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.030928F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbl_daftarmitra, 0, 1);
            tableLayoutPanel1.Location = new Point(20, 73);
            tableLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.25F));
            tableLayoutPanel1.Size = new Size(1365, 770);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 64);
            label1.TabIndex = 0;
            label1.Text = "Daftar Mitra";
            // 
            // tbl_daftarmitra
            // 
            tbl_daftarmitra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbl_daftarmitra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_daftarmitra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_daftarmitra.Columns.AddRange(new DataGridViewColumn[] { clm_mitra, clm_deskmitra, clm_bkp });
            tbl_daftarmitra.Location = new Point(5, 80);
            tbl_daftarmitra.Margin = new Padding(5, 5, 5, 5);
            tbl_daftarmitra.Name = "tbl_daftarmitra";
            tbl_daftarmitra.RowHeadersWidth = 82;
            tbl_daftarmitra.Size = new Size(1340, 683);
            tbl_daftarmitra.TabIndex = 1;
            tbl_daftarmitra.CellContentClick += tbl_daftarmitra_CellContentClick;
            // 
            // clm_mitra
            // 
            clm_mitra.HeaderText = "Nama Mitra";
            clm_mitra.MinimumWidth = 10;
            clm_mitra.Name = "clm_mitra";
            clm_mitra.ReadOnly = true;
            // 
            // clm_deskmitra
            // 
            clm_deskmitra.HeaderText = "Deskripsi";
            clm_deskmitra.MinimumWidth = 10;
            clm_deskmitra.Name = "clm_deskmitra";
            clm_deskmitra.ReadOnly = true;
            // 
            // clm_bkp
            // 
            clm_bkp.HeaderText = "BKP";
            clm_bkp.MinimumWidth = 10;
            clm_bkp.Name = "clm_bkp";
            clm_bkp.ReadOnly = true;
            // 
            // v_DaftarMitra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 820);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 5, 5, 5);
            Name = "v_DaftarMitra";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarmitra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem berandaToolStripMenuItem;
        private ToolStripMenuItem penerimaanMitraToolStripMenuItem;
        private ToolStripMenuItem pembagianTugasToolStripMenuItem;
        private ToolStripMenuItem konversiSKSToolStripMenuItem;
        private ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView tbl_daftarmitra;
        private DataGridViewTextBoxColumn clm_mitra;
        private DataGridViewTextBoxColumn clm_deskmitra;
        private DataGridViewTextBoxColumn clm_bkp;
        private ToolStripMenuItem daftarMitraToolStripMenuItem;
        private ToolStripMenuItem mitraBaruToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}