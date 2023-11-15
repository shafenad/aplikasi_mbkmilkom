namespace gajelas
{
    partial class PengajuanMOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PengajuanMOA));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penerimaanMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPengajuanMOAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembagianTugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiSKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiNilaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_statuspengajuanmoa = new System.Windows.Forms.DataGridView();
            this.clm_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_mitra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_deskripsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_statuspengajuanmoa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berandaToolStripMenuItem,
            this.penerimaanMitraToolStripMenuItem,
            this.pembagianTugasToolStripMenuItem,
            this.konversiSKSToolStripMenuItem,
            this.konversiNilaiToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 30);
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
            // 
            // pembagianTugasToolStripMenuItem
            // 
            this.pembagianTugasToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pembagianTugasToolStripMenuItem.Name = "pembagianTugasToolStripMenuItem";
            this.pembagianTugasToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.pembagianTugasToolStripMenuItem.Text = "Pembagian Tugas";
            // 
            // konversiSKSToolStripMenuItem
            // 
            this.konversiSKSToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            this.konversiSKSToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            // 
            // konversiNilaiToolStripMenuItem
            // 
            this.konversiNilaiToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            this.konversiNilaiToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            this.konversiNilaiToolStripMenuItem.Click += new System.EventHandler(this.konversiNilaiToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatProfilToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.profilToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(51, 26);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // lihatProfilToolStripMenuItem
            // 
            this.lihatProfilToolStripMenuItem.Name = "lihatProfilToolStripMenuItem";
            this.lihatProfilToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.lihatProfilToolStripMenuItem.Text = "Informasi Akun";
            this.lihatProfilToolStripMenuItem.Click += new System.EventHandler(this.lihatProfilToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.96907F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.030928F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbl_statuspengajuanmoa, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.84971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.15029F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 346);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Mitra";
            // 
            // tbl_statuspengajuanmoa
            // 
            this.tbl_statuspengajuanmoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_statuspengajuanmoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_statuspengajuanmoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_statuspengajuanmoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_nama,
            this.clm_mitra,
            this.clm_deskripsi,
            this.clm_status});
            this.tbl_statuspengajuanmoa.Location = new System.Drawing.Point(3, 44);
            this.tbl_statuspengajuanmoa.Name = "tbl_statuspengajuanmoa";
            this.tbl_statuspengajuanmoa.Size = new System.Drawing.Size(663, 299);
            this.tbl_statuspengajuanmoa.TabIndex = 1;
            this.tbl_statuspengajuanmoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clm_nama
            // 
            this.clm_nama.HeaderText = "Nama";
            this.clm_nama.Name = "clm_nama";
            this.clm_nama.ReadOnly = true;
            // 
            // clm_mitra
            // 
            this.clm_mitra.HeaderText = "Mitra";
            this.clm_mitra.Name = "clm_mitra";
            this.clm_mitra.ReadOnly = true;
            // 
            // clm_deskripsi
            // 
            this.clm_deskripsi.HeaderText = "Deskripsi";
            this.clm_deskripsi.Name = "clm_deskripsi";
            this.clm_deskripsi.ReadOnly = true;
            // 
            // clm_status
            // 
            this.clm_status.HeaderText = "Status Pengajuan MOA";
            this.clm_status.Name = "clm_status";
            this.clm_status.ReadOnly = true;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_simpan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_simpan.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(581, 387);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(97, 23);
            this.btn_simpan.TabIndex = 2;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // PengajuanMOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PengajuanMOA";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_statuspengajuanmoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem berandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penerimaanMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembagianTugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiSKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbl_statuspengajuanmoa;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_mitra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_deskripsi;
        private System.Windows.Forms.DataGridViewComboBoxColumn clm_status;
        private System.Windows.Forms.ToolStripMenuItem daftarMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusPengajuanMOAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}