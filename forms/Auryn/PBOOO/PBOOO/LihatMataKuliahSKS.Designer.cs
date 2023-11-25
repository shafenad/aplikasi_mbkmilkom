namespace PBOOO
{
    partial class LihatMataKuliahSKS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatMataKuliahSKS));
            this.lyt_lihatmatakuliah = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_rekomendasimatkul = new System.Windows.Forms.Label();
            this.btn_kembalikonversisks = new System.Windows.Forms.Button();
            this.pnl_carimatkul = new System.Windows.Forms.Panel();
            this.tbl_matkulkonversisks = new System.Windows.Forms.DataGridView();
            this.pnl_rekomendasimatkul = new System.Windows.Forms.Panel();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_carimatkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_matkulkonversisks)).BeginInit();
            this.pnl_rekomendasimatkul.SuspendLayout();
            this.SuspendLayout();
            // 
            // lyt_lihatmatakuliah
            // 
            this.lyt_lihatmatakuliah.ColumnCount = 2;
            this.lyt_lihatmatakuliah.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_lihatmatakuliah.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lyt_lihatmatakuliah.Location = new System.Drawing.Point(39, 42);
            this.lyt_lihatmatakuliah.Name = "lyt_lihatmatakuliah";
            this.lyt_lihatmatakuliah.RowCount = 6;
            this.lyt_lihatmatakuliah.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.90164F));
            this.lyt_lihatmatakuliah.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.09836F));
            this.lyt_lihatmatakuliah.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.lyt_lihatmatakuliah.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.lyt_lihatmatakuliah.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.lyt_lihatmatakuliah.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.lyt_lihatmatakuliah.Size = new System.Drawing.Size(1078, 620);
            this.lyt_lihatmatakuliah.TabIndex = 0;
            // 
            // lbl_rekomendasimatkul
            // 
            this.lbl_rekomendasimatkul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_rekomendasimatkul.AutoSize = true;
            this.lbl_rekomendasimatkul.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rekomendasimatkul.Location = new System.Drawing.Point(158, 0);
            this.lbl_rekomendasimatkul.Name = "lbl_rekomendasimatkul";
            this.lbl_rekomendasimatkul.Size = new System.Drawing.Size(917, 64);
            this.lbl_rekomendasimatkul.TabIndex = 0;
            this.lbl_rekomendasimatkul.Text = "Rekomendasi Mata Kuliah Sesuai Program Mitra";
            this.lbl_rekomendasimatkul.Click += new System.EventHandler(this.lbl_carimatkulkonversisks_Click);
            // 
            // btn_kembalikonversisks
            // 
            this.btn_kembalikonversisks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kembalikonversisks.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembalikonversisks.Location = new System.Drawing.Point(976, 379);
            this.btn_kembalikonversisks.Name = "btn_kembalikonversisks";
            this.btn_kembalikonversisks.Size = new System.Drawing.Size(116, 35);
            this.btn_kembalikonversisks.TabIndex = 3;
            this.btn_kembalikonversisks.Text = "Kembali";
            this.btn_kembalikonversisks.UseVisualStyleBackColor = true;
            this.btn_kembalikonversisks.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnl_carimatkul
            // 
            this.pnl_carimatkul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_carimatkul.Controls.Add(this.tbl_matkulkonversisks);
            this.pnl_carimatkul.Controls.Add(this.btn_kembalikonversisks);
            this.pnl_carimatkul.Location = new System.Drawing.Point(22, 150);
            this.pnl_carimatkul.Name = "pnl_carimatkul";
            this.pnl_carimatkul.Size = new System.Drawing.Size(1095, 414);
            this.pnl_carimatkul.TabIndex = 1;
            // 
            // tbl_matkulkonversisks
            // 
            this.tbl_matkulkonversisks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_matkulkonversisks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_matkulkonversisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_matkulkonversisks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.tbl_matkulkonversisks.Location = new System.Drawing.Point(19, 2);
            this.tbl_matkulkonversisks.Name = "tbl_matkulkonversisks";
            this.tbl_matkulkonversisks.RowHeadersWidth = 82;
            this.tbl_matkulkonversisks.RowTemplate.Height = 33;
            this.tbl_matkulkonversisks.Size = new System.Drawing.Size(1073, 370);
            this.tbl_matkulkonversisks.TabIndex = 0;
            // 
            // pnl_rekomendasimatkul
            // 
            this.pnl_rekomendasimatkul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_rekomendasimatkul.Controls.Add(this.lbl_rekomendasimatkul);
            this.pnl_rekomendasimatkul.Location = new System.Drawing.Point(39, 42);
            this.pnl_rekomendasimatkul.Name = "pnl_rekomendasimatkul";
            this.pnl_rekomendasimatkul.Size = new System.Drawing.Size(1078, 82);
            this.pnl_rekomendasimatkul.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kode Mata Kuliah";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nama Mata Kuliah";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jumlah SKS";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // LihatMataKuliahSKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 666);
            this.Controls.Add(this.pnl_rekomendasimatkul);
            this.Controls.Add(this.pnl_carimatkul);
            this.Controls.Add(this.lyt_lihatmatakuliah);
            this.Font = new System.Drawing.Font("Poppins", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LihatMataKuliahSKS";
            this.Text = "Baskom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_carimatkul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_matkulkonversisks)).EndInit();
            this.pnl_rekomendasimatkul.ResumeLayout(false);
            this.pnl_rekomendasimatkul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lyt_lihatmatakuliah;
        private System.Windows.Forms.Label lbl_rekomendasimatkul;
        private System.Windows.Forms.Panel pnl_carimatkul;
        private System.Windows.Forms.DataGridView tbl_matkulkonversisks;
        private System.Windows.Forms.Button btn_kembalikonversisks;
        private System.Windows.Forms.Panel pnl_rekomendasimatkul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}