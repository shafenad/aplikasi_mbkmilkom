namespace Baskom.View
{
    partial class v_TambahMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_TambahMahasiswa));
            lbl_tambahmahasiswa = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tbx_statusmahasiswa = new TextBox();
            lbl_statusmahasiswa = new Label();
            tbx_tahunmasuk = new TextBox();
            lbl_tahunmasuk = new Label();
            tbx_programstudi = new TextBox();
            lbl_programstudi = new Label();
            tbx_nim = new TextBox();
            lbl_nim = new Label();
            tbx_nama = new TextBox();
            lbl_nama = new Label();
            panel2 = new Panel();
            btn_tambah = new Button();
            tbx_katasandi = new TextBox();
            lbl_katasandi = new Label();
            tbx_email = new TextBox();
            lbl_email = new Label();
            tbx_batch = new TextBox();
            lbl_batch = new Label();
            tbx_nowhatsapp = new TextBox();
            lbl_nowhatsapp = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_tambahmahasiswa
            // 
            lbl_tambahmahasiswa.AutoSize = true;
            lbl_tambahmahasiswa.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tambahmahasiswa.Location = new Point(12, 31);
            lbl_tambahmahasiswa.Name = "lbl_tambahmahasiswa";
            lbl_tambahmahasiswa.Size = new Size(401, 64);
            lbl_tambahmahasiswa.TabIndex = 3;
            lbl_tambahmahasiswa.Text = "Tambah Mahasiswa";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(856, 459);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tbx_statusmahasiswa);
            panel1.Controls.Add(lbl_statusmahasiswa);
            panel1.Controls.Add(tbx_tahunmasuk);
            panel1.Controls.Add(lbl_tahunmasuk);
            panel1.Controls.Add(tbx_programstudi);
            panel1.Controls.Add(lbl_programstudi);
            panel1.Controls.Add(tbx_nim);
            panel1.Controls.Add(lbl_nim);
            panel1.Controls.Add(tbx_nama);
            panel1.Controls.Add(lbl_nama);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 453);
            panel1.TabIndex = 0;
            // 
            // tbx_statusmahasiswa
            // 
            tbx_statusmahasiswa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_statusmahasiswa.Location = new Point(3, 408);
            tbx_statusmahasiswa.Name = "tbx_statusmahasiswa";
            tbx_statusmahasiswa.Size = new Size(416, 34);
            tbx_statusmahasiswa.TabIndex = 11;
            // 
            // lbl_statusmahasiswa
            // 
            lbl_statusmahasiswa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_statusmahasiswa.AutoSize = true;
            lbl_statusmahasiswa.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_statusmahasiswa.Location = new Point(5, 369);
            lbl_statusmahasiswa.Name = "lbl_statusmahasiswa";
            lbl_statusmahasiswa.Size = new Size(204, 36);
            lbl_statusmahasiswa.TabIndex = 10;
            lbl_statusmahasiswa.Text = "Status Mahasiswa";
            // 
            // tbx_tahunmasuk
            // 
            tbx_tahunmasuk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_tahunmasuk.Location = new Point(3, 316);
            tbx_tahunmasuk.Name = "tbx_tahunmasuk";
            tbx_tahunmasuk.Size = new Size(416, 34);
            tbx_tahunmasuk.TabIndex = 9;
            // 
            // lbl_tahunmasuk
            // 
            lbl_tahunmasuk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_tahunmasuk.AutoSize = true;
            lbl_tahunmasuk.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tahunmasuk.Location = new Point(5, 277);
            lbl_tahunmasuk.Name = "lbl_tahunmasuk";
            lbl_tahunmasuk.Size = new Size(153, 36);
            lbl_tahunmasuk.TabIndex = 8;
            lbl_tahunmasuk.Text = "Tahun Masuk";
            // 
            // tbx_programstudi
            // 
            tbx_programstudi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_programstudi.Location = new Point(3, 226);
            tbx_programstudi.Name = "tbx_programstudi";
            tbx_programstudi.Size = new Size(416, 34);
            tbx_programstudi.TabIndex = 7;
            // 
            // lbl_programstudi
            // 
            lbl_programstudi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_programstudi.AutoSize = true;
            lbl_programstudi.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_programstudi.Location = new Point(5, 187);
            lbl_programstudi.Name = "lbl_programstudi";
            lbl_programstudi.Size = new Size(163, 36);
            lbl_programstudi.TabIndex = 6;
            lbl_programstudi.Text = "Program Studi";
            // 
            // tbx_nim
            // 
            tbx_nim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_nim.Location = new Point(3, 135);
            tbx_nim.Name = "tbx_nim";
            tbx_nim.Size = new Size(416, 34);
            tbx_nim.TabIndex = 5;
            // 
            // lbl_nim
            // 
            lbl_nim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nim.AutoSize = true;
            lbl_nim.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nim.Location = new Point(5, 96);
            lbl_nim.Name = "lbl_nim";
            lbl_nim.Size = new Size(54, 36);
            lbl_nim.TabIndex = 4;
            lbl_nim.Text = "NIM";
            // 
            // tbx_nama
            // 
            tbx_nama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_nama.Location = new Point(3, 44);
            tbx_nama.Name = "tbx_nama";
            tbx_nama.Size = new Size(416, 34);
            tbx_nama.TabIndex = 3;
            // 
            // lbl_nama
            // 
            lbl_nama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nama.AutoSize = true;
            lbl_nama.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nama.Location = new Point(5, 5);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(79, 36);
            lbl_nama.TabIndex = 2;
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
            panel2.Controls.Add(tbx_batch);
            panel2.Controls.Add(lbl_batch);
            panel2.Controls.Add(tbx_nowhatsapp);
            panel2.Controls.Add(lbl_nowhatsapp);
            panel2.Location = new Point(431, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 453);
            panel2.TabIndex = 1;
            // 
            // btn_tambah
            // 
            btn_tambah.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_tambah.BackColor = SystemColors.MenuHighlight;
            btn_tambah.BackgroundImageLayout = ImageLayout.None;
            btn_tambah.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambah.ForeColor = Color.White;
            btn_tambah.Location = new Point(314, 408);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(105, 38);
            btn_tambah.TabIndex = 14;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = false;
            // 
            // tbx_katasandi
            // 
            tbx_katasandi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_katasandi.Location = new Point(3, 316);
            tbx_katasandi.Name = "tbx_katasandi";
            tbx_katasandi.Size = new Size(416, 34);
            tbx_katasandi.TabIndex = 11;
            // 
            // lbl_katasandi
            // 
            lbl_katasandi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_katasandi.AutoSize = true;
            lbl_katasandi.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandi.Location = new Point(5, 277);
            lbl_katasandi.Name = "lbl_katasandi";
            lbl_katasandi.Size = new Size(128, 36);
            lbl_katasandi.TabIndex = 10;
            lbl_katasandi.Text = "Kata Sandi";
            // 
            // tbx_email
            // 
            tbx_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_email.Location = new Point(3, 227);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(416, 34);
            tbx_email.TabIndex = 9;
            // 
            // lbl_email
            // 
            lbl_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(5, 188);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(82, 36);
            lbl_email.TabIndex = 8;
            lbl_email.Text = "E-Mail";
            // 
            // tbx_batch
            // 
            tbx_batch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_batch.Location = new Point(3, 135);
            tbx_batch.Name = "tbx_batch";
            tbx_batch.Size = new Size(416, 34);
            tbx_batch.TabIndex = 7;
            // 
            // lbl_batch
            // 
            lbl_batch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_batch.AutoSize = true;
            lbl_batch.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_batch.Location = new Point(5, 96);
            lbl_batch.Name = "lbl_batch";
            lbl_batch.Size = new Size(75, 36);
            lbl_batch.TabIndex = 6;
            lbl_batch.Text = "Batch";
            // 
            // tbx_nowhatsapp
            // 
            tbx_nowhatsapp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_nowhatsapp.Location = new Point(3, 44);
            tbx_nowhatsapp.Name = "tbx_nowhatsapp";
            tbx_nowhatsapp.Size = new Size(416, 34);
            tbx_nowhatsapp.TabIndex = 5;
            // 
            // lbl_nowhatsapp
            // 
            lbl_nowhatsapp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nowhatsapp.AutoSize = true;
            lbl_nowhatsapp.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nowhatsapp.Location = new Point(5, 5);
            lbl_nowhatsapp.Name = "lbl_nowhatsapp";
            lbl_nowhatsapp.Size = new Size(161, 36);
            lbl_nowhatsapp.TabIndex = 4;
            lbl_nowhatsapp.Text = "No. WhatsApp";
            // 
            // TambahMahasiswa
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 558);
            Controls.Add(lbl_tambahmahasiswa);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TambahMahasiswa";
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
        private Label lbl_tambahmahasiswa;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TextBox tbx_statusmahasiswa;
        private Label lbl_statusmahasiswa;
        private TextBox tbx_tahunmasuk;
        private Label lbl_tahunmasuk;
        private TextBox tbx_programstudi;
        private Label lbl_programstudi;
        private TextBox tbx_nim;
        private Label lbl_nim;
        private TextBox tbx_nama;
        private Label lbl_nama;
        private TextBox tbx_katasandi;
        private Label lbl_katasandi;
        private TextBox tbx_email;
        private Label lbl_email;
        private TextBox tbx_batch;
        private Label lbl_batch;
        private TextBox tbx_nowhatsapp;
        private Label lbl_nowhatsapp;
        private Button btn_tambah;
    }
}