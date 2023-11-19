namespace PBO
{
    partial class TambahDosen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahDosen));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tbx_jabatan = new TextBox();
            tbx_nidn = new TextBox();
            lbl_jabatan = new Label();
            lbl_nidn = new Label();
            tbx_nip = new TextBox();
            lbl_nip = new Label();
            tbx_nama = new TextBox();
            lbl_nama = new Label();
            panel2 = new Panel();
            btn_tambah = new Button();
            tbx_katasandi = new TextBox();
            lbl_katasandi = new Label();
            tbx_email = new TextBox();
            lbl_email = new Label();
            tbx_nowhatsapp = new TextBox();
            lbl_nowhatsapp = new Label();
            lbl_tambahdosen = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 110);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(856, 356);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tbx_jabatan);
            panel1.Controls.Add(tbx_nidn);
            panel1.Controls.Add(lbl_jabatan);
            panel1.Controls.Add(lbl_nidn);
            panel1.Controls.Add(tbx_nip);
            panel1.Controls.Add(lbl_nip);
            panel1.Controls.Add(tbx_nama);
            panel1.Controls.Add(lbl_nama);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 350);
            panel1.TabIndex = 0;
            // 
            // tbx_jabatan
            // 
            tbx_jabatan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_jabatan.Location = new Point(5, 304);
            tbx_jabatan.Name = "tbx_jabatan";
            tbx_jabatan.Size = new Size(416, 34);
            tbx_jabatan.TabIndex = 4;
            // 
            // tbx_nidn
            // 
            tbx_nidn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_nidn.Location = new Point(5, 215);
            tbx_nidn.Name = "tbx_nidn";
            tbx_nidn.Size = new Size(416, 34);
            tbx_nidn.TabIndex = 4;
            // 
            // lbl_jabatan
            // 
            lbl_jabatan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_jabatan.AutoSize = true;
            lbl_jabatan.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_jabatan.Location = new Point(7, 265);
            lbl_jabatan.Name = "lbl_jabatan";
            lbl_jabatan.Size = new Size(103, 36);
            lbl_jabatan.TabIndex = 3;
            lbl_jabatan.Text = "Jabatan";
            // 
            // lbl_nidn
            // 
            lbl_nidn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nidn.AutoSize = true;
            lbl_nidn.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nidn.Location = new Point(7, 176);
            lbl_nidn.Name = "lbl_nidn";
            lbl_nidn.Size = new Size(65, 36);
            lbl_nidn.TabIndex = 3;
            lbl_nidn.Text = "NIDN";
            // 
            // tbx_nip
            // 
            tbx_nip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_nip.Location = new Point(3, 130);
            tbx_nip.Name = "tbx_nip";
            tbx_nip.Size = new Size(416, 34);
            tbx_nip.TabIndex = 3;
            // 
            // lbl_nip
            // 
            lbl_nip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nip.AutoSize = true;
            lbl_nip.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nip.Location = new Point(5, 91);
            lbl_nip.Name = "lbl_nip";
            lbl_nip.Size = new Size(48, 36);
            lbl_nip.TabIndex = 2;
            lbl_nip.Text = "NIP";
            // 
            // tbx_nama
            // 
            tbx_nama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_nama.Location = new Point(3, 44);
            tbx_nama.Name = "tbx_nama";
            tbx_nama.Size = new Size(416, 34);
            tbx_nama.TabIndex = 1;
            // 
            // lbl_nama
            // 
            lbl_nama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nama.AutoSize = true;
            lbl_nama.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nama.Location = new Point(5, 5);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(79, 36);
            lbl_nama.TabIndex = 0;
            lbl_nama.Text = "Nama";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btn_tambah);
            panel2.Controls.Add(tbx_katasandi);
            panel2.Controls.Add(lbl_katasandi);
            panel2.Controls.Add(tbx_email);
            panel2.Controls.Add(lbl_email);
            panel2.Controls.Add(tbx_nowhatsapp);
            panel2.Controls.Add(lbl_nowhatsapp);
            panel2.Location = new Point(431, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 350);
            panel2.TabIndex = 1;
            // 
            // btn_tambah
            // 
            btn_tambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_tambah.BackColor = SystemColors.MenuHighlight;
            btn_tambah.BackgroundImageLayout = ImageLayout.None;
            btn_tambah.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambah.ForeColor = Color.White;
            btn_tambah.Location = new Point(314, 306);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(105, 38);
            btn_tambah.TabIndex = 13;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = false;
            btn_tambah.Click += button3_Click;
            // 
            // tbx_katasandi
            // 
            tbx_katasandi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_katasandi.Location = new Point(3, 217);
            tbx_katasandi.Name = "tbx_katasandi";
            tbx_katasandi.Size = new Size(416, 34);
            tbx_katasandi.TabIndex = 7;
            // 
            // lbl_katasandi
            // 
            lbl_katasandi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_katasandi.AutoSize = true;
            lbl_katasandi.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandi.Location = new Point(5, 178);
            lbl_katasandi.Name = "lbl_katasandi";
            lbl_katasandi.Size = new Size(128, 36);
            lbl_katasandi.TabIndex = 6;
            lbl_katasandi.Text = "Kata Sandi";
            // 
            // tbx_email
            // 
            tbx_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_email.Location = new Point(3, 131);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(416, 34);
            tbx_email.TabIndex = 5;
            // 
            // lbl_email
            // 
            lbl_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(5, 92);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(73, 36);
            lbl_email.TabIndex = 4;
            lbl_email.Text = "Email";
            // 
            // tbx_nowhatsapp
            // 
            tbx_nowhatsapp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_nowhatsapp.Location = new Point(3, 44);
            tbx_nowhatsapp.Name = "tbx_nowhatsapp";
            tbx_nowhatsapp.Size = new Size(416, 34);
            tbx_nowhatsapp.TabIndex = 3;
            // 
            // lbl_nowhatsapp
            // 
            lbl_nowhatsapp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nowhatsapp.AutoSize = true;
            lbl_nowhatsapp.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nowhatsapp.Location = new Point(5, 5);
            lbl_nowhatsapp.Name = "lbl_nowhatsapp";
            lbl_nowhatsapp.Size = new Size(161, 36);
            lbl_nowhatsapp.TabIndex = 2;
            lbl_nowhatsapp.Text = "No. WhatsApp";
            // 
            // lbl_tambahdosen
            // 
            lbl_tambahdosen.AutoSize = true;
            lbl_tambahdosen.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tambahdosen.Location = new Point(12, 24);
            lbl_tambahdosen.Name = "lbl_tambahdosen";
            lbl_tambahdosen.Size = new Size(305, 64);
            lbl_tambahdosen.TabIndex = 2;
            lbl_tambahdosen.Text = "Tambah Dosen";
            lbl_tambahdosen.Click += label2_Click;
            // 
            // TambahDosen
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 558);
            Controls.Add(lbl_tambahdosen);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TambahDosen";
            Text = "Baskom";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TextBox tbx_nama;
        private Label lbl_nama;
        private Label lbl_tambahdosen;
        private TextBox tbx_nip;
        private Label lbl_nip;
        private TextBox tbx_jabatan;
        private TextBox tbx_nidn;
        private Label lbl_jabatan;
        private Label lbl_nidn;
        private TextBox tbx_katasandi;
        private Label lbl_katasandi;
        private TextBox tbx_email;
        private Label lbl_email;
        private TextBox tbx_nowhatsapp;
        private Label lbl_nowhatsapp;
        private Button btn_tambah;
    }
}