namespace Baskom.View
{
    partial class v_DataMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DataMahasiswa));
            panel1 = new Panel();
            msp_navadminmhs = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            managemenAkunToolStripMenuItem = new ToolStripMenuItem();
            akunDosenToolStripMenuItem = new ToolStripMenuItem();
            akunToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            tambahMitraProgramToolStripMenuItem = new ToolStripMenuItem();
            tambahProgramMataKuliahToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel4 = new Panel();
            label1 = new Label();
            btn_tambahdaftarmhsadmin = new Button();
            tbl_daftarmhsadmin = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            msp_navadminmhs.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarmhsadmin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(msp_navadminmhs);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2142, 52);
            panel1.TabIndex = 1;
            // 
            // msp_navadminmhs
            // 
            msp_navadminmhs.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            msp_navadminmhs.ImageScalingSize = new Size(20, 20);
            msp_navadminmhs.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, managemenAkunToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, profileToolStripMenuItem });
            msp_navadminmhs.Location = new Point(0, 0);
            msp_navadminmhs.Name = "msp_navadminmhs";
            msp_navadminmhs.Padding = new Padding(0);
            msp_navadminmhs.Size = new Size(2142, 38);
            msp_navadminmhs.TabIndex = 0;
            msp_navadminmhs.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(151, 38);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // managemenAkunToolStripMenuItem
            // 
            managemenAkunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { akunDosenToolStripMenuItem, akunToolStripMenuItem });
            managemenAkunToolStripMenuItem.Name = "managemenAkunToolStripMenuItem";
            managemenAkunToolStripMenuItem.Size = new Size(226, 38);
            managemenAkunToolStripMenuItem.Text = "Managemen Akun";
            // 
            // akunDosenToolStripMenuItem
            // 
            akunDosenToolStripMenuItem.Name = "akunDosenToolStripMenuItem";
            akunDosenToolStripMenuItem.Size = new Size(324, 44);
            akunDosenToolStripMenuItem.Text = "Akun Dosen";
            akunDosenToolStripMenuItem.Click += akunDosenToolStripMenuItem_Click;
            // 
            // akunToolStripMenuItem
            // 
            akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            akunToolStripMenuItem.Size = new Size(324, 44);
            akunToolStripMenuItem.Text = "Akun Mahasiswa";
            akunToolStripMenuItem.Click += akunToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tambahMitraProgramToolStripMenuItem, tambahProgramMataKuliahToolStripMenuItem });
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(86, 38);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click;
            // 
            // tambahMitraProgramToolStripMenuItem
            // 
            tambahMitraProgramToolStripMenuItem.Name = "tambahMitraProgramToolStripMenuItem";
            tambahMitraProgramToolStripMenuItem.Size = new Size(464, 44);
            tambahMitraProgramToolStripMenuItem.Text = "Tambah Mitra Program";
            tambahMitraProgramToolStripMenuItem.Click += tambahMitraProgramToolStripMenuItem_Click;
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
            mataKuliahToolStripMenuItem.Size = new Size(158, 38);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(103, 38);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(302, 44);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(302, 44);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Location = new Point(39, 177);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 70);
            panel4.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 1);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 42);
            label1.TabIndex = 0;
            label1.Text = "Daftar Mahasiswa";
            label1.Click += label1_Click;
            // 
            // btn_tambahdaftarmhsadmin
            // 
            btn_tambahdaftarmhsadmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_tambahdaftarmhsadmin.BackColor = SystemColors.Highlight;
            btn_tambahdaftarmhsadmin.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambahdaftarmhsadmin.ForeColor = SystemColors.ControlLightLight;
            btn_tambahdaftarmhsadmin.Location = new Point(1834, 954);
            btn_tambahdaftarmhsadmin.Margin = new Padding(5);
            btn_tambahdaftarmhsadmin.Name = "btn_tambahdaftarmhsadmin";
            btn_tambahdaftarmhsadmin.Size = new Size(260, 56);
            btn_tambahdaftarmhsadmin.TabIndex = 9;
            btn_tambahdaftarmhsadmin.Text = "Tambah";
            btn_tambahdaftarmhsadmin.UseVisualStyleBackColor = false;
            btn_tambahdaftarmhsadmin.Click += btn_tambahdaftarmhsadmin_Click;
            // 
            // tbl_daftarmhsadmin
            // 
            tbl_daftarmhsadmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_daftarmhsadmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_daftarmhsadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_daftarmhsadmin.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            tbl_daftarmhsadmin.Location = new Point(39, 306);
            tbl_daftarmhsadmin.Margin = new Padding(5);
            tbl_daftarmhsadmin.Name = "tbl_daftarmhsadmin";
            tbl_daftarmhsadmin.RowHeadersWidth = 51;
            tbl_daftarmhsadmin.RowTemplate.Height = 29;
            tbl_daftarmhsadmin.Size = new Size(2055, 607);
            tbl_daftarmhsadmin.TabIndex = 8;
            tbl_daftarmhsadmin.CellContentClick += tbl_daftarmhsadmin_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "NIM";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Lihat";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // v_DataMahasiswa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2142, 1065);
            Controls.Add(btn_tambahdaftarmhsadmin);
            Controls.Add(tbl_daftarmhsadmin);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "v_DataMahasiswa";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            msp_navadminmhs.ResumeLayout(false);
            msp_navadminmhs.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarmhsadmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip msp_navadminmhs;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem managemenAkunToolStripMenuItem;
        private ToolStripMenuItem akunDosenToolStripMenuItem;
        private ToolStripMenuItem akunToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel4;
        private Label label1;
        private Button btn_tambahdaftarmhsadmin;
        private DataGridView tbl_daftarmhsadmin;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private ToolStripMenuItem tambahMitraProgramToolStripMenuItem;
        private ToolStripMenuItem tambahProgramMataKuliahToolStripMenuItem;
    }
}