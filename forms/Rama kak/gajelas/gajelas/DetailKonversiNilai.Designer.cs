namespace gajelas
{
    partial class DetailKonversiNilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailKonversiNilai));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penerimaanMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPengajuanMOAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembagianTugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konersiSksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiNilaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informasiAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_nim = new System.Windows.Forms.Label();
            this.lbl_prodi = new System.Windows.Forms.Label();
            this.lbl_mitra = new System.Windows.Forms.Label();
            this.lbl_posisi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbl_detailkonversinilai = new System.Windows.Forms.DataGridView();
            this.clm_Kompetensi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_nilai_capaian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_deskripsi_nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_buktilaporan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clm_validasi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detailkonversinilai)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berandaToolStripMenuItem,
            this.penerimaanMitraToolStripMenuItem,
            this.pembagianTugasToolStripMenuItem,
            this.konersiSksToolStripMenuItem,
            this.konversiNilaiToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(706, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // berandaToolStripMenuItem
            // 
            this.berandaToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berandaToolStripMenuItem.Name = "berandaToolStripMenuItem";
            this.berandaToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.berandaToolStripMenuItem.Text = "Dashboard";
            // 
            // penerimaanMitraToolStripMenuItem
            // 
            this.penerimaanMitraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarMitraToolStripMenuItem,
            this.statusPengajuanMOAToolStripMenuItem});
            this.penerimaanMitraToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penerimaanMitraToolStripMenuItem.Name = "penerimaanMitraToolStripMenuItem";
            this.penerimaanMitraToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.penerimaanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            this.penerimaanMitraToolStripMenuItem.Click += new System.EventHandler(this.penerimaanMitraToolStripMenuItem_Click);
            // 
            // daftarMitraToolStripMenuItem
            // 
            this.daftarMitraToolStripMenuItem.Name = "daftarMitraToolStripMenuItem";
            this.daftarMitraToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.daftarMitraToolStripMenuItem.Text = "Daftar Mitra";
            this.daftarMitraToolStripMenuItem.Click += new System.EventHandler(this.daftarMitraToolStripMenuItem_Click);
            // 
            // statusPengajuanMOAToolStripMenuItem
            // 
            this.statusPengajuanMOAToolStripMenuItem.Name = "statusPengajuanMOAToolStripMenuItem";
            this.statusPengajuanMOAToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.statusPengajuanMOAToolStripMenuItem.Text = "Status Pengajuan MOA";
            this.statusPengajuanMOAToolStripMenuItem.Click += new System.EventHandler(this.statusPengajuanMOAToolStripMenuItem_Click);
            // 
            // pembagianTugasToolStripMenuItem
            // 
            this.pembagianTugasToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pembagianTugasToolStripMenuItem.Name = "pembagianTugasToolStripMenuItem";
            this.pembagianTugasToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.pembagianTugasToolStripMenuItem.Text = "Pembagian Tugas";
            // 
            // konersiSksToolStripMenuItem
            // 
            this.konersiSksToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konersiSksToolStripMenuItem.Name = "konersiSksToolStripMenuItem";
            this.konersiSksToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.konersiSksToolStripMenuItem.Text = "Konersi sks";
            // 
            // konversiNilaiToolStripMenuItem
            // 
            this.konversiNilaiToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            this.konversiNilaiToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informasiAkunToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.profilToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(51, 26);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // informasiAkunToolStripMenuItem
            // 
            this.informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            this.informasiAkunToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            this.informasiAkunToolStripMenuItem.Click += new System.EventHandler(this.informasiAkunToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.6897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.3103F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nim, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_prodi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_mitra, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_posisi, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 117);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 5);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 5);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Program Studi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Mitra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Posisi Kegiatan";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(65, 0);
            this.lbl_nama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(57, 5);
            this.lbl_nama.TabIndex = 5;
            this.lbl_nama.Text = "Auryn Devi";
            this.lbl_nama.Visible = false;
            this.lbl_nama.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_nim
            // 
            this.lbl_nim.AutoSize = true;
            this.lbl_nim.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nim.Location = new System.Drawing.Point(65, 5);
            this.lbl_nim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nim.Name = "lbl_nim";
            this.lbl_nim.Size = new System.Drawing.Size(66, 5);
            this.lbl_nim.TabIndex = 6;
            this.lbl_nim.Text = "2224101010xx";
            // 
            // lbl_prodi
            // 
            this.lbl_prodi.AutoSize = true;
            this.lbl_prodi.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodi.Location = new System.Drawing.Point(65, 9);
            this.lbl_prodi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prodi.Name = "lbl_prodi";
            this.lbl_prodi.Size = new System.Drawing.Size(83, 15);
            this.lbl_prodi.TabIndex = 7;
            this.lbl_prodi.Text = "Sistem Informasi";
            // 
            // lbl_mitra
            // 
            this.lbl_mitra.AutoSize = true;
            this.lbl_mitra.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mitra.Location = new System.Drawing.Point(65, 32);
            this.lbl_mitra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mitra.Name = "lbl_mitra";
            this.lbl_mitra.Size = new System.Drawing.Size(97, 15);
            this.lbl_mitra.TabIndex = 8;
            this.lbl_mitra.Text = "Pt. Benakno Official";
            // 
            // lbl_posisi
            // 
            this.lbl_posisi.AutoSize = true;
            this.lbl_posisi.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_posisi.Location = new System.Drawing.Point(65, 55);
            this.lbl_posisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_posisi.Name = "lbl_posisi";
            this.lbl_posisi.Size = new System.Drawing.Size(20, 15);
            this.lbl_posisi.TabIndex = 9;
            this.lbl_posisi.Text = "PM";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tbl_detailkonversinilai);
            this.panel1.Location = new System.Drawing.Point(19, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 261);
            this.panel1.TabIndex = 3;
            // 
            // tbl_detailkonversinilai
            // 
            this.tbl_detailkonversinilai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_detailkonversinilai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_detailkonversinilai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tbl_detailkonversinilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_detailkonversinilai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Kompetensi,
            this.clm_nilai_capaian,
            this.clm_deskripsi_nilai,
            this.clm_buktilaporan,
            this.clm_validasi});
            this.tbl_detailkonversinilai.Location = new System.Drawing.Point(3, 3);
            this.tbl_detailkonversinilai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbl_detailkonversinilai.Name = "tbl_detailkonversinilai";
            this.tbl_detailkonversinilai.Size = new System.Drawing.Size(677, 254);
            this.tbl_detailkonversinilai.TabIndex = 0;
            // 
            // clm_Kompetensi
            // 
            this.clm_Kompetensi.FillWeight = 79.27198F;
            this.clm_Kompetensi.HeaderText = "Kompetensi";
            this.clm_Kompetensi.Name = "clm_Kompetensi";
            this.clm_Kompetensi.ReadOnly = true;
            // 
            // clm_nilai_capaian
            // 
            this.clm_nilai_capaian.FillWeight = 45.81083F;
            this.clm_nilai_capaian.HeaderText = "Nilai Capaian";
            this.clm_nilai_capaian.Name = "clm_nilai_capaian";
            this.clm_nilai_capaian.ReadOnly = true;
            // 
            // clm_deskripsi_nilai
            // 
            this.clm_deskripsi_nilai.FillWeight = 45.81083F;
            this.clm_deskripsi_nilai.HeaderText = "Deskripsi Nilai Capaian";
            this.clm_deskripsi_nilai.Name = "clm_deskripsi_nilai";
            this.clm_deskripsi_nilai.ReadOnly = true;
            // 
            // clm_buktilaporan
            // 
            this.clm_buktilaporan.FillWeight = 45.81083F;
            this.clm_buktilaporan.HeaderText = "Bukti Link Laporan";
            this.clm_buktilaporan.Name = "clm_buktilaporan";
            this.clm_buktilaporan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clm_validasi
            // 
            this.clm_validasi.FillWeight = 43.57201F;
            this.clm_validasi.HeaderText = "Validasi";
            this.clm_validasi.Name = "clm_validasi";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_simpan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(617, 443);
            this.btn_simpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(81, 29);
            this.btn_simpan.TabIndex = 4;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailKonversiNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 495);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailKonversiNilai";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detailkonversinilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem berandaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem penerimaanMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembagianTugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konersiSksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tbl_detailkonversinilai;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.ToolStripMenuItem daftarMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusPengajuanMOAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informasiAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Kompetensi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nilai_capaian;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_deskripsi_nilai;
        private System.Windows.Forms.DataGridViewButtonColumn clm_buktilaporan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clm_validasi;
        private System.Windows.Forms.Label lbl_prodi;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_nim;
        private System.Windows.Forms.Label lbl_mitra;
        private System.Windows.Forms.Label lbl_posisi;
    }
}