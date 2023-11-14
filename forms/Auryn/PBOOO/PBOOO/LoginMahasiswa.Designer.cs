namespace PBOOO
{
    partial class LoginMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMahasiswa));
            this.pnl_loginkiri = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pnl_loginkanan = new System.Windows.Forms.Panel();
            this.btn_katasandi = new System.Windows.Forms.Button();
            this.lnk_loginsbgyglain = new System.Windows.Forms.LinkLabel();
            this.lnk_lupakatasandi = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.tbx_katasandilogin = new System.Windows.Forms.TextBox();
            this.lbl_katasandilogin = new System.Windows.Forms.Label();
            this.tbx_nimlogin = new System.Windows.Forms.TextBox();
            this.lbl_nimlogin = new System.Windows.Forms.Label();
            this.lbl_loginmahasiswa = new System.Windows.Forms.Label();
            this.lyt_loginmahasiswa = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_loginkiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.pnl_loginkanan.SuspendLayout();
            this.lyt_loginmahasiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_loginkiri
            // 
            this.pnl_loginkiri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_loginkiri.Controls.Add(this.pic);
            this.pnl_loginkiri.Location = new System.Drawing.Point(3, 209);
            this.pnl_loginkiri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_loginkiri.Name = "pnl_loginkiri";
            this.pnl_loginkiri.Size = new System.Drawing.Size(593, 289);
            this.pnl_loginkiri.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pic.Image = global::PBOOO.Properties.Resources.baskom_logo_fit;
            this.pic.Location = new System.Drawing.Point(69, 32);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(434, 225);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // pnl_loginkanan
            // 
            this.pnl_loginkanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_loginkanan.Controls.Add(this.btn_katasandi);
            this.pnl_loginkanan.Controls.Add(this.lnk_loginsbgyglain);
            this.pnl_loginkanan.Controls.Add(this.lnk_lupakatasandi);
            this.pnl_loginkanan.Controls.Add(this.btn_login);
            this.pnl_loginkanan.Controls.Add(this.tbx_katasandilogin);
            this.pnl_loginkanan.Controls.Add(this.lbl_katasandilogin);
            this.pnl_loginkanan.Controls.Add(this.tbx_nimlogin);
            this.pnl_loginkanan.Controls.Add(this.lbl_nimlogin);
            this.pnl_loginkanan.Controls.Add(this.lbl_loginmahasiswa);
            this.pnl_loginkanan.Location = new System.Drawing.Point(602, 4);
            this.pnl_loginkanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_loginkanan.Name = "pnl_loginkanan";
            this.pnl_loginkanan.Size = new System.Drawing.Size(594, 699);
            this.pnl_loginkanan.TabIndex = 1;
            this.pnl_loginkanan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_katasandi
            // 
            this.btn_katasandi.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_katasandi.Location = new System.Drawing.Point(430, 332);
            this.btn_katasandi.Name = "btn_katasandi";
            this.btn_katasandi.Size = new System.Drawing.Size(77, 24);
            this.btn_katasandi.TabIndex = 10;
            this.btn_katasandi.Text = "Lihat";
            this.btn_katasandi.UseVisualStyleBackColor = true;
            // 
            // lnk_loginsbgyglain
            // 
            this.lnk_loginsbgyglain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lnk_loginsbgyglain.AutoSize = true;
            this.lnk_loginsbgyglain.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_loginsbgyglain.Location = new System.Drawing.Point(215, 487);
            this.lnk_loginsbgyglain.Name = "lnk_loginsbgyglain";
            this.lnk_loginsbgyglain.Size = new System.Drawing.Size(178, 25);
            this.lnk_loginsbgyglain.TabIndex = 9;
            this.lnk_loginsbgyglain.TabStop = true;
            this.lnk_loginsbgyglain.Text = "Log In sebagai yang lain";
            this.lnk_loginsbgyglain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lnk_lupakatasandi
            // 
            this.lnk_lupakatasandi.AutoSize = true;
            this.lnk_lupakatasandi.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_lupakatasandi.Location = new System.Drawing.Point(79, 400);
            this.lnk_lupakatasandi.Name = "lnk_lupakatasandi";
            this.lnk_lupakatasandi.Size = new System.Drawing.Size(129, 25);
            this.lnk_lupakatasandi.TabIndex = 8;
            this.lnk_lupakatasandi.TabStop = true;
            this.lnk_lupakatasandi.Text = "Lupa Kata Sandi?";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_login.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(83, 440);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(424, 44);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_katasandilogin
            // 
            this.tbx_katasandilogin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_katasandilogin.Location = new System.Drawing.Point(83, 332);
            this.tbx_katasandilogin.Name = "tbx_katasandilogin";
            this.tbx_katasandilogin.Size = new System.Drawing.Size(341, 34);
            this.tbx_katasandilogin.TabIndex = 4;
            // 
            // lbl_katasandilogin
            // 
            this.lbl_katasandilogin.AutoSize = true;
            this.lbl_katasandilogin.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_katasandilogin.Location = new System.Drawing.Point(76, 291);
            this.lbl_katasandilogin.Name = "lbl_katasandilogin";
            this.lbl_katasandilogin.Size = new System.Drawing.Size(128, 36);
            this.lbl_katasandilogin.TabIndex = 3;
            this.lbl_katasandilogin.Text = "Kata Sandi";
            // 
            // tbx_nimlogin
            // 
            this.tbx_nimlogin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nimlogin.Location = new System.Drawing.Point(83, 226);
            this.tbx_nimlogin.Name = "tbx_nimlogin";
            this.tbx_nimlogin.Size = new System.Drawing.Size(424, 34);
            this.tbx_nimlogin.TabIndex = 2;
            // 
            // lbl_nimlogin
            // 
            this.lbl_nimlogin.AutoSize = true;
            this.lbl_nimlogin.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nimlogin.Location = new System.Drawing.Point(76, 185);
            this.lbl_nimlogin.Name = "lbl_nimlogin";
            this.lbl_nimlogin.Size = new System.Drawing.Size(54, 36);
            this.lbl_nimlogin.TabIndex = 1;
            this.lbl_nimlogin.Text = "NIM";
            // 
            // lbl_loginmahasiswa
            // 
            this.lbl_loginmahasiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_loginmahasiswa.AutoSize = true;
            this.lbl_loginmahasiswa.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginmahasiswa.Location = new System.Drawing.Point(177, 106);
            this.lbl_loginmahasiswa.Name = "lbl_loginmahasiswa";
            this.lbl_loginmahasiswa.Size = new System.Drawing.Size(345, 64);
            this.lbl_loginmahasiswa.TabIndex = 0;
            this.lbl_loginmahasiswa.Text = "Login Mahasiswa";
            this.lbl_loginmahasiswa.Click += new System.EventHandler(this.label1_Click);
            // 
            // lyt_loginmahasiswa
            // 
            this.lyt_loginmahasiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lyt_loginmahasiswa.ColumnCount = 2;
            this.lyt_loginmahasiswa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_loginmahasiswa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_loginmahasiswa.Controls.Add(this.pnl_loginkiri, 0, 0);
            this.lyt_loginmahasiswa.Controls.Add(this.pnl_loginkanan, 1, 0);
            this.lyt_loginmahasiswa.Location = new System.Drawing.Point(12, 12);
            this.lyt_loginmahasiswa.Name = "lyt_loginmahasiswa";
            this.lyt_loginmahasiswa.RowCount = 1;
            this.lyt_loginmahasiswa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_loginmahasiswa.Size = new System.Drawing.Size(1199, 707);
            this.lyt_loginmahasiswa.TabIndex = 2;
            // 
            // LoginMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 731);
            this.Controls.Add(this.lyt_loginmahasiswa);
            this.Font = new System.Drawing.Font("Poppins", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginMahasiswa";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_loginkiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.pnl_loginkanan.ResumeLayout(false);
            this.pnl_loginkanan.PerformLayout();
            this.lyt_loginmahasiswa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_loginkiri;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel pnl_loginkanan;
        private System.Windows.Forms.Label lbl_loginmahasiswa;
        private System.Windows.Forms.TextBox tbx_katasandilogin;
        private System.Windows.Forms.Label lbl_katasandilogin;
        private System.Windows.Forms.TextBox tbx_nimlogin;
        private System.Windows.Forms.Label lbl_nimlogin;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel lnk_lupakatasandi;
        private System.Windows.Forms.LinkLabel lnk_loginsbgyglain;
        private System.Windows.Forms.Button btn_katasandi;
        private System.Windows.Forms.TableLayoutPanel lyt_loginmahasiswa;
    }
}