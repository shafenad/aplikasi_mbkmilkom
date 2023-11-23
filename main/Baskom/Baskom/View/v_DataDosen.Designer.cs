namespace Baskom.View
{
    partial class v_DataDosen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DataDosen));
            panel1 = new Panel();
            msp_navadmindosen = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            managemenAkunToolStripMenuItem = new ToolStripMenuItem();
            akunDosenToolStripMenuItem = new ToolStripMenuItem();
            akunToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            tambagToolStripMenuItem = new ToolStripMenuItem();
            tambahProgramToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            tbl_daftardosenadmin = new DataGridView();
            Column1 = new DataGridViewLinkColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            panel3 = new Panel();
            btn_tambahdaftardosenadmin = new Button();
            label1 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            msp_navadmindosen.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftardosenadmin).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(msp_navadmindosen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1882, 52);
            panel1.TabIndex = 0;
            // 
            // msp_navadmindosen
            // 
            msp_navadmindosen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            msp_navadmindosen.ImageScalingSize = new Size(20, 20);
            msp_navadmindosen.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, managemenAkunToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, profileToolStripMenuItem });
            msp_navadmindosen.Location = new Point(0, 0);
            msp_navadmindosen.Name = "msp_navadmindosen";
            msp_navadmindosen.Padding = new Padding(0);
            msp_navadmindosen.Size = new Size(1882, 38);
            msp_navadmindosen.TabIndex = 0;
            msp_navadmindosen.Text = "menuStrip1";
            msp_navadmindosen.ItemClicked += menuStrip1_ItemClicked_1;
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
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(86, 38);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tambagToolStripMenuItem, tambahProgramToolStripMenuItem });
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(158, 38);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            // 
            // tambagToolStripMenuItem
            // 
            tambagToolStripMenuItem.Name = "tambagToolStripMenuItem";
            tambagToolStripMenuItem.Size = new Size(365, 44);
            tambagToolStripMenuItem.Text = "Tambah Mata Kuliah";
            tambagToolStripMenuItem.Click += tambagToolStripMenuItem_Click;
            // 
            // tambahProgramToolStripMenuItem
            // 
            tambahProgramToolStripMenuItem.Name = "tambahProgramToolStripMenuItem";
            tambahProgramToolStripMenuItem.Size = new Size(365, 44);
            tambahProgramToolStripMenuItem.Text = "Tambah Program";
            tambahProgramToolStripMenuItem.Click += tambahProgramToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(103, 38);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tbl_daftardosenadmin);
            panel2.Location = new Point(39, 308);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1804, 467);
            panel2.TabIndex = 2;
            // 
            // tbl_daftardosenadmin
            // 
            tbl_daftardosenadmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_daftardosenadmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_daftardosenadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_daftardosenadmin.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            tbl_daftardosenadmin.Location = new Point(5, 5);
            tbl_daftardosenadmin.Margin = new Padding(5);
            tbl_daftardosenadmin.Name = "tbl_daftardosenadmin";
            tbl_daftardosenadmin.RowHeadersWidth = 51;
            tbl_daftardosenadmin.RowTemplate.Height = 29;
            tbl_daftardosenadmin.Size = new Size(1794, 456);
            tbl_daftardosenadmin.TabIndex = 0;
            tbl_daftardosenadmin.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            Column2.HeaderText = "NIP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Lihat";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(btn_tambahdaftardosenadmin);
            panel3.Location = new Point(1576, 819);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 56);
            panel3.TabIndex = 3;
            // 
            // btn_tambahdaftardosenadmin
            // 
            btn_tambahdaftardosenadmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_tambahdaftardosenadmin.BackColor = SystemColors.Highlight;
            btn_tambahdaftardosenadmin.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambahdaftardosenadmin.ForeColor = SystemColors.ControlLightLight;
            btn_tambahdaftardosenadmin.Location = new Point(0, 0);
            btn_tambahdaftardosenadmin.Margin = new Padding(5);
            btn_tambahdaftardosenadmin.Name = "btn_tambahdaftardosenadmin";
            btn_tambahdaftardosenadmin.Size = new Size(260, 56);
            btn_tambahdaftardosenadmin.TabIndex = 0;
            btn_tambahdaftardosenadmin.Text = "Tambah";
            btn_tambahdaftardosenadmin.UseVisualStyleBackColor = false;
            btn_tambahdaftardosenadmin.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 3);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 42);
            label1.TabIndex = 0;
            label1.Text = "Daftar Dosen";
            label1.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Location = new Point(39, 178);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(378, 70);
            panel4.TabIndex = 4;
            // 
            // v_DataDosen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 968);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "v_DataDosen";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            msp_navadmindosen.ResumeLayout(false);
            msp_navadmindosen.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_daftardosenadmin).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip msp_navadmindosen;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem managemenAkunToolStripMenuItem;
        private ToolStripMenuItem akunDosenToolStripMenuItem;
        private ToolStripMenuItem akunToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private DataGridView tbl_daftardosenadmin;
        private Button btn_tambahdaftardosenadmin;
        private Label label1;
        private Panel panel4;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private DataGridViewLinkColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem tambagToolStripMenuItem;
        private ToolStripMenuItem tambahProgramToolStripMenuItem;
    }
}