namespace PBO
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lyt = new TableLayoutPanel();
            panel2 = new Panel();
            btn_lihat = new Button();
            lnk_loginsebagaiyanglain = new LinkLabel();
            btn_login = new Button();
            lnk_lupakatasandi = new LinkLabel();
            tbx_katasandi = new TextBox();
            lbl_katasandi = new Label();
            tbx_email = new TextBox();
            lbl_email = new Label();
            lbl_loginadmin = new Label();
            panel1 = new Panel();
            pic_logo = new PictureBox();
            lyt.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            SuspendLayout();
            // 
            // lyt
            // 
            lyt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lyt.ColumnCount = 2;
            lyt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt.Controls.Add(panel2, 1, 0);
            lyt.Controls.Add(panel1, 0, 0);
            lyt.Location = new Point(13, 121);
            lyt.Margin = new Padding(3, 6, 3, 6);
            lyt.Name = "lyt";
            lyt.RowCount = 1;
            lyt.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lyt.Size = new Size(854, 588);
            lyt.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btn_lihat);
            panel2.Controls.Add(lnk_loginsebagaiyanglain);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(lnk_lupakatasandi);
            panel2.Controls.Add(tbx_katasandi);
            panel2.Controls.Add(lbl_katasandi);
            panel2.Controls.Add(tbx_email);
            panel2.Controls.Add(lbl_email);
            panel2.Controls.Add(lbl_loginadmin);
            panel2.Location = new Point(430, 6);
            panel2.Margin = new Padding(3, 6, 3, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 576);
            panel2.TabIndex = 1;
            // 
            // btn_lihat
            // 
            btn_lihat.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_lihat.Location = new Point(340, 316);
            btn_lihat.Margin = new Padding(3, 4, 3, 4);
            btn_lihat.Name = "btn_lihat";
            btn_lihat.Size = new Size(81, 38);
            btn_lihat.TabIndex = 10;
            btn_lihat.Text = "Lihat";
            btn_lihat.UseVisualStyleBackColor = true;
            // 
            // lnk_loginsebagaiyanglain
            // 
            lnk_loginsebagaiyanglain.AutoSize = true;
            lnk_loginsebagaiyanglain.Font = new Font("Poppins", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lnk_loginsebagaiyanglain.Location = new Point(128, 471);
            lnk_loginsebagaiyanglain.Name = "lnk_loginsebagaiyanglain";
            lnk_loginsebagaiyanglain.Size = new Size(178, 25);
            lnk_loginsebagaiyanglain.TabIndex = 7;
            lnk_loginsebagaiyanglain.TabStop = true;
            lnk_loginsebagaiyanglain.Text = "Log In sebagai yang lain";
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.MenuHighlight;
            btn_login.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(15, 417);
            btn_login.Margin = new Padding(3, 6, 3, 6);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(406, 48);
            btn_login.TabIndex = 6;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // lnk_lupakatasandi
            // 
            lnk_lupakatasandi.AutoSize = true;
            lnk_lupakatasandi.Font = new Font("Poppins", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lnk_lupakatasandi.Location = new Point(14, 356);
            lnk_lupakatasandi.Name = "lnk_lupakatasandi";
            lnk_lupakatasandi.Size = new Size(129, 25);
            lnk_lupakatasandi.TabIndex = 5;
            lnk_lupakatasandi.TabStop = true;
            lnk_lupakatasandi.Text = "Lupa Kata Sandi?";
            // 
            // tbx_katasandi
            // 
            tbx_katasandi.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_katasandi.Location = new Point(14, 316);
            tbx_katasandi.Margin = new Padding(3, 6, 3, 6);
            tbx_katasandi.Name = "tbx_katasandi";
            tbx_katasandi.Size = new Size(320, 34);
            tbx_katasandi.TabIndex = 4;
            // 
            // lbl_katasandi
            // 
            lbl_katasandi.AutoSize = true;
            lbl_katasandi.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandi.Location = new Point(15, 274);
            lbl_katasandi.Name = "lbl_katasandi";
            lbl_katasandi.Size = new Size(128, 36);
            lbl_katasandi.TabIndex = 3;
            lbl_katasandi.Text = "Kata Sandi";
            lbl_katasandi.Click += lbl_katasandi_Click;
            // 
            // tbx_email
            // 
            tbx_email.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_email.Location = new Point(14, 212);
            tbx_email.Margin = new Padding(3, 6, 3, 6);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(407, 34);
            tbx_email.TabIndex = 2;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(15, 170);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(73, 36);
            lbl_email.TabIndex = 1;
            lbl_email.Text = "Email";
            lbl_email.Click += lbl_email_Click;
            // 
            // lbl_loginadmin
            // 
            lbl_loginadmin.AutoSize = true;
            lbl_loginadmin.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_loginadmin.Location = new Point(87, 66);
            lbl_loginadmin.Name = "lbl_loginadmin";
            lbl_loginadmin.Size = new Size(258, 64);
            lbl_loginadmin.TabIndex = 0;
            lbl_loginadmin.Text = "Login Admin";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pic_logo);
            panel1.Location = new Point(3, 6);
            panel1.Margin = new Padding(3, 6, 3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 576);
            panel1.TabIndex = 2;
            // 
            // pic_logo
            // 
            pic_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic_logo.Image = (Image)resources.GetObject("pic_logo.Image");
            pic_logo.Location = new Point(-1, 152);
            pic_logo.Margin = new Padding(3, 6, 3, 6);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(421, 272);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 0;
            pic_logo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 930);
            Controls.Add(lyt);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 6, 3, 6);
            Name = "Form1";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            lyt.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel lyt;
        private Panel panel2;
        private Label lbl_email;
        private Label lbl_loginadmin;
        private TextBox tbx_katasandi;
        private Label lbl_katasandi;
        private TextBox tbx_email;
        private Button btn_login;
        private LinkLabel lnk_lupakatasandi;
        private LinkLabel lnk_loginsebagaiyanglain;
        private Panel panel1;
        private PictureBox pic_logo;
        private Button btn_lihat;
    }
}