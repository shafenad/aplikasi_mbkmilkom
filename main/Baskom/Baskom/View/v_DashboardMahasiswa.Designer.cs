namespace Baskom.View
{
    partial class v_DashboardMahasiswa
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DashboardMahasiswa));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            pengajuanMitraToolStripMenuItem = new ToolStripMenuItem();
            statusMOAToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNilaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lyt_dashboard = new TableLayoutPanel();
            pnl_pic = new Panel();
            pic = new PictureBox();
            lbl_deskripsidashboard = new Label();
            menuStrip1.SuspendLayout();
            lyt_dashboard.SuspendLayout();
            pnl_pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNilaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1104, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(114, 28);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pengajuanMitraToolStripMenuItem, statusMOAToolStripMenuItem });
            mitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(65, 28);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click;
            // 
            // pengajuanMitraToolStripMenuItem
            // 
            pengajuanMitraToolStripMenuItem.Name = "pengajuanMitraToolStripMenuItem";
            pengajuanMitraToolStripMenuItem.Size = new Size(270, 34);
            pengajuanMitraToolStripMenuItem.Text = "Pengajuan MOA";
            pengajuanMitraToolStripMenuItem.Click += pengajuanMitraToolStripMenuItem_Click;
            // 
            // statusMOAToolStripMenuItem
            // 
            statusMOAToolStripMenuItem.Name = "statusMOAToolStripMenuItem";
            statusMOAToolStripMenuItem.Size = new Size(270, 34);
            statusMOAToolStripMenuItem.Text = "Status MOA";
            statusMOAToolStripMenuItem.Click += statusMOAToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(120, 28);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
            // 
            // konversiSKSToolStripMenuItem
            // 
            konversiSKSToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            konversiSKSToolStripMenuItem.Size = new Size(137, 28);
            konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            konversiSKSToolStripMenuItem.Click += konversiSKSToolStripMenuItem_Click;
            // 
            // konversiNilaiToolStripMenuItem
            // 
            konversiNilaiToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            konversiNilaiToolStripMenuItem.Size = new Size(136, 28);
            konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            konversiNilaiToolStripMenuItem.Click += konversiNilaiToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(67, 28);
            profilToolStripMenuItem.Text = "Profil";
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(228, 34);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(228, 34);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lyt_dashboard
            // 
            lyt_dashboard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lyt_dashboard.ColumnCount = 2;
            lyt_dashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_dashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_dashboard.Controls.Add(pnl_pic, 0, 0);
            lyt_dashboard.Controls.Add(lbl_deskripsidashboard, 1, 0);
            lyt_dashboard.Location = new Point(1, 52);
            lyt_dashboard.Name = "lyt_dashboard";
            lyt_dashboard.RowCount = 1;
            lyt_dashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lyt_dashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lyt_dashboard.Size = new Size(1103, 524);
            lyt_dashboard.TabIndex = 3;
            // 
            // pnl_pic
            // 
            pnl_pic.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnl_pic.Controls.Add(pic);
            pnl_pic.Location = new Point(3, 127);
            pnl_pic.Name = "pnl_pic";
            pnl_pic.Size = new Size(545, 270);
            pnl_pic.TabIndex = 1;
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pic.Image = Properties.Resources.baskom_logo_fit;
            pic.Location = new Point(62, 28);
            pic.Name = "pic";
            pic.Size = new Size(406, 208);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.Click += pic_Click;
            // 
            // lbl_deskripsidashboard
            // 
            lbl_deskripsidashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_deskripsidashboard.AutoSize = true;
            lbl_deskripsidashboard.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_deskripsidashboard.Location = new Point(555, 0);
            lbl_deskripsidashboard.Name = "lbl_deskripsidashboard";
            lbl_deskripsidashboard.Size = new Size(544, 524);
            lbl_deskripsidashboard.TabIndex = 2;
            lbl_deskripsidashboard.Text = resources.GetString("lbl_deskripsidashboard.Text");
            lbl_deskripsidashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // v_DashboardMahasiswa
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1104, 577);
            Controls.Add(lyt_dashboard);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_DashboardMahasiswa";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            lyt_dashboard.ResumeLayout(false);
            lyt_dashboard.PerformLayout();
            pnl_pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem konversiSKSToolStripMenuItem;
        private ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem pengajuanMitraToolStripMenuItem;
        private ToolStripMenuItem statusMOAToolStripMenuItem;
        private TableLayoutPanel lyt_dashboard;
        private PictureBox pic;
        private Panel pnl_pic;
        private Label lbl_deskripsidashboard;
    }
}