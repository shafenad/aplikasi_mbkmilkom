namespace PBO
{
    partial class ProfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilAdmin));
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
            menuStrip2 = new MenuStrip();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            manajemenAkunToolStripMenuItem = new ToolStripMenuItem();
            akunToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip2.SuspendLayout();
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
            lbl_namaakunadmin.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_namaakunadmin.Location = new Point(120, 107);
            lbl_namaakunadmin.Name = "lbl_namaakunadmin";
            lbl_namaakunadmin.Size = new Size(94, 36);
            lbl_namaakunadmin.TabIndex = 12;
            lbl_namaakunadmin.Text = "Nama : ";
            // 
            // lbl_katasandi
            // 
            lbl_katasandi.AutoSize = true;
            lbl_katasandi.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_katasandi.Location = new Point(120, 230);
            lbl_katasandi.Name = "lbl_katasandi";
            lbl_katasandi.Size = new Size(54, 31);
            lbl_katasandi.TabIndex = 11;
            lbl_katasandi.Text = "..........";
            // 
            // lbl_akunadmin
            // 
            lbl_akunadmin.AutoSize = true;
            lbl_akunadmin.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_akunadmin.Location = new Point(120, 13);
            lbl_akunadmin.Name = "lbl_akunadmin";
            lbl_akunadmin.Size = new Size(256, 64);
            lbl_akunadmin.TabIndex = 0;
            lbl_akunadmin.Text = "Akun Admin";
            lbl_akunadmin.Click += label1_Click;
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nama.Location = new Point(120, 154);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(141, 31);
            lbl_nama.TabIndex = 10;
            lbl_nama.Text = "NADILIA S.KOM";
            // 
            // lnk_ubahkatasandi
            // 
            lnk_ubahkatasandi.AutoSize = true;
            lnk_ubahkatasandi.Font = new Font("Poppins", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lnk_ubahkatasandi.Location = new Point(120, 272);
            lnk_ubahkatasandi.Name = "lnk_ubahkatasandi";
            lnk_ubahkatasandi.Size = new Size(125, 25);
            lnk_ubahkatasandi.TabIndex = 5;
            lnk_ubahkatasandi.TabStop = true;
            lnk_ubahkatasandi.Text = "Ubah Kata Sandi";
            lnk_ubahkatasandi.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lbl_katasandi1
            // 
            lbl_katasandi1.AutoSize = true;
            lbl_katasandi1.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandi1.Location = new Point(120, 194);
            lbl_katasandi1.Name = "lbl_katasandi1";
            lbl_katasandi1.Size = new Size(138, 36);
            lbl_katasandi1.TabIndex = 3;
            lbl_katasandi1.Text = "Kata Sandi :";
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
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, manajemenAkunToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, profilToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 39);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new Size(131, 35);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // manajemenAkunToolStripMenuItem
            // 
            manajemenAkunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { akunToolStripMenuItem, akunMahasiswaToolStripMenuItem });
            manajemenAkunToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            manajemenAkunToolStripMenuItem.Name = "manajemenAkunToolStripMenuItem";
            manajemenAkunToolStripMenuItem.Size = new Size(189, 35);
            manajemenAkunToolStripMenuItem.Text = "Manajemen Akun";
            // 
            // akunToolStripMenuItem
            // 
            akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            akunToolStripMenuItem.Size = new Size(269, 40);
            akunToolStripMenuItem.Text = "Akun Dosen";
            // 
            // akunMahasiswaToolStripMenuItem
            // 
            akunMahasiswaToolStripMenuItem.Name = "akunMahasiswaToolStripMenuItem";
            akunMahasiswaToolStripMenuItem.Size = new Size(269, 40);
            akunMahasiswaToolStripMenuItem.Text = "Akun Mahasiswa";
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tambahToolStripMenuItem, tambahProgramMataKuliahToolStripMenuItem });
            mitraToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(76, 35);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click_1;
            // 
            // tambahToolStripMenuItem
            // 
            tambahToolStripMenuItem.Name = "tambahToolStripMenuItem";
            tambahToolStripMenuItem.Size = new Size(391, 40);
            tambahToolStripMenuItem.Text = "Tambah Mitra Program";
            tambahToolStripMenuItem.Click += tambahToolStripMenuItem_Click;
            // 
            // tambahProgramMataKuliahToolStripMenuItem
            // 
            tambahProgramMataKuliahToolStripMenuItem.Name = "tambahProgramMataKuliahToolStripMenuItem";
            tambahProgramMataKuliahToolStripMenuItem.Size = new Size(391, 40);
            tambahProgramMataKuliahToolStripMenuItem.Text = "Tambah Program Mata Kuliah";
            tambahProgramMataKuliahToolStripMenuItem.Click += tambahProgramMataKuliahToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(137, 35);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(73, 35);
            profilToolStripMenuItem.Text = "Profil";
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
            // 
            // ProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(menuStrip2);
            Controls.Add(lyt_akunadmin);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProfilAdmin";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            lyt_akunadmin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
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
        private Label lbl_katasandi;
        private Label lbl_nama;
        private Label lbl_namaakunadmin;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem manajemenAkunToolStripMenuItem;
        private ToolStripMenuItem akunToolStripMenuItem;
        private ToolStripMenuItem akunMahasiswaToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem tambahToolStripMenuItem;
        private ToolStripMenuItem tambahProgramMataKuliahToolStripMenuItem;
    }
}