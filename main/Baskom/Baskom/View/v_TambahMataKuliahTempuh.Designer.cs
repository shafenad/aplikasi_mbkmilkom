namespace Baskom.View
{
    partial class v_TambahMataKuliahTempuh
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_TambahMataKuliahTempuh));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            pengajuanMitraToolStripMenuItem = new ToolStripMenuItem();
            statusMOAToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNilaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnl_matakuliahkiri = new Panel();
            cbx_matkulygtlhditmph = new ComboBox();
            btn_tambah = new Button();
            lbl_matkulygtlhditmph = new Label();
            pnl_matakuliahkanan = new Panel();
            tbl_matkul = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            lbl_daftarmatkul = new Label();
            menuStrip1.SuspendLayout();
            pnl_matakuliahkiri.SuspendLayout();
            pnl_matakuliahkanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_matkul).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNilaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1137, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(151, 33);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pengajuanMitraToolStripMenuItem, statusMOAToolStripMenuItem });
            mitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(86, 33);
            mitraToolStripMenuItem.Text = "Mitra";
            // 
            // pengajuanMitraToolStripMenuItem
            // 
            pengajuanMitraToolStripMenuItem.Name = "pengajuanMitraToolStripMenuItem";
            pengajuanMitraToolStripMenuItem.Size = new Size(319, 44);
            pengajuanMitraToolStripMenuItem.Text = "Pengajuan Mitra";
            pengajuanMitraToolStripMenuItem.Click += pengajuanMitraToolStripMenuItem_Click;
            // 
            // statusMOAToolStripMenuItem
            // 
            statusMOAToolStripMenuItem.Name = "statusMOAToolStripMenuItem";
            statusMOAToolStripMenuItem.Size = new Size(319, 44);
            statusMOAToolStripMenuItem.Text = "Status MOA";
            statusMOAToolStripMenuItem.Click += statusMOAToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(158, 33);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
            // 
            // konversiSKSToolStripMenuItem
            // 
            konversiSKSToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            konversiSKSToolStripMenuItem.Size = new Size(181, 33);
            konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            konversiSKSToolStripMenuItem.Click += konversiSKSToolStripMenuItem_Click;
            // 
            // konversiNilaiToolStripMenuItem
            // 
            konversiNilaiToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            konversiNilaiToolStripMenuItem.Size = new Size(182, 33);
            konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            konversiNilaiToolStripMenuItem.Click += konversiNilaiToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(89, 33);
            profilToolStripMenuItem.Text = "Profil";
            profilToolStripMenuItem.Click += profilToolStripMenuItem_Click;
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(302, 44);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(302, 44);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnl_matakuliahkiri
            // 
            pnl_matakuliahkiri.Controls.Add(cbx_matkulygtlhditmph);
            pnl_matakuliahkiri.Controls.Add(btn_tambah);
            pnl_matakuliahkiri.Controls.Add(lbl_matkulygtlhditmph);
            pnl_matakuliahkiri.Location = new Point(0, 44);
            pnl_matakuliahkiri.Name = "pnl_matakuliahkiri";
            pnl_matakuliahkiri.Size = new Size(568, 595);
            pnl_matakuliahkiri.TabIndex = 2;
            // 
            // cbx_matkulygtlhditmph
            // 
            cbx_matkulygtlhditmph.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_matkulygtlhditmph.FormattingEnabled = true;
            cbx_matkulygtlhditmph.Location = new Point(30, 69);
            cbx_matkulygtlhditmph.Name = "cbx_matkulygtlhditmph";
            cbx_matkulygtlhditmph.Size = new Size(458, 37);
            cbx_matkulygtlhditmph.TabIndex = 3;
            // 
            // btn_tambah
            // 
            btn_tambah.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_tambah.Location = new Point(30, 133);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(141, 42);
            btn_tambah.TabIndex = 2;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = true;
            btn_tambah.Click += btn_tambah_Click;
            // 
            // lbl_matkulygtlhditmph
            // 
            lbl_matkulygtlhditmph.AutoSize = true;
            lbl_matkulygtlhditmph.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_matkulygtlhditmph.Location = new Point(23, 29);
            lbl_matkulygtlhditmph.Name = "lbl_matkulygtlhditmph";
            lbl_matkulygtlhditmph.Size = new Size(433, 31);
            lbl_matkulygtlhditmph.TabIndex = 0;
            lbl_matkulygtlhditmph.Text = "Mata kuliah yang telah ditempuh";
            lbl_matkulygtlhditmph.Click += label1_Click;
            // 
            // pnl_matakuliahkanan
            // 
            pnl_matakuliahkanan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_matakuliahkanan.Controls.Add(tbl_matkul);
            pnl_matakuliahkanan.Controls.Add(lbl_daftarmatkul);
            pnl_matakuliahkanan.Location = new Point(569, 43);
            pnl_matakuliahkanan.Name = "pnl_matakuliahkanan";
            pnl_matakuliahkanan.Size = new Size(568, 595);
            pnl_matakuliahkanan.TabIndex = 3;
            // 
            // tbl_matkul
            // 
            tbl_matkul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_matkul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_matkul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_matkul.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            tbl_matkul.Location = new Point(69, 70);
            tbl_matkul.Name = "tbl_matkul";
            tbl_matkul.RowHeadersWidth = 82;
            tbl_matkul.RowTemplate.Height = 33;
            tbl_matkul.Size = new Size(457, 441);
            tbl_matkul.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kode";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tahun Kurikulum";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Kode Mata Kuliah";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Nama Mata Kuliah";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Jumlah SKS";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "SKS Tatap Muka";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "SKS Praktikum";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // lbl_daftarmatkul
            // 
            lbl_daftarmatkul.AutoSize = true;
            lbl_daftarmatkul.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_daftarmatkul.Location = new Point(62, 30);
            lbl_daftarmatkul.Name = "lbl_daftarmatkul";
            lbl_daftarmatkul.Size = new Size(256, 31);
            lbl_daftarmatkul.TabIndex = 0;
            lbl_daftarmatkul.Text = "Daftar Mata Kuliah";
            // 
            // v_TambahMataKuliahTempuh
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 637);
            Controls.Add(pnl_matakuliahkanan);
            Controls.Add(pnl_matakuliahkiri);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_TambahMataKuliahTempuh";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnl_matakuliahkiri.ResumeLayout(false);
            pnl_matakuliahkiri.PerformLayout();
            pnl_matakuliahkanan.ResumeLayout(false);
            pnl_matakuliahkanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_matkul).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem konversiSKSToolStripMenuItem;
        private ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Panel pnl_matakuliahkiri;
        private Label lbl_matkulygtlhditmph;
        private Panel pnl_matakuliahkanan;
        private Button btn_tambah;
        private ComboBox cbx_matkulygtlhditmph;
        private DataGridView tbl_matkul;
        private Label lbl_daftarmatkul;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem pengajuanMitraToolStripMenuItem;
        private ToolStripMenuItem statusMOAToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}