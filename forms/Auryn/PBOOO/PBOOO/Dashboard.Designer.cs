namespace PBOOO
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengajuanMitraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMOAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mataKuliahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiSKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konversiNilaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informasiAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lyt_dashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pnl_pic = new System.Windows.Forms.Panel();
            this.lbl_deskripsidashboard = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.lyt_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.pnl_pic.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.mitraToolStripMenuItem,
            this.mataKuliahToolStripMenuItem,
            this.konversiSKSToolStripMenuItem,
            this.konversiNilaiToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 35);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // mitraToolStripMenuItem
            // 
            this.mitraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pengajuanMitraToolStripMenuItem,
            this.statusMOAToolStripMenuItem});
            this.mitraToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            this.mitraToolStripMenuItem.Size = new System.Drawing.Size(76, 35);
            this.mitraToolStripMenuItem.Text = "Mitra";
            // 
            // pengajuanMitraToolStripMenuItem
            // 
            this.pengajuanMitraToolStripMenuItem.Name = "pengajuanMitraToolStripMenuItem";
            this.pengajuanMitraToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.pengajuanMitraToolStripMenuItem.Text = "Pengajuan Mitra";
            // 
            // statusMOAToolStripMenuItem
            // 
            this.statusMOAToolStripMenuItem.Name = "statusMOAToolStripMenuItem";
            this.statusMOAToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.statusMOAToolStripMenuItem.Text = "Status MOA";
            // 
            // mataKuliahToolStripMenuItem
            // 
            this.mataKuliahToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            this.mataKuliahToolStripMenuItem.Size = new System.Drawing.Size(137, 35);
            this.mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            this.mataKuliahToolStripMenuItem.Click += new System.EventHandler(this.mataKuliahToolStripMenuItem_Click);
            // 
            // konversiSKSToolStripMenuItem
            // 
            this.konversiSKSToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            this.konversiSKSToolStripMenuItem.Size = new System.Drawing.Size(144, 35);
            this.konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            this.konversiSKSToolStripMenuItem.Click += new System.EventHandler(this.konversiSKSToolStripMenuItem_Click);
            // 
            // konversiNilaiToolStripMenuItem
            // 
            this.konversiNilaiToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            this.konversiNilaiToolStripMenuItem.Size = new System.Drawing.Size(148, 35);
            this.konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informasiAkunToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.profilToolStripMenuItem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(73, 35);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // informasiAkunToolStripMenuItem
            // 
            this.informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            this.informasiAkunToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(253, 40);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lyt_dashboard
            // 
            this.lyt_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lyt_dashboard.ColumnCount = 2;
            this.lyt_dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_dashboard.Controls.Add(this.pnl_pic, 0, 0);
            this.lyt_dashboard.Controls.Add(this.lbl_deskripsidashboard, 1, 0);
            this.lyt_dashboard.Location = new System.Drawing.Point(1, 52);
            this.lyt_dashboard.Name = "lyt_dashboard";
            this.lyt_dashboard.RowCount = 1;
            this.lyt_dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_dashboard.Size = new System.Drawing.Size(1103, 524);
            this.lyt_dashboard.TabIndex = 3;
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pic.Image = global::PBOOO.Properties.Resources.baskom_logo_fit;
            this.pic.Location = new System.Drawing.Point(62, 28);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(406, 208);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // pnl_pic
            // 
            this.pnl_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_pic.Controls.Add(this.pic);
            this.pnl_pic.Location = new System.Drawing.Point(3, 127);
            this.pnl_pic.Name = "pnl_pic";
            this.pnl_pic.Size = new System.Drawing.Size(545, 270);
            this.pnl_pic.TabIndex = 1;
            // 
            // lbl_deskripsidashboard
            // 
            this.lbl_deskripsidashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_deskripsidashboard.AutoSize = true;
            this.lbl_deskripsidashboard.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deskripsidashboard.Location = new System.Drawing.Point(555, 0);
            this.lbl_deskripsidashboard.Name = "lbl_deskripsidashboard";
            this.lbl_deskripsidashboard.Size = new System.Drawing.Size(543, 524);
            this.lbl_deskripsidashboard.TabIndex = 2;
            this.lbl_deskripsidashboard.Text = resources.GetString("lbl_deskripsidashboard.Text");
            this.lbl_deskripsidashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1104, 577);
            this.Controls.Add(this.lyt_dashboard);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Poppins", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.lyt_dashboard.ResumeLayout(false);
            this.lyt_dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.pnl_pic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mataKuliahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiSKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informasiAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengajuanMitraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusMOAToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel lyt_dashboard;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel pnl_pic;
        private System.Windows.Forms.Label lbl_deskripsidashboard;
    }
}