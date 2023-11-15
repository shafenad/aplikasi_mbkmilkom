﻿namespace PBO
{
    partial class Mitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitra));
            lyt_mitra = new TableLayoutPanel();
            panel1 = new Panel();
            btn_simpan = new Button();
            cbx_matakuliah = new ComboBox();
            lbl_matakuliah = new Label();
            cbx_program = new ComboBox();
            lbl_program = new Label();
            cbx_namamitra = new ComboBox();
            lbl_namamitra = new Label();
            panel2 = new Panel();
            tbl_daftarprogrammitra = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            lbl_daftarprogrammitra = new Label();
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            manajemenAkunToolStripMenuItem = new ToolStripMenuItem();
            akunDosenToolStripMenuItem = new ToolStripMenuItem();
            akunMahasiswaToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            lyt_mitra.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarprogrammitra).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lyt_mitra
            // 
            lyt_mitra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lyt_mitra.ColumnCount = 2;
            lyt_mitra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_mitra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_mitra.Controls.Add(panel1, 0, 0);
            lyt_mitra.Controls.Add(panel2, 1, 0);
            lyt_mitra.Location = new Point(12, 73);
            lyt_mitra.Name = "lyt_mitra";
            lyt_mitra.RowCount = 1;
            lyt_mitra.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lyt_mitra.Size = new Size(776, 459);
            lyt_mitra.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btn_simpan);
            panel1.Controls.Add(cbx_matakuliah);
            panel1.Controls.Add(lbl_matakuliah);
            panel1.Controls.Add(cbx_program);
            panel1.Controls.Add(lbl_program);
            panel1.Controls.Add(cbx_namamitra);
            panel1.Controls.Add(lbl_namamitra);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 453);
            panel1.TabIndex = 0;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = SystemColors.MenuHighlight;
            btn_simpan.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(5, 315);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(105, 38);
            btn_simpan.TabIndex = 6;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            // 
            // cbx_matakuliah
            // 
            cbx_matakuliah.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbx_matakuliah.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_matakuliah.FormattingEnabled = true;
            cbx_matakuliah.Location = new Point(3, 253);
            cbx_matakuliah.Name = "cbx_matakuliah";
            cbx_matakuliah.Size = new Size(379, 39);
            cbx_matakuliah.TabIndex = 5;
            // 
            // lbl_matakuliah
            // 
            lbl_matakuliah.AutoSize = true;
            lbl_matakuliah.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_matakuliah.Location = new Point(5, 214);
            lbl_matakuliah.Name = "lbl_matakuliah";
            lbl_matakuliah.Size = new Size(139, 36);
            lbl_matakuliah.TabIndex = 4;
            lbl_matakuliah.Text = "Mata Kuliah";
            lbl_matakuliah.Click += lbl_matakuliah_Click;
            // 
            // cbx_program
            // 
            cbx_program.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbx_program.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_program.FormattingEnabled = true;
            cbx_program.Location = new Point(3, 146);
            cbx_program.Name = "cbx_program";
            cbx_program.Size = new Size(376, 39);
            cbx_program.TabIndex = 3;
            // 
            // lbl_program
            // 
            lbl_program.AutoSize = true;
            lbl_program.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_program.Location = new Point(3, 107);
            lbl_program.Name = "lbl_program";
            lbl_program.Size = new Size(105, 36);
            lbl_program.TabIndex = 2;
            lbl_program.Text = "Program";
            // 
            // cbx_namamitra
            // 
            cbx_namamitra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbx_namamitra.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_namamitra.FormattingEnabled = true;
            cbx_namamitra.Location = new Point(3, 44);
            cbx_namamitra.Name = "cbx_namamitra";
            cbx_namamitra.Size = new Size(376, 39);
            cbx_namamitra.TabIndex = 1;
            // 
            // lbl_namamitra
            // 
            lbl_namamitra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_namamitra.AutoSize = true;
            lbl_namamitra.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_namamitra.Location = new Point(5, 5);
            lbl_namamitra.Name = "lbl_namamitra";
            lbl_namamitra.Size = new Size(138, 36);
            lbl_namamitra.TabIndex = 0;
            lbl_namamitra.Text = "Nama Mitra";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tbl_daftarprogrammitra);
            panel2.Controls.Add(lbl_daftarprogrammitra);
            panel2.Location = new Point(391, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 453);
            panel2.TabIndex = 1;
            // 
            // tbl_daftarprogrammitra
            // 
            tbl_daftarprogrammitra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_daftarprogrammitra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_daftarprogrammitra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_daftarprogrammitra.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            tbl_daftarprogrammitra.Location = new Point(4, 45);
            tbl_daftarprogrammitra.Name = "tbl_daftarprogrammitra";
            tbl_daftarprogrammitra.RowHeadersWidth = 62;
            tbl_daftarprogrammitra.RowTemplate.Height = 25;
            tbl_daftarprogrammitra.Size = new Size(376, 403);
            tbl_daftarprogrammitra.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama Mitra";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Program";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Mata Kuliah";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // lbl_daftarprogrammitra
            // 
            lbl_daftarprogrammitra.AutoSize = true;
            lbl_daftarprogrammitra.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_daftarprogrammitra.Location = new Point(3, 3);
            lbl_daftarprogrammitra.Name = "lbl_daftarprogrammitra";
            lbl_daftarprogrammitra.Size = new Size(234, 36);
            lbl_daftarprogrammitra.TabIndex = 0;
            lbl_daftarprogrammitra.Text = "Daftar Program Mitra";
            lbl_daftarprogrammitra.Click += label4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, manajemenAkunToolStripMenuItem, mitraToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 39);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(131, 35);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // manajemenAkunToolStripMenuItem
            // 
            manajemenAkunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { akunDosenToolStripMenuItem, akunMahasiswaToolStripMenuItem });
            manajemenAkunToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            manajemenAkunToolStripMenuItem.Name = "manajemenAkunToolStripMenuItem";
            manajemenAkunToolStripMenuItem.Size = new Size(189, 35);
            manajemenAkunToolStripMenuItem.Text = "Manajemen Akun";
            // 
            // akunDosenToolStripMenuItem
            // 
            akunDosenToolStripMenuItem.Name = "akunDosenToolStripMenuItem";
            akunDosenToolStripMenuItem.Size = new Size(269, 40);
            akunDosenToolStripMenuItem.Text = "Akun Dosen";
            // 
            // akunMahasiswaToolStripMenuItem
            // 
            akunMahasiswaToolStripMenuItem.Name = "akunMahasiswaToolStripMenuItem";
            akunMahasiswaToolStripMenuItem.Size = new Size(269, 40);
            akunMahasiswaToolStripMenuItem.Text = "Akun Mahasiswa";
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(76, 35);
            mitraToolStripMenuItem.Text = "Mitra";
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
            informasiAkunToolStripMenuItem.Size = new Size(253, 40);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(253, 40);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(lyt_mitra);
            Controls.Add(menuStrip1);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            lyt_mitra.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarprogrammitra).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel lyt_mitra;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem manajemenAkunToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem akunDosenToolStripMenuItem;
        private ToolStripMenuItem akunMahasiswaToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Panel panel1;
        private Button btn_simpan;
        private ComboBox cbx_matakuliah;
        private Label lbl_matakuliah;
        private ComboBox cbx_program;
        private Label lbl_program;
        private ComboBox cbx_namamitra;
        private Label lbl_namamitra;
        private Panel panel2;
        private DataGridView tbl_daftarprogrammitra;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label lbl_daftarprogrammitra;
    }
}