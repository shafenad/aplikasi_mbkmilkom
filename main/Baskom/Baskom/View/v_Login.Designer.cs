namespace Baskom.View
{
    partial class v_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_Login));
            lbl_loginsebagai = new Label();
            btn_loginmahasiswa = new Button();
            btn_logintimmbkm = new Button();
            btn_loginadmin = new Button();
            pnl_3aktorbawah = new Panel();
            lbl_mbkmfasilkom = new Label();
            pnl_3aktoratas = new Panel();
            pnl_3aktorbawah.SuspendLayout();
            pnl_3aktoratas.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_loginsebagai
            // 
            lbl_loginsebagai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_loginsebagai.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_loginsebagai.Location = new Point(429, 118);
            lbl_loginsebagai.Name = "lbl_loginsebagai";
            lbl_loginsebagai.Size = new Size(269, 56);
            lbl_loginsebagai.TabIndex = 1;
            lbl_loginsebagai.Text = "Login Sebagai?";
            lbl_loginsebagai.TextAlign = ContentAlignment.TopCenter;
            lbl_loginsebagai.Click += label2_Click;
            // 
            // btn_loginmahasiswa
            // 
            btn_loginmahasiswa.Anchor = AnchorStyles.None;
            btn_loginmahasiswa.AutoSize = true;
            btn_loginmahasiswa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loginmahasiswa.Location = new Point(151, 46);
            btn_loginmahasiswa.Margin = new Padding(3, 4, 3, 4);
            btn_loginmahasiswa.Name = "btn_loginmahasiswa";
            btn_loginmahasiswa.Size = new Size(240, 240);
            btn_loginmahasiswa.TabIndex = 2;
            btn_loginmahasiswa.Text = "Mahasiswa";
            btn_loginmahasiswa.UseVisualStyleBackColor = true;
            btn_loginmahasiswa.Click += button1_Click;
            // 
            // btn_logintimmbkm
            // 
            btn_logintimmbkm.Anchor = AnchorStyles.None;
            btn_logintimmbkm.AutoSize = true;
            btn_logintimmbkm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logintimmbkm.Location = new Point(458, 46);
            btn_logintimmbkm.Margin = new Padding(3, 4, 3, 4);
            btn_logintimmbkm.Name = "btn_logintimmbkm";
            btn_logintimmbkm.Size = new Size(240, 240);
            btn_logintimmbkm.TabIndex = 3;
            btn_logintimmbkm.Text = "Tim MBKM";
            btn_logintimmbkm.UseVisualStyleBackColor = true;
            btn_logintimmbkm.Click += button2_Click;
            // 
            // btn_loginadmin
            // 
            btn_loginadmin.Anchor = AnchorStyles.None;
            btn_loginadmin.AutoSize = true;
            btn_loginadmin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loginadmin.Location = new Point(766, 46);
            btn_loginadmin.Margin = new Padding(3, 4, 3, 4);
            btn_loginadmin.Name = "btn_loginadmin";
            btn_loginadmin.Size = new Size(240, 240);
            btn_loginadmin.TabIndex = 4;
            btn_loginadmin.Text = "Admin";
            btn_loginadmin.UseVisualStyleBackColor = true;
            btn_loginadmin.Click += btn_loginadmin_Click;
            // 
            // pnl_3aktorbawah
            // 
            pnl_3aktorbawah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_3aktorbawah.Controls.Add(btn_loginadmin);
            pnl_3aktorbawah.Controls.Add(btn_logintimmbkm);
            pnl_3aktorbawah.Controls.Add(btn_loginmahasiswa);
            pnl_3aktorbawah.Location = new Point(1, 204);
            pnl_3aktorbawah.Name = "pnl_3aktorbawah";
            pnl_3aktorbawah.Size = new Size(1149, 348);
            pnl_3aktorbawah.TabIndex = 5;
            pnl_3aktorbawah.Paint += panel1_Paint;
            // 
            // lbl_mbkmfasilkom
            // 
            lbl_mbkmfasilkom.Anchor = AnchorStyles.Top;
            lbl_mbkmfasilkom.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_mbkmfasilkom.Location = new Point(276, 42);
            lbl_mbkmfasilkom.Name = "lbl_mbkmfasilkom";
            lbl_mbkmfasilkom.Size = new Size(620, 76);
            lbl_mbkmfasilkom.TabIndex = 6;
            lbl_mbkmfasilkom.Text = "MBKM Fasilkom (BASKOM)";
            lbl_mbkmfasilkom.TextAlign = ContentAlignment.TopCenter;
            lbl_mbkmfasilkom.Click += label3_Click;
            // 
            // pnl_3aktoratas
            // 
            pnl_3aktoratas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_3aktoratas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_3aktoratas.Controls.Add(lbl_mbkmfasilkom);
            pnl_3aktoratas.Controls.Add(lbl_loginsebagai);
            pnl_3aktoratas.Location = new Point(1, -4);
            pnl_3aktoratas.Name = "pnl_3aktoratas";
            pnl_3aktoratas.Size = new Size(1149, 202);
            pnl_3aktoratas.TabIndex = 7;
            // 
            // v_Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 564);
            Controls.Add(pnl_3aktoratas);
            Controls.Add(pnl_3aktorbawah);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_Login";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnl_3aktorbawah.ResumeLayout(false);
            pnl_3aktorbawah.PerformLayout();
            pnl_3aktoratas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_loginsebagai;
        private Button btn_loginmahasiswa;
        private Button btn_logintimmbkm;
        private Button btn_loginadmin;
        private Panel pnl_3aktorbawah;
        private Panel pnl_3aktoratas;
        private Label lbl_mbkmfasilkom;
    }
}

