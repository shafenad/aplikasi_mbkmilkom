namespace Baskom.View
{
    partial class DaftarMitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaftarMitra));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penerimaanMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitraBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembagianTugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiSKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiNilaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informasiAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_daftarmitra = new System.Windows.Forms.DataGridView();
            this.clm_mitra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_deskmitra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_bkp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_daftarmitra)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(842, 30);
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
            this.mitraBaruToolStripMenuItem});
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
            // mitraBaruToolStripMenuItem
            // 
            this.mitraBaruToolStripMenuItem.Name = "mitraBaruToolStripMenuItem";
            this.mitraBaruToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.mitraBaruToolStripMenuItem.Text = "Status Pengajuan MOA";
            this.mitraBaruToolStripMenuItem.Click += new System.EventHandler(this.mitraBaruToolStripMenuItem_Click);
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
            this.informasiAkunToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            this.informasiAkunToolStripMenuItem.Click += new System.EventHandler(this.informasiAkunToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.96907F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.030928F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbl_daftarmitra, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 400);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Mitra";
            // 
            // tbl_daftarmitra
            // 
            this.tbl_daftarmitra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_daftarmitra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_daftarmitra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_daftarmitra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_mitra,
            this.clm_deskmitra,
            this.clm_bkp});
            this.tbl_daftarmitra.Location = new System.Drawing.Point(3, 42);
            this.tbl_daftarmitra.Name = "tbl_daftarmitra";
            this.tbl_daftarmitra.Size = new System.Drawing.Size(804, 355);
            this.tbl_daftarmitra.TabIndex = 1;
            // 
            // clm_mitra
            // 
            this.clm_mitra.HeaderText = "Nama Mitra";
            this.clm_mitra.Name = "clm_mitra";
            this.clm_mitra.ReadOnly = true;
            // 
            // clm_deskmitra
            // 
            this.clm_deskmitra.HeaderText = "Deskripsi";
            this.clm_deskmitra.Name = "clm_deskmitra";
            this.clm_deskmitra.ReadOnly = true;
            // 
            // clm_bkp
            // 
            this.clm_bkp.HeaderText = "BKP";
            this.clm_bkp.Name = "clm_bkp";
            this.clm_bkp.ReadOnly = true;
            // 
            // DaftarMitra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DaftarMitra";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_daftarmitra)).EndInit();
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
        private System.Windows.Forms.DataGridView tbl_daftarmitra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_mitra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_deskmitra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_bkp;
        private System.Windows.Forms.ToolStripMenuItem daftarMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitraBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informasiAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}