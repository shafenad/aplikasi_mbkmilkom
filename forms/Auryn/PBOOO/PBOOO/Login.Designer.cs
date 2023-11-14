namespace PBOOO
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_loginsebagai = new System.Windows.Forms.Label();
            this.btn_loginmahasiswa = new System.Windows.Forms.Button();
            this.btn_logintimmbkm = new System.Windows.Forms.Button();
            this.btn_loginadmin = new System.Windows.Forms.Button();
            this.pnl_3aktorbawah = new System.Windows.Forms.Panel();
            this.lbl_mbkmfasilkom = new System.Windows.Forms.Label();
            this.pnl_3aktoratas = new System.Windows.Forms.Panel();
            this.pnl_3aktorbawah.SuspendLayout();
            this.pnl_3aktoratas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_loginsebagai
            // 
            this.lbl_loginsebagai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_loginsebagai.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginsebagai.Location = new System.Drawing.Point(429, 118);
            this.lbl_loginsebagai.Name = "lbl_loginsebagai";
            this.lbl_loginsebagai.Size = new System.Drawing.Size(269, 56);
            this.lbl_loginsebagai.TabIndex = 1;
            this.lbl_loginsebagai.Text = "Login Sebagai?";
            this.lbl_loginsebagai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_loginsebagai.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_loginmahasiswa
            // 
            this.btn_loginmahasiswa.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginmahasiswa.Location = new System.Drawing.Point(159, 81);
            this.btn_loginmahasiswa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loginmahasiswa.Name = "btn_loginmahasiswa";
            this.btn_loginmahasiswa.Size = new System.Drawing.Size(203, 198);
            this.btn_loginmahasiswa.TabIndex = 2;
            this.btn_loginmahasiswa.Text = "Mahasiswa";
            this.btn_loginmahasiswa.UseVisualStyleBackColor = true;
            this.btn_loginmahasiswa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_logintimmbkm
            // 
            this.btn_logintimmbkm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_logintimmbkm.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logintimmbkm.Location = new System.Drawing.Point(462, 81);
            this.btn_logintimmbkm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_logintimmbkm.Name = "btn_logintimmbkm";
            this.btn_logintimmbkm.Size = new System.Drawing.Size(203, 201);
            this.btn_logintimmbkm.TabIndex = 3;
            this.btn_logintimmbkm.Text = "Tim MBKM";
            this.btn_logintimmbkm.UseVisualStyleBackColor = true;
            this.btn_logintimmbkm.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_loginadmin
            // 
            this.btn_loginadmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loginadmin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginadmin.Location = new System.Drawing.Point(766, 81);
            this.btn_loginadmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_loginadmin.Name = "btn_loginadmin";
            this.btn_loginadmin.Size = new System.Drawing.Size(203, 201);
            this.btn_loginadmin.TabIndex = 4;
            this.btn_loginadmin.Text = "Admin";
            this.btn_loginadmin.UseVisualStyleBackColor = true;
            // 
            // pnl_3aktorbawah
            // 
            this.pnl_3aktorbawah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_3aktorbawah.Controls.Add(this.btn_loginadmin);
            this.pnl_3aktorbawah.Controls.Add(this.btn_logintimmbkm);
            this.pnl_3aktorbawah.Controls.Add(this.btn_loginmahasiswa);
            this.pnl_3aktorbawah.Location = new System.Drawing.Point(1, 204);
            this.pnl_3aktorbawah.Name = "pnl_3aktorbawah";
            this.pnl_3aktorbawah.Size = new System.Drawing.Size(1149, 348);
            this.pnl_3aktorbawah.TabIndex = 5;
            this.pnl_3aktorbawah.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_mbkmfasilkom
            // 
            this.lbl_mbkmfasilkom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mbkmfasilkom.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mbkmfasilkom.Location = new System.Drawing.Point(276, 42);
            this.lbl_mbkmfasilkom.Name = "lbl_mbkmfasilkom";
            this.lbl_mbkmfasilkom.Size = new System.Drawing.Size(620, 76);
            this.lbl_mbkmfasilkom.TabIndex = 6;
            this.lbl_mbkmfasilkom.Text = "MBKM Fasilkom (BASKOM)";
            this.lbl_mbkmfasilkom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_mbkmfasilkom.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnl_3aktoratas
            // 
            this.pnl_3aktoratas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_3aktoratas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_3aktoratas.Controls.Add(this.lbl_mbkmfasilkom);
            this.pnl_3aktoratas.Controls.Add(this.lbl_loginsebagai);
            this.pnl_3aktoratas.Location = new System.Drawing.Point(1, -4);
            this.pnl_3aktoratas.Name = "pnl_3aktoratas";
            this.pnl_3aktoratas.Size = new System.Drawing.Size(1149, 202);
            this.pnl_3aktoratas.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 564);
            this.Controls.Add(this.pnl_3aktoratas);
            this.Controls.Add(this.pnl_3aktorbawah);
            this.Font = new System.Drawing.Font("Poppins", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_3aktorbawah.ResumeLayout(false);
            this.pnl_3aktoratas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_loginsebagai;
        private System.Windows.Forms.Button btn_loginmahasiswa;
        private System.Windows.Forms.Button btn_logintimmbkm;
        private System.Windows.Forms.Button btn_loginadmin;
        private System.Windows.Forms.Panel pnl_3aktorbawah;
        private System.Windows.Forms.Panel pnl_3aktoratas;
        private System.Windows.Forms.Label lbl_mbkmfasilkom;
    }
}

