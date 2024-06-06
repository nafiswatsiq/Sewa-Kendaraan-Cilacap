namespace Sewa_Kendaraan_Cilacap.view
{
    partial class TambahSewa_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahSewa_Frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.totalBayarLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hapusBtn = new System.Windows.Forms.PictureBox();
            this.tambahBtn = new System.Windows.Forms.PictureBox();
            this.totalHariTxt = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.tanggalSelesaiDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.kendaraanCmb = new System.Windows.Forms.ComboBox();
            this.tanggalMulaiDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SewaGridView = new System.Windows.Forms.DataGridView();
            this.batalBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.noTlpTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alamatPelangganTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.namaPelangganTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hapusBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambahBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SewaGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(987, 693);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.totalBayarLbl);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.SewaGridView);
            this.panel2.Controls.Add(this.batalBtn);
            this.panel2.Controls.Add(this.simpanBtn);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 633);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Grand Total";
            // 
            // totalBayarLbl
            // 
            this.totalBayarLbl.AutoSize = true;
            this.totalBayarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBayarLbl.Location = new System.Drawing.Point(2, 594);
            this.totalBayarLbl.Name = "totalBayarLbl";
            this.totalBayarLbl.Size = new System.Drawing.Size(16, 20);
            this.totalBayarLbl.TabIndex = 48;
            this.totalBayarLbl.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hapusBtn);
            this.groupBox2.Controls.Add(this.tambahBtn);
            this.groupBox2.Controls.Add(this.totalHariTxt);
            this.groupBox2.Controls.Add(this.totalLbl);
            this.groupBox2.Controls.Add(this.tanggalSelesaiDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.kendaraanCmb);
            this.groupBox2.Controls.Add(this.tanggalMulaiDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(471, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 298);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Kendaraan";
            // 
            // hapusBtn
            // 
            this.hapusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hapusBtn.Image = ((System.Drawing.Image)(resources.GetObject("hapusBtn.Image")));
            this.hapusBtn.Location = new System.Drawing.Point(293, 212);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(72, 64);
            this.hapusBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hapusBtn.TabIndex = 49;
            this.hapusBtn.TabStop = false;
            this.hapusBtn.Visible = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tambahBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBtn.Image")));
            this.tambahBtn.Location = new System.Drawing.Point(367, 219);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(54, 50);
            this.tambahBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tambahBtn.TabIndex = 48;
            this.tambahBtn.TabStop = false;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // totalHariTxt
            // 
            this.totalHariTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHariTxt.Location = new System.Drawing.Point(15, 62);
            this.totalHariTxt.MinimumSize = new System.Drawing.Size(0, 28);
            this.totalHariTxt.Name = "totalHariTxt";
            this.totalHariTxt.Size = new System.Drawing.Size(408, 28);
            this.totalHariTxt.TabIndex = 8;
            this.totalHariTxt.TextChanged += new System.EventHandler(this.totalHariTxt_TextChanged);
            this.totalHariTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalHariTxt_KeyPress);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(11, 239);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(16, 20);
            this.totalLbl.TabIndex = 47;
            this.totalLbl.Text = "-";
            // 
            // tanggalSelesaiDate
            // 
            this.tanggalSelesaiDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalSelesaiDate.Location = new System.Drawing.Point(239, 127);
            this.tanggalSelesaiDate.Name = "tanggalSelesaiDate";
            this.tanggalSelesaiDate.Size = new System.Drawing.Size(182, 27);
            this.tanggalSelesaiDate.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Hari";
            // 
            // kendaraanCmb
            // 
            this.kendaraanCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kendaraanCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kendaraanCmb.FormattingEnabled = true;
            this.kendaraanCmb.Location = new System.Drawing.Point(15, 184);
            this.kendaraanCmb.Name = "kendaraanCmb";
            this.kendaraanCmb.Size = new System.Drawing.Size(406, 28);
            this.kendaraanCmb.TabIndex = 0;
            this.kendaraanCmb.SelectedValueChanged += new System.EventHandler(this.kendaraanCmb_SelectedValueChanged);
            // 
            // tanggalMulaiDate
            // 
            this.tanggalMulaiDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalMulaiDate.Location = new System.Drawing.Point(15, 127);
            this.tanggalMulaiDate.Name = "tanggalMulaiDate";
            this.tanggalMulaiDate.Size = new System.Drawing.Size(195, 27);
            this.tanggalMulaiDate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tanggal Mulai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pilih Kendaraan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tanggal Selesai";
            // 
            // SewaGridView
            // 
            this.SewaGridView.AllowUserToAddRows = false;
            this.SewaGridView.AllowUserToDeleteRows = false;
            this.SewaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SewaGridView.Location = new System.Drawing.Point(0, 323);
            this.SewaGridView.Name = "SewaGridView";
            this.SewaGridView.ReadOnly = true;
            this.SewaGridView.RowHeadersWidth = 51;
            this.SewaGridView.RowTemplate.Height = 24;
            this.SewaGridView.Size = new System.Drawing.Size(927, 227);
            this.SewaGridView.TabIndex = 4;
            this.SewaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SewaGridView_CellClick);
            // 
            // batalBtn
            // 
            this.batalBtn.BackColor = System.Drawing.Color.Transparent;
            this.batalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batalBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(63)))), ((int)(((byte)(219)))));
            this.batalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(63)))), ((int)(((byte)(219)))));
            this.batalBtn.Location = new System.Drawing.Point(792, 574);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(135, 41);
            this.batalBtn.TabIndex = 3;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = false;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(63)))), ((int)(((byte)(219)))));
            this.simpanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpanBtn.FlatAppearance.BorderSize = 0;
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.ForeColor = System.Drawing.Color.White;
            this.simpanBtn.Location = new System.Drawing.Point(651, 574);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(135, 41);
            this.simpanBtn.TabIndex = 1;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.noTlpTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.alamatPelangganTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.namaPelangganTxt);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(453, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Pelanggan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nomor Telepon";
            // 
            // noTlpTxt
            // 
            this.noTlpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTlpTxt.Location = new System.Drawing.Point(24, 243);
            this.noTlpTxt.MinimumSize = new System.Drawing.Size(0, 28);
            this.noTlpTxt.Name = "noTlpTxt";
            this.noTlpTxt.Size = new System.Drawing.Size(408, 28);
            this.noTlpTxt.TabIndex = 6;
            this.noTlpTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noTlpTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alamat Pelanggan";
            // 
            // alamatPelangganTxt
            // 
            this.alamatPelangganTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatPelangganTxt.Location = new System.Drawing.Point(24, 127);
            this.alamatPelangganTxt.Multiline = true;
            this.alamatPelangganTxt.Name = "alamatPelangganTxt";
            this.alamatPelangganTxt.Size = new System.Drawing.Size(408, 85);
            this.alamatPelangganTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Pelanggan";
            // 
            // namaPelangganTxt
            // 
            this.namaPelangganTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaPelangganTxt.Location = new System.Drawing.Point(24, 66);
            this.namaPelangganTxt.MinimumSize = new System.Drawing.Size(0, 28);
            this.namaPelangganTxt.Name = "namaPelangganTxt";
            this.namaPelangganTxt.Size = new System.Drawing.Size(408, 28);
            this.namaPelangganTxt.TabIndex = 0;
            // 
            // TambahSewa_Frm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(987, 693);
            this.Controls.Add(this.panel1);
            this.Name = "TambahSewa_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Sewa";
            this.Load += new System.EventHandler(this.TambahSewa_Frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hapusBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambahBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SewaGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox namaPelangganTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alamatPelangganTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox kendaraanCmb;
        private System.Windows.Forms.DateTimePicker tanggalSelesaiDate;
        private System.Windows.Forms.DateTimePicker tanggalMulaiDate;
        private System.Windows.Forms.DataGridView SewaGridView;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noTlpTxt;
        private System.Windows.Forms.TextBox totalHariTxt;
        private System.Windows.Forms.Label totalBayarLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox tambahBtn;
        private System.Windows.Forms.PictureBox hapusBtn;
    }
}