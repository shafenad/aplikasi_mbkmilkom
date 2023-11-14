namespace PBOOO
{
    partial class MataKuliah
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MataKuliah));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengajuanMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMOAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mataKuliahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiSKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiNilaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informasiAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnl_matakuliahkiri = new System.Windows.Forms.Panel();
            this.cbx_matkulygtlhditmph = new System.Windows.Forms.ComboBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.lbl_matkulygtlhditmph = new System.Windows.Forms.Label();
            this.pnl_matakuliahkanan = new System.Windows.Forms.Panel();
            this.tbl_matkul = new System.Windows.Forms.DataGridView();
            this.lbl_daftarmatkul = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.pnl_matakuliahkiri.SuspendLayout();
            this.pnl_matakuliahkanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_matkul)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.mitraToolStripMenuItem,
            this.mataKuliahToolStripMenuItem,
            this.konversiSKSToolStripMenuItem,
            this.konversiNilaiToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 45);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // mitraToolStripMenuItem
            // 
            this.mitraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pengajuanMitraToolStripMenuItem,
            this.statusMOAToolStripMenuItem});
            this.mitraToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            this.mitraToolStripMenuItem.Size = new System.Drawing.Size(76, 45);
            this.mitraToolStripMenuItem.Text = "Mitra";
            // 
            // pengajuanMitraToolStripMenuItem
            // 
            this.pengajuanMitraToolStripMenuItem.Name = "pengajuanMitraToolStripMenuItem";
            this.pengajuanMitraToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.pengajuanMitraToolStripMenuItem.Text = "Pengajuan Mitra";
            // 
            // statusMOAToolStripMenuItem
            // 
            this.statusMOAToolStripMenuItem.Name = "statusMOAToolStripMenuItem";
            this.statusMOAToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.statusMOAToolStripMenuItem.Text = "Status MOA";
            // 
            // mataKuliahToolStripMenuItem
            // 
            this.mataKuliahToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            this.mataKuliahToolStripMenuItem.Size = new System.Drawing.Size(137, 45);
            this.mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            // 
            // konversiSKSToolStripMenuItem
            // 
            this.konversiSKSToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            this.konversiSKSToolStripMenuItem.Size = new System.Drawing.Size(144, 45);
            this.konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            this.konversiSKSToolStripMenuItem.Click += new System.EventHandler(this.konversiSKSToolStripMenuItem_Click);
            // 
            // konversiNilaiToolStripMenuItem
            // 
            this.konversiNilaiToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            this.konversiNilaiToolStripMenuItem.Size = new System.Drawing.Size(148, 45);
            this.konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informasiAkunToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.profilToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(73, 45);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // informasiAkunToolStripMenuItem
            // 
            this.informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            this.informasiAkunToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnl_matakuliahkiri
            // 
            this.pnl_matakuliahkiri.Controls.Add(this.cbx_matkulygtlhditmph);
            this.pnl_matakuliahkiri.Controls.Add(this.btn_tambah);
            this.pnl_matakuliahkiri.Controls.Add(this.lbl_matkulygtlhditmph);
            this.pnl_matakuliahkiri.Location = new System.Drawing.Point(0, 44);
            this.pnl_matakuliahkiri.Name = "pnl_matakuliahkiri";
            this.pnl_matakuliahkiri.Size = new System.Drawing.Size(568, 595);
            this.pnl_matakuliahkiri.TabIndex = 2;
            // 
            // cbx_matkulygtlhditmph
            // 
            this.cbx_matkulygtlhditmph.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_matkulygtlhditmph.FormattingEnabled = true;
            this.cbx_matkulygtlhditmph.Location = new System.Drawing.Point(30, 69);
            this.cbx_matkulygtlhditmph.Name = "cbx_matkulygtlhditmph";
            this.cbx_matkulygtlhditmph.Size = new System.Drawing.Size(458, 39);
            this.cbx_matkulygtlhditmph.TabIndex = 3;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(30, 133);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(141, 42);
            this.btn_tambah.TabIndex = 2;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            // 
            // lbl_matkulygtlhditmph
            // 
            this.lbl_matkulygtlhditmph.AutoSize = true;
            this.lbl_matkulygtlhditmph.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matkulygtlhditmph.Location = new System.Drawing.Point(23, 29);
            this.lbl_matkulygtlhditmph.Name = "lbl_matkulygtlhditmph";
            this.lbl_matkulygtlhditmph.Size = new System.Drawing.Size(360, 36);
            this.lbl_matkulygtlhditmph.TabIndex = 0;
            this.lbl_matkulygtlhditmph.Text = "Mata kuliah yang telah ditempuh";
            this.lbl_matkulygtlhditmph.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_matakuliahkanan
            // 
            this.pnl_matakuliahkanan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_matakuliahkanan.Controls.Add(this.tbl_matkul);
            this.pnl_matakuliahkanan.Controls.Add(this.lbl_daftarmatkul);
            this.pnl_matakuliahkanan.Location = new System.Drawing.Point(569, 43);
            this.pnl_matakuliahkanan.Name = "pnl_matakuliahkanan";
            this.pnl_matakuliahkanan.Size = new System.Drawing.Size(568, 595);
            this.pnl_matakuliahkanan.TabIndex = 3;
            // 
            // tbl_matkul
            // 
            this.tbl_matkul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_matkul.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_matkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_matkul.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.tbl_matkul.Location = new System.Drawing.Point(69, 70);
            this.tbl_matkul.Name = "tbl_matkul";
            this.tbl_matkul.RowHeadersWidth = 82;
            this.tbl_matkul.RowTemplate.Height = 33;
            this.tbl_matkul.Size = new System.Drawing.Size(457, 441);
            this.tbl_matkul.TabIndex = 1;
            // 
            // lbl_daftarmatkul
            // 
            this.lbl_daftarmatkul.AutoSize = true;
            this.lbl_daftarmatkul.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daftarmatkul.Location = new System.Drawing.Point(62, 30);
            this.lbl_daftarmatkul.Name = "lbl_daftarmatkul";
            this.lbl_daftarmatkul.Size = new System.Drawing.Size(209, 36);
            this.lbl_daftarmatkul.TabIndex = 0;
            this.lbl_daftarmatkul.Text = "Daftar Mata Kuliah";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tahun Kurikulum";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kode Mata Kuliah";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nama Mata Kuliah";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jumlah SKS";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SKS Tatap Muka";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "SKS Praktikum";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // MataKuliah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 637);
            this.Controls.Add(this.pnl_matakuliahkanan);
            this.Controls.Add(this.pnl_matakuliahkiri);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Poppins", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MataKuliah";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_matakuliahkiri.ResumeLayout(false);
            this.pnl_matakuliahkiri.PerformLayout();
            this.pnl_matakuliahkanan.ResumeLayout(false);
            this.pnl_matakuliahkanan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_matkul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mataKuliahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiSKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnl_matakuliahkiri;
        private System.Windows.Forms.Label lbl_matkulygtlhditmph;
        private System.Windows.Forms.Panel pnl_matakuliahkanan;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.ComboBox cbx_matkulygtlhditmph;
        private System.Windows.Forms.DataGridView tbl_matkul;
        private System.Windows.Forms.Label lbl_daftarmatkul;
        private System.Windows.Forms.ToolStripMenuItem informasiAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengajuanMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusMOAToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}