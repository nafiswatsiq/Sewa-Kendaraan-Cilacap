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
            this.hapusBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.simpanBtn.Location = new System.Drawing.Point(775, 262);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(117, 42);
            this.simpanBtn.TabIndex = 30;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // tanggalSelesaiDate
            // 
            this.tanggalSelesaiDate.Location = new System.Drawing.Point(708, 143);
            this.tanggalSelesaiDate.Name = "tanggalSelesaiDate";
            this.tanggalSelesaiDate.Size = new System.Drawing.Size(182, 22);
            this.tanggalSelesaiDate.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total Harga";
            // 
            // tanggalMulaiDate
            // 
            this.tanggalMulaiDate.Location = new System.Drawing.Point(484, 143);
            this.tanggalMulaiDate.Name = "tanggalMulaiDate";
            this.tanggalMulaiDate.Size = new System.Drawing.Size(195, 22);
            this.tanggalMulaiDate.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Pilih Kendaraan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tanggal Selesai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tanggal Mulai";
            // 
            // kendaraanCmb
            // 
            this.kendaraanCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kendaraanCmb.FormattingEnabled = true;
            this.kendaraanCmb.Location = new System.Drawing.Point(484, 204);
            this.kendaraanCmb.Name = "kendaraanCmb";
            this.kendaraanCmb.Size = new System.Drawing.Size(406, 24);
            this.kendaraanCmb.TabIndex = 16;
            this.kendaraanCmb.SelectedIndexChanged += new System.EventHandler(this.kendaraanCmb_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Hari";
            // 
            // totalHariTxt
            // 
            this.totalHariTxt.Location = new System.Drawing.Point(484, 82);
            this.totalHariTxt.Name = "totalHariTxt";
            this.totalHariTxt.Size = new System.Drawing.Size(408, 22);
            this.totalHariTxt.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Alamat Pelanggan";
            // 
            // alamatPelangganTxt
            // 
            this.alamatPelangganTxt.Location = new System.Drawing.Point(34, 143);
            this.alamatPelangganTxt.Multiline = true;
            this.alamatPelangganTxt.Name = "alamatPelangganTxt";
            this.alamatPelangganTxt.Size = new System.Drawing.Size(408, 85);
            this.alamatPelangganTxt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama Pelanggan";
            // 
            // namaPelangganTxt
            // 
            this.namaPelangganTxt.Location = new System.Drawing.Point(34, 82);
            this.namaPelangganTxt.Name = "namaPelangganTxt";
            this.namaPelangganTxt.Size = new System.Drawing.Size(408, 22);
            this.namaPelangganTxt.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalLbl);
            this.groupBox1.Controls.Add(this.hapusBtn);
            this.groupBox1.Controls.Add(this.alamatPelangganTxt);
            this.groupBox1.Controls.Add(this.simpanBtn);
            this.groupBox1.Controls.Add(this.namaPelangganTxt);
            this.groupBox1.Controls.Add(this.tanggalSelesaiDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tanggalMulaiDate);
            this.groupBox1.Controls.Add(this.totalHariTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.kendaraanCmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(42, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 328);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Data Sewa";
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
            this.hapusBtn.Location = new System.Drawing.Point(641, 262);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(117, 42);
            this.hapusBtn.TabIndex = 45;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(32, 262);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(16, 20);
            this.totalLbl.TabIndex = 46;
            this.totalLbl.Text = "-";
            // 
            // EditSewa_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditSewa_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Sewa";
            this.Load += new System.EventHandler(this.EditSewa_Frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}