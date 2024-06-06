namespace Sewa_Kendaraan_Cilacap.view
{
    partial class EditSewa_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSewa_Frm));
            this.simpanBtn = new System.Windows.Forms.Button();
            this.tanggalSelesaiDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tanggalMulaiDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kendaraanCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalHariTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alamatPelangganTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.namaPelangganTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.noTlpTxt = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridSewa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.totalBayarLbl = new System.Windows.Forms.Label();
            this.tambahKendaraanBtn = new System.Windows.Forms.PictureBox();
            this.ubahKendaraanBtn = new System.Windows.Forms.PictureBox();
            this.hapusKendaraanBtn = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSewa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambahKendaraanBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubahKendaraanBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hapusKendaraanBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(63)))), ((int)(((byte)(219)))));
            this.simpanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpanBtn.FlatAppearance.BorderSize = 0;
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.ForeColor = System.Drawing.Color.White;
            this.simpanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simpanBtn.Location = new System.Drawing.Point(885, 590);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(117, 42);
            this.simpanBtn.TabIndex = 30;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // tanggalSelesaiDate
            // 
            this.tanggalSelesaiDate.Location = new System.Drawing.Point(255, 132);
            this.tanggalSelesaiDate.Name = "tanggalSelesaiDate";
            this.tanggalSelesaiDate.Size = new System.Drawing.Size(182, 22);
            this.tanggalSelesaiDate.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total Harga";
            // 
            // tanggalMulaiDate
            // 
            this.tanggalMulaiDate.Location = new System.Drawing.Point(31, 132);
            this.tanggalMulaiDate.Name = "tanggalMulaiDate";
            this.tanggalMulaiDate.Size = new System.Drawing.Size(195, 22);
            this.tanggalMulaiDate.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Pilih Kendaraan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tanggal Selesai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tanggal Mulai";
            // 
            // kendaraanCmb
            // 
            this.kendaraanCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kendaraanCmb.FormattingEnabled = true;
            this.kendaraanCmb.Location = new System.Drawing.Point(31, 193);
            this.kendaraanCmb.Name = "kendaraanCmb";
            this.kendaraanCmb.Size = new System.Drawing.Size(406, 24);
            this.kendaraanCmb.TabIndex = 16;
            this.kendaraanCmb.SelectedIndexChanged += new System.EventHandler(this.kendaraanCmb_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Hari";
            // 
            // totalHariTxt
            // 
            this.totalHariTxt.Location = new System.Drawing.Point(31, 71);
            this.totalHariTxt.Name = "totalHariTxt";
            this.totalHariTxt.Size = new System.Drawing.Size(408, 22);
            this.totalHariTxt.TabIndex = 21;
            this.totalHariTxt.TextChanged += new System.EventHandler(this.totalHariTxt_TextChanged);
            this.totalHariTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalHariTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Alamat Pelanggan";
            // 
            // alamatPelangganTxt
            // 
            this.alamatPelangganTxt.Location = new System.Drawing.Point(25, 132);
            this.alamatPelangganTxt.Multiline = true;
            this.alamatPelangganTxt.Name = "alamatPelangganTxt";
            this.alamatPelangganTxt.Size = new System.Drawing.Size(408, 85);
            this.alamatPelangganTxt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama Pelanggan";
            // 
            // namaPelangganTxt
            // 
            this.namaPelangganTxt.Location = new System.Drawing.Point(25, 71);
            this.namaPelangganTxt.Name = "namaPelangganTxt";
            this.namaPelangganTxt.Size = new System.Drawing.Size(408, 22);
            this.namaPelangganTxt.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.noTlpTxt);
            this.groupBox1.Controls.Add(this.alamatPelangganTxt);
            this.groupBox1.Controls.Add(this.namaPelangganTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 318);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Data Sewa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nomor Telepon";
            // 
            // noTlpTxt
            // 
            this.noTlpTxt.Location = new System.Drawing.Point(25, 249);
            this.noTlpTxt.MinimumSize = new System.Drawing.Size(4, 28);
            this.noTlpTxt.Name = "noTlpTxt";
            this.noTlpTxt.Size = new System.Drawing.Size(408, 22);
            this.noTlpTxt.TabIndex = 21;
            this.noTlpTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noTlpTxt_KeyPress);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(27, 273);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(16, 20);
            this.totalLbl.TabIndex = 46;
            this.totalLbl.Text = "-";
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hapusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hapusBtn.FlatAppearance.BorderSize = 0;
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.ForeColor = System.Drawing.Color.White;
            this.hapusBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hapusBtn.Location = new System.Drawing.Point(671, 590);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(197, 42);
            this.hapusBtn.TabIndex = 45;
            this.hapusBtn.Text = "Hapus Pelanggan";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hapusKendaraanBtn);
            this.groupBox2.Controls.Add(this.ubahKendaraanBtn);
            this.groupBox2.Controls.Add(this.tambahKendaraanBtn);
            this.groupBox2.Controls.Add(this.totalLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.kendaraanCmb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tanggalSelesaiDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.totalHariTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tanggalMulaiDate);
            this.groupBox2.Location = new System.Drawing.Point(526, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 318);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Kendaraan";
            // 
            // DataGridSewa
            // 
            this.DataGridSewa.AllowUserToAddRows = false;
            this.DataGridSewa.AllowUserToDeleteRows = false;
            this.DataGridSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSewa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DataGridSewa.Location = new System.Drawing.Point(42, 408);
            this.DataGridSewa.Name = "DataGridSewa";
            this.DataGridSewa.ReadOnly = true;
            this.DataGridSewa.RowHeadersWidth = 51;
            this.DataGridSewa.RowTemplate.Height = 24;
            this.DataGridSewa.Size = new System.Drawing.Size(960, 150);
            this.DataGridSewa.TabIndex = 46;
            this.DataGridSewa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSewa_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "code";
            this.Column1.HeaderText = "Kode";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "nama_kendaraan";
            this.Column2.HeaderText = "Nama Kendaraan";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "plat_nomor";
            this.Column3.HeaderText = "Plat Nomor";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "total_hari";
            this.Column4.HeaderText = "Total Hari";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "mulai";
            this.Column5.HeaderText = "Tgl Mulai";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "selesai";
            this.Column6.HeaderText = "Tgl Selesai";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "total_harga";
            this.Column7.HeaderText = "Total Harga";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Grand Total";
            // 
            // totalBayarLbl
            // 
            this.totalBayarLbl.AutoSize = true;
            this.totalBayarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBayarLbl.Location = new System.Drawing.Point(47, 610);
            this.totalBayarLbl.Name = "totalBayarLbl";
            this.totalBayarLbl.Size = new System.Drawing.Size(16, 20);
            this.totalBayarLbl.TabIndex = 50;
            this.totalBayarLbl.Text = "-";
            // 
            // tambahKendaraanBtn
            // 
            this.tambahKendaraanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tambahKendaraanBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahKendaraanBtn.Image")));
            this.tambahKendaraanBtn.Location = new System.Drawing.Point(391, 238);
            this.tambahKendaraanBtn.Name = "tambahKendaraanBtn";
            this.tambahKendaraanBtn.Size = new System.Drawing.Size(58, 63);
            this.tambahKendaraanBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tambahKendaraanBtn.TabIndex = 49;
            this.tambahKendaraanBtn.TabStop = false;
            this.tambahKendaraanBtn.Click += new System.EventHandler(this.tambahKendaraanBtn_Click);
            // 
            // ubahKendaraanBtn
            // 
            this.ubahKendaraanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubahKendaraanBtn.Image = ((System.Drawing.Image)(resources.GetObject("ubahKendaraanBtn.Image")));
            this.ubahKendaraanBtn.Location = new System.Drawing.Point(324, 243);
            this.ubahKendaraanBtn.Name = "ubahKendaraanBtn";
            this.ubahKendaraanBtn.Size = new System.Drawing.Size(66, 55);
            this.ubahKendaraanBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ubahKendaraanBtn.TabIndex = 50;
            this.ubahKendaraanBtn.TabStop = false;
            this.ubahKendaraanBtn.Click += new System.EventHandler(this.UbahKendaraanBtn_Click);
            // 
            // hapusKendaraanBtn
            // 
            this.hapusKendaraanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hapusKendaraanBtn.Image = ((System.Drawing.Image)(resources.GetObject("hapusKendaraanBtn.Image")));
            this.hapusKendaraanBtn.Location = new System.Drawing.Point(260, 238);
            this.hapusKendaraanBtn.Name = "hapusKendaraanBtn";
            this.hapusKendaraanBtn.Size = new System.Drawing.Size(62, 65);
            this.hapusKendaraanBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hapusKendaraanBtn.TabIndex = 51;
            this.hapusKendaraanBtn.TabStop = false;
            this.hapusKendaraanBtn.Click += new System.EventHandler(this.hapusKendaraanBtn_Click);
            // 
            // EditSewa_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 685);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalBayarLbl);
            this.Controls.Add(this.DataGridSewa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditSewa_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Sewa";
            this.Load += new System.EventHandler(this.EditSewa_Frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSewa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambahKendaraanBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubahKendaraanBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hapusKendaraanBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.DateTimePicker tanggalSelesaiDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tanggalMulaiDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kendaraanCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalHariTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alamatPelangganTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaPelangganTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noTlpTxt;
        private System.Windows.Forms.DataGridView DataGridSewa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalBayarLbl;
        private System.Windows.Forms.PictureBox ubahKendaraanBtn;
        private System.Windows.Forms.PictureBox tambahKendaraanBtn;
        private System.Windows.Forms.PictureBox hapusKendaraanBtn;
    }
}