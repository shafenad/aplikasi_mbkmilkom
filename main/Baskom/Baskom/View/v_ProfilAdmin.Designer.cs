﻿namespace Baskom.View
{
    partial class v_ProfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_ProfilAdmin));
            lyt_akunadmin = new TableLayoutPanel();
            panel2 = new Panel();
            lbl_namaakunadmin = new Label();
            lbl_katasandi = new Label();
            lbl_akunadmin = new Label();
            lbl_nama = new Label();
            lnk_ubahkatasandi = new LinkLabel();
            lbl_katasandi1 = new Label();
            panel1 = new Panel();
            pic_logo = new PictureBox();
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            manajemenAkunToolStripMenuItem = new ToolStripMenuItem();
            akunDosenToolStripMenuItem = new ToolStripMenuItem();
            akunMahasiswaToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            tambahToolStripMenuItem = new ToolStripMenuItem();
            tambahProgramMataKuliahToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            lyt_akunadmin.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lyt_akunadmin
            // 
            lyt_akunadmin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lyt_akunadmin.ColumnCount = 2;
            lyt_akunadmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_akunadmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_akunadmin.Controls.Add(panel2, 0, 0);
            lyt_akunadmin.Controls.Add(panel1, 1, 0);
            lyt_akunadmin.Location = new Point(12, 132);
            lyt_akunadmin.Margin = new Padding(3, 4, 3, 4);
            lyt_akunadmin.Name = "lyt_akunadmin";
            lyt_akunadmin.RowCount = 1;
            lyt_akunadmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lyt_akunadmin.Size = new Size(776, 490);
            lyt_akunadmin.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(lbl_namaakunadmin);
            panel2.Controls.Add(lbl_katasandi);
            panel2.Controls.Add(lbl_akunadmin);
            panel2.Controls.Add(lbl_nama);
            panel2.Controls.Add(lnk_ubahkatasandi);
            panel2.Controls.Add(lbl_katasandi1);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 482);
            panel2.TabIndex = 1;
            // 
            // lbl_namaakunadmin
            // 
            lbl_namaakunadmin.AutoSize = true;
            lbl_namaakunadmin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_namaakunadmin.Location = new Point(120, 107);
            lbl_namaakunadmin.Name = "lbl_namaakunadmin";
            lbl_namaakunadmin.Size = new Size(115, 31);
            lbl_namaakunadmin.TabIndex = 12;
            lbl_namaakunadmin.Text = "Nama : ";
            // 
            // lbl_katasandi
            // 
            lbl_katasandi.AutoSize = true;
            lbl_katasandi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_katasandi.Location = new Point(120, 230);
            lbl_katasandi.Name = "lbl_katasandi";
            lbl_katasandi.Size = new Size(219, 29);
            lbl_katasandi.TabIndex = 11;
            lbl_katasandi.Text = "nadilia@gmail.com";
            // 
            // lbl_akunadmin
            // 
            lbl_akunadmin.AutoSize = true;
            lbl_akunadmin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_akunadmin.Location = new Point(120, 13);
            lbl_akunadmin.Name = "lbl_akunadmin";
            lbl_akunadmin.Size = new Size(293, 55);
            lbl_akunadmin.TabIndex = 0;
            lbl_akunadmin.Text = "Akun Admin";
            lbl_akunadmin.Click += label1_Click;
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nama.Location = new Point(120, 154);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(186, 29);
            lbl_nama.TabIndex = 10;
            lbl_nama.Text = "NADILIA S.KOM";
            // 
            // lnk_ubahkatasandi
            // 
            lnk_ubahkatasandi.AutoSize = true;
            lnk_ubahkatasandi.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lnk_ubahkatasandi.Location = new Point(120, 272);
            lnk_ubahkatasandi.Name = "lnk_ubahkatasandi";
            lnk_ubahkatasandi.Size = new Size(149, 24);
            lnk_ubahkatasandi.TabIndex = 5;
            lnk_ubahkatasandi.TabStop = true;
            lnk_ubahkatasandi.Text = "Ubah Kata Sandi";
            lnk_ubahkatasandi.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lbl_katasandi1
            // 
            lbl_katasandi1.AutoSize = true;
            lbl_katasandi1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandi1.Location = new Point(120, 194);
            lbl_katasandi1.Name = "lbl_katasandi1";
            lbl_katasandi1.Size = new Size(103, 31);
            lbl_katasandi1.TabIndex = 3;
            lbl_katasandi1.Text = "Email :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pic_logo);
            panel1.Location = new Point(391, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 272);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pic_logo
            // 
            pic_logo.Dock = DockStyle.Fill;
            pic_logo.Image = (Image)resources.GetObject("pic_logo.Image");
            pic_logo.Location = new Point(0, 0);
            pic_logo.Margin = new Padding(3, 4, 3, 4);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(382, 272);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 1;
            pic_logo.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, manajemenAkunToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(151, 38);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // manajemenAkunToolStripMenuItem
            // 
            manajemenAkunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { akunDosenToolStripMenuItem, akunMahasiswaToolStripMenuItem });
            manajemenAkunToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            manajemenAkunToolStripMenuItem.Name = "manajemenAkunToolStripMenuItem";
            manajemenAkunToolStripMenuItem.Size = new Size(218, 38);
            manajemenAkunToolStripMenuItem.Text = "Manajemen Akun";
            // 
            // akunDosenToolStripMenuItem
            // 
            akunDosenToolStripMenuItem.Name = "akunDosenToolStripMenuItem";
            akunDosenToolStripMenuItem.Size = new Size(324, 44);
            akunDosenToolStripMenuItem.Text = "Akun Dosen";
            akunDosenToolStripMenuItem.Click += akunDosenToolStripMenuItem_Click;
            // 
            // akunMahasiswaToolStripMenuItem
            // 
            akunMahasiswaToolStripMenuItem.Name = "akunMahasiswaToolStripMenuItem";
            akunMahasiswaToolStripMenuItem.Size = new Size(324, 44);
            akunMahasiswaToolStripMenuItem.Text = "Akun Mahasiswa";
            akunMahasiswaToolStripMenuItem.Click += akunMahasiswaToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tambahToolStripMenuItem, tambahProgramMataKuliahToolStripMenuItem });
            mitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(86, 38);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click;
            // 
            // tambahToolStripMenuItem
            // 
            tambahToolStripMenuItem.Name = "tambahToolStripMenuItem";
            tambahToolStripMenuItem.Size = new Size(464, 44);
            tambahToolStripMenuItem.Text = "Tambah Mitra Program";
            tambahToolStripMenuItem.Click += tambahToolStripMenuItem_Click;
            // 
            // tambahProgramMataKuliahToolStripMenuItem
            // 
            tambahProgramMataKuliahToolStripMenuItem.Name = "tambahProgramMataKuliahToolStripMenuItem";
            tambahProgramMataKuliahToolStripMenuItem.Size = new Size(464, 44);
            tambahProgramMataKuliahToolStripMenuItem.Text = "Tambah Program Mata Kuliah";
            tambahProgramMataKuliahToolStripMenuItem.Click += tambahProgramMataKuliahToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(161, 38);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(89, 38);
            profilToolStripMenuItem.Text = "Profil";
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
            // v_ProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(lyt_akunadmin);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_ProfilAdmin";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            lyt_akunadmin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel lyt_akunadmin;
        private Panel panel2;
        private Label lbl_akunadmin;
        private LinkLabel lnk_ubahkatasandi;
        private Label lbl_katasandi1;
        private Panel panel1;
        private PictureBox pic_logo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem manajemenAkunToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private Label lbl_katasandi;
        private Label lbl_nama;
        private Label lbl_namaakunadmin;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem akunDosenToolStripMenuItem;
        private ToolStripMenuItem akunMahasiswaToolStripMenuItem;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem tambahToolStripMenuItem;
        private ToolStripMenuItem tambahProgramMataKuliahToolStripMenuItem;
    }
}