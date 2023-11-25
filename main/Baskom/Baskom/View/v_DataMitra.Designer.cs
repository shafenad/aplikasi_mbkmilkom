namespace Baskom.View
{
    partial class v_DataMitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DataMitra));
            lyt_mitra = new TableLayoutPanel();
            panel1 = new Panel();
            btn_tambah = new Button();
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
            btn_simpan = new Button();
            menuStrip2 = new MenuStrip();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            manajemenAkunToolStripMenuItem = new ToolStripMenuItem();
            akunToolStripMenuItem = new ToolStripMenuItem();
            akunMahasiswaToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            tambahMataKuliahToolStripMenuItem = new ToolStripMenuItem();
            tambahProgramToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            lyt_mitra.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarprogrammitra).BeginInit();
            menuStrip2.SuspendLayout();
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
            panel1.Controls.Add(btn_tambah);
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
            // btn_tambah
            // 
            btn_tambah.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_tambah.BackColor = SystemColors.MenuHighlight;
            btn_tambah.BackgroundImageLayout = ImageLayout.None;
            btn_tambah.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambah.ForeColor = Color.White;
            btn_tambah.Location = new Point(5, 410);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(105, 38);
            btn_tambah.TabIndex = 6;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = false;
            // 
            // cbx_matakuliah
            // 
            cbx_matakuliah.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbx_matakuliah.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_matakuliah.FormattingEnabled = true;
            cbx_matakuliah.Location = new Point(3, 253);
            cbx_matakuliah.Name = "cbx_matakuliah";
            cbx_matakuliah.Size = new Size(379, 50);
            cbx_matakuliah.TabIndex = 5;
            // 
            // lbl_matakuliah
            // 
            lbl_matakuliah.AutoSize = true;
            lbl_matakuliah.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_matakuliah.Location = new Point(5, 214);
            lbl_matakuliah.Name = "lbl_matakuliah";
            lbl_matakuliah.Size = new Size(184, 48);
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
            cbx_program.Size = new Size(376, 50);
            cbx_program.TabIndex = 3;
            // 
            // lbl_program
            // 
            lbl_program.AutoSize = true;
            lbl_program.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_program.Location = new Point(3, 107);
            lbl_program.Name = "lbl_program";
            lbl_program.Size = new Size(139, 48);
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
            cbx_namamitra.Size = new Size(376, 50);
            cbx_namamitra.TabIndex = 1;
            // 
            // lbl_namamitra
            // 
            lbl_namamitra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_namamitra.AutoSize = true;
            lbl_namamitra.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_namamitra.Location = new Point(5, 5);
            lbl_namamitra.Name = "lbl_namamitra";
            lbl_namamitra.Size = new Size(181, 48);
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
            lbl_daftarprogrammitra.Size = new Size(307, 48);
            lbl_daftarprogrammitra.TabIndex = 0;
            lbl_daftarprogrammitra.Text = "Daftar Program Mitra";
            lbl_daftarprogrammitra.Click += label4_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_simpan.BackColor = SystemColors.MenuHighlight;
            btn_simpan.BackgroundImageLayout = ImageLayout.None;
            btn_simpan.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(678, 538);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(105, 38);
            btn_simpan.TabIndex = 7;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, manajemenAkunToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, profilToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 50);
            menuStrip2.TabIndex = 8;
            menuStrip2.Text = "menuStrip2";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new Size(171, 46);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // manajemenAkunToolStripMenuItem
            // 
            manajemenAkunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { akunToolStripMenuItem, akunMahasiswaToolStripMenuItem });
            manajemenAkunToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            manajemenAkunToolStripMenuItem.Name = "manajemenAkunToolStripMenuItem";
            manajemenAkunToolStripMenuItem.Size = new Size(246, 46);
            manajemenAkunToolStripMenuItem.Text = "Manajemen Akun";
            // 
            // akunToolStripMenuItem
            // 
            akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            akunToolStripMenuItem.Size = new Size(359, 50);
            akunToolStripMenuItem.Text = "Akun Dosen";
            akunToolStripMenuItem.Click += akunToolStripMenuItem_Click;
            // 
            // akunMahasiswaToolStripMenuItem
            // 
            akunMahasiswaToolStripMenuItem.Name = "akunMahasiswaToolStripMenuItem";
            akunMahasiswaToolStripMenuItem.Size = new Size(359, 50);
            akunMahasiswaToolStripMenuItem.Text = "Akun Mahasiswa";
            akunMahasiswaToolStripMenuItem.Click += akunMahasiswaToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(99, 46);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tambahMataKuliahToolStripMenuItem, tambahProgramToolStripMenuItem });
            mataKuliahToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(178, 46);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            // 
            // tambahMataKuliahToolStripMenuItem
            // 
            tambahMataKuliahToolStripMenuItem.Name = "tambahMataKuliahToolStripMenuItem";
            tambahMataKuliahToolStripMenuItem.Size = new Size(402, 50);
            tambahMataKuliahToolStripMenuItem.Text = "Tambah Mata Kuliah";
            tambahMataKuliahToolStripMenuItem.Click += tambahMataKuliahToolStripMenuItem_Click;
            // 
            // tambahProgramToolStripMenuItem
            // 
            tambahProgramToolStripMenuItem.Name = "tambahProgramToolStripMenuItem";
            tambahProgramToolStripMenuItem.Size = new Size(402, 50);
            tambahProgramToolStripMenuItem.Text = "Tambah Program";
            tambahProgramToolStripMenuItem.Click += tambahProgramToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(96, 46);
            profilToolStripMenuItem.Text = "Profil";
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(359, 50);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click_1;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(359, 50);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // v_DataMitra
            // 
            AutoScaleDimensions = new SizeF(14F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(menuStrip2);
            Controls.Add(btn_simpan);
            Controls.Add(lyt_mitra);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_DataMitra";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form5_Load;
            lyt_mitra.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarprogrammitra).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel lyt_mitra;
        private Panel panel1;
        private Button btn_tambah;
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
        private Button btn_simpan;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem manajemenAkunToolStripMenuItem;
        private ToolStripMenuItem akunToolStripMenuItem;
        private ToolStripMenuItem akunMahasiswaToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem tambahMataKuliahToolStripMenuItem;
        private ToolStripMenuItem tambahProgramToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}