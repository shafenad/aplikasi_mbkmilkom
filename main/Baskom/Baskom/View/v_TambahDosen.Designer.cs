namespace Baskom.View
{
    partial class v_TambahDosen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_TambahDosen));
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            tbx_jabatantambahdosen = new TextBox();
            label4 = new Label();
            tbx_nidntambahdosen = new TextBox();
            label3 = new Label();
            tbx_niptambahdosen = new TextBox();
            label2 = new Label();
            tbx_namatambahdosen = new TextBox();
            panel2 = new Panel();
            btn_tambahtambahdosen = new Button();
            label8 = new Label();
            tbx_katasanditambahdosen = new TextBox();
            label9 = new Label();
            tbx_emailtambahdosen = new TextBox();
            label10 = new Label();
            tbx_nowatambahdosen = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbx_jabatantambahdosen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbx_nidntambahdosen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbx_niptambahdosen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbx_namatambahdosen);
            panel1.Location = new Point(135, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 937);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 62);
            label1.Name = "label1";
            label1.Size = new Size(255, 53);
            label1.TabIndex = 9;
            label1.Text = "Tambah Dosen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 490);
            label5.Name = "label5";
            label5.Size = new Size(75, 26);
            label5.TabIndex = 7;
            label5.Text = "Jabatan";
            label5.Click += label5_Click_1;
            // 
            // tbx_jabatantambahdosen
            // 
            tbx_jabatantambahdosen.Location = new Point(3, 523);
            tbx_jabatantambahdosen.Multiline = true;
            tbx_jabatantambahdosen.Name = "tbx_jabatantambahdosen";
            tbx_jabatantambahdosen.Size = new Size(637, 42);
            tbx_jabatantambahdosen.TabIndex = 6;
            tbx_jabatantambahdosen.TextChanged += textBox4_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 391);
            label4.Name = "label4";
            label4.Size = new Size(49, 26);
            label4.TabIndex = 5;
            label4.Text = "NIDN";
            label4.Click += label4_Click_1;
            // 
            // tbx_nidntambahdosen
            // 
            tbx_nidntambahdosen.Location = new Point(3, 424);
            tbx_nidntambahdosen.Multiline = true;
            tbx_nidntambahdosen.Name = "tbx_nidntambahdosen";
            tbx_nidntambahdosen.Size = new Size(637, 42);
            tbx_nidntambahdosen.TabIndex = 4;
            tbx_nidntambahdosen.TextChanged += textBox3_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 292);
            label3.Name = "label3";
            label3.Size = new Size(36, 26);
            label3.TabIndex = 3;
            label3.Text = "NIP";
            label3.Click += label3_Click;
            // 
            // tbx_niptambahdosen
            // 
            tbx_niptambahdosen.Location = new Point(3, 325);
            tbx_niptambahdosen.Multiline = true;
            tbx_niptambahdosen.Name = "tbx_niptambahdosen";
            tbx_niptambahdosen.Size = new Size(637, 42);
            tbx_niptambahdosen.TabIndex = 2;
            tbx_niptambahdosen.TextChanged += textBox2_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 197);
            label2.Name = "label2";
            label2.Size = new Size(58, 26);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            label2.Click += label2_Click;
            // 
            // tbx_namatambahdosen
            // 
            tbx_namatambahdosen.Location = new Point(3, 230);
            tbx_namatambahdosen.Multiline = true;
            tbx_namatambahdosen.Name = "tbx_namatambahdosen";
            tbx_namatambahdosen.Size = new Size(637, 42);
            tbx_namatambahdosen.TabIndex = 0;
            tbx_namatambahdosen.TextChanged += textBox1_TextChanged_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(btn_tambahtambahdosen);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tbx_katasanditambahdosen);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(tbx_emailtambahdosen);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(tbx_nowatambahdosen);
            panel2.Location = new Point(829, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1258, 937);
            panel2.TabIndex = 1;
            // 
            // btn_tambahtambahdosen
            // 
            btn_tambahtambahdosen.BackColor = SystemColors.Highlight;
            btn_tambahtambahdosen.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambahtambahdosen.ForeColor = SystemColors.HighlightText;
            btn_tambahtambahdosen.Location = new Point(563, 523);
            btn_tambahtambahdosen.Name = "btn_tambahtambahdosen";
            btn_tambahtambahdosen.Size = new Size(125, 42);
            btn_tambahtambahdosen.TabIndex = 6;
            btn_tambahtambahdosen.Text = "Tambah";
            btn_tambahtambahdosen.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(51, 391);
            label8.Name = "label8";
            label8.Size = new Size(93, 26);
            label8.TabIndex = 5;
            label8.Text = "Kata Sandi";
            label8.Click += label8_Click;
            // 
            // tbx_katasanditambahdosen
            // 
            tbx_katasanditambahdosen.Location = new Point(51, 424);
            tbx_katasanditambahdosen.Multiline = true;
            tbx_katasanditambahdosen.Name = "tbx_katasanditambahdosen";
            tbx_katasanditambahdosen.Size = new Size(637, 42);
            tbx_katasanditambahdosen.TabIndex = 4;
            tbx_katasanditambahdosen.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(51, 292);
            label9.Name = "label9";
            label9.Size = new Size(61, 26);
            label9.TabIndex = 3;
            label9.Text = "E-mail";
            label9.Click += label9_Click;
            // 
            // tbx_emailtambahdosen
            // 
            tbx_emailtambahdosen.Location = new Point(51, 325);
            tbx_emailtambahdosen.Multiline = true;
            tbx_emailtambahdosen.Name = "tbx_emailtambahdosen";
            tbx_emailtambahdosen.Size = new Size(637, 42);
            tbx_emailtambahdosen.TabIndex = 2;
            tbx_emailtambahdosen.TextChanged += textBox7_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(51, 197);
            label10.Name = "label10";
            label10.Size = new Size(146, 26);
            label10.TabIndex = 1;
            label10.Text = "Nomor WhatsApp";
            label10.Click += label10_Click;
            // 
            // tbx_nowatambahdosen
            // 
            tbx_nowatambahdosen.Location = new Point(51, 230);
            tbx_nowatambahdosen.Multiline = true;
            tbx_nowatambahdosen.Name = "tbx_nowatambahdosen";
            tbx_nowatambahdosen.Size = new Size(637, 42);
            tbx_nowatambahdosen.TabIndex = 0;
            tbx_nowatambahdosen.TextChanged += textBox8_TextChanged;
            // 
            // tambahdosen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 937);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "tambahdosen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += daftardosen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbx_namatambahdosen;
        private Label label3;
        private TextBox tbx_niptambahdosen;
        private Label label2;
        private Label label5;
        private TextBox tbx_jabatantambahdosen;
        private Label label4;
        private TextBox tbx_nidntambahdosen;
        private Panel panel2;
        private Label label8;
        private TextBox tbx_katasanditambahdosen;
        private Label label9;
        private TextBox tbx_emailtambahdosen;
        private Label label10;
        private TextBox tbx_nowatambahdosen;
        private Label label1;
        private Button btn_tambahtambahdosen;
    }
}