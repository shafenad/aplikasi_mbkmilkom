namespace PBO
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            btn_simpan = new Button();
            btn_lihat2 = new Button();
            btn_lihat1 = new Button();
            btn_lihat = new Button();
            panel1 = new Panel();
            lbl_katasandilama = new Label();
            tbx_konfirmasikatasandibaru = new TextBox();
            lbl_konfirmasikatasandibaru = new Label();
            tbx_katasandibaru = new TextBox();
            lbl_katasandibaru = new Label();
            lbl_katasandilama1 = new Label();
            lbl_ubahkatasandi = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.0350075F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9649925F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(69, 77);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(657, 496);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btn_simpan);
            panel2.Controls.Add(btn_lihat2);
            panel2.Controls.Add(btn_lihat1);
            panel2.Controls.Add(btn_lihat);
            panel2.Location = new Point(404, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 490);
            panel2.TabIndex = 1;
            // 
            // btn_simpan
            // 
            btn_simpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_simpan.BackColor = SystemColors.MenuHighlight;
            btn_simpan.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(144, 443);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(105, 44);
            btn_simpan.TabIndex = 0;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += button2_Click;
            // 
            // btn_lihat2
            // 
            btn_lihat2.Anchor = AnchorStyles.Left;
            btn_lihat2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lihat2.Location = new Point(3, 342);
            btn_lihat2.Name = "btn_lihat2";
            btn_lihat2.Size = new Size(76, 34);
            btn_lihat2.TabIndex = 12;
            btn_lihat2.Text = "Lihat";
            btn_lihat2.UseVisualStyleBackColor = true;
            // 
            // btn_lihat1
            // 
            btn_lihat1.Anchor = AnchorStyles.Left;
            btn_lihat1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lihat1.Location = new Point(3, 247);
            btn_lihat1.Name = "btn_lihat1";
            btn_lihat1.Size = new Size(76, 34);
            btn_lihat1.TabIndex = 11;
            btn_lihat1.Text = "Lihat";
            btn_lihat1.UseVisualStyleBackColor = true;
            btn_lihat1.Click += button3_Click;
            // 
            // btn_lihat
            // 
            btn_lihat.Anchor = AnchorStyles.Left;
            btn_lihat.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lihat.Location = new Point(3, 146);
            btn_lihat.Name = "btn_lihat";
            btn_lihat.Size = new Size(76, 37);
            btn_lihat.TabIndex = 10;
            btn_lihat.Text = "Lihat";
            btn_lihat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lbl_katasandilama);
            panel1.Controls.Add(tbx_konfirmasikatasandibaru);
            panel1.Controls.Add(lbl_konfirmasikatasandibaru);
            panel1.Controls.Add(tbx_katasandibaru);
            panel1.Controls.Add(lbl_katasandibaru);
            panel1.Controls.Add(lbl_katasandilama1);
            panel1.Controls.Add(lbl_ubahkatasandi);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 490);
            panel1.TabIndex = 0;
            // 
            // lbl_katasandilama
            // 
            lbl_katasandilama.Anchor = AnchorStyles.Right;
            lbl_katasandilama.AutoSize = true;
            lbl_katasandilama.Location = new Point(3, 149);
            lbl_katasandilama.Name = "lbl_katasandilama";
            lbl_katasandilama.Size = new Size(131, 31);
            lbl_katasandilama.TabIndex = 7;
            lbl_katasandilama.Text = "*************";
            // 
            // tbx_konfirmasikatasandibaru
            // 
            tbx_konfirmasikatasandibaru.Anchor = AnchorStyles.Right;
            tbx_konfirmasikatasandibaru.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_konfirmasikatasandibaru.Location = new Point(4, 342);
            tbx_konfirmasikatasandibaru.Name = "tbx_konfirmasikatasandibaru";
            tbx_konfirmasikatasandibaru.Size = new Size(376, 34);
            tbx_konfirmasikatasandibaru.TabIndex = 6;
            // 
            // lbl_konfirmasikatasandibaru
            // 
            lbl_konfirmasikatasandibaru.Anchor = AnchorStyles.Right;
            lbl_konfirmasikatasandibaru.AutoSize = true;
            lbl_konfirmasikatasandibaru.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_konfirmasikatasandibaru.Location = new Point(3, 303);
            lbl_konfirmasikatasandibaru.Name = "lbl_konfirmasikatasandibaru";
            lbl_konfirmasikatasandibaru.Size = new Size(298, 36);
            lbl_konfirmasikatasandibaru.TabIndex = 5;
            lbl_konfirmasikatasandibaru.Text = "Konfirmasi Kata Sandi Baru";
            // 
            // tbx_katasandibaru
            // 
            tbx_katasandibaru.Anchor = AnchorStyles.Right;
            tbx_katasandibaru.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_katasandibaru.Location = new Point(3, 247);
            tbx_katasandibaru.Name = "tbx_katasandibaru";
            tbx_katasandibaru.Size = new Size(377, 34);
            tbx_katasandibaru.TabIndex = 4;
            // 
            // lbl_katasandibaru
            // 
            lbl_katasandibaru.Anchor = AnchorStyles.Right;
            lbl_katasandibaru.AutoSize = true;
            lbl_katasandibaru.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandibaru.Location = new Point(3, 208);
            lbl_katasandibaru.Name = "lbl_katasandibaru";
            lbl_katasandibaru.Size = new Size(181, 36);
            lbl_katasandibaru.TabIndex = 3;
            lbl_katasandibaru.Text = "Kata Sandi Baru";
            // 
            // lbl_katasandilama1
            // 
            lbl_katasandilama1.Anchor = AnchorStyles.Right;
            lbl_katasandilama1.AutoSize = true;
            lbl_katasandilama1.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandilama1.Location = new Point(3, 110);
            lbl_katasandilama1.Name = "lbl_katasandilama1";
            lbl_katasandilama1.Size = new Size(191, 36);
            lbl_katasandilama1.TabIndex = 2;
            lbl_katasandilama1.Text = "Kata Sandi Lama";
            // 
            // lbl_ubahkatasandi
            // 
            lbl_ubahkatasandi.Anchor = AnchorStyles.Right;
            lbl_ubahkatasandi.AutoSize = true;
            lbl_ubahkatasandi.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ubahkatasandi.Location = new Point(62, 3);
            lbl_ubahkatasandi.Name = "lbl_ubahkatasandi";
            lbl_ubahkatasandi.Size = new Size(333, 64);
            lbl_ubahkatasandi.TabIndex = 0;
            lbl_ubahkatasandi.Text = "Ubah Kata Sandi";
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(11F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Profil";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form4_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_ubahkatasandi;
        private Label lbl_katasandibaru;
        private Label lbl_katasandilama1;
        private Label lbl_konfirmasikatasandibaru;
        private Button btn_lihat1;
        private Button btn_lihat;
        private Button btn_lihat2;
        private Button btn_simpan;
        private TextBox tbx_konfirmasikatasandibaru;
        private TextBox tbx_katasandibaru;
        private Label lbl_katasandilama;
    }
}