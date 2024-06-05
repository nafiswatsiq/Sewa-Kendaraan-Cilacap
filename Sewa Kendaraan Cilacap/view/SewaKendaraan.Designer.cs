namespace Sewa_Kendaraan_Cilacap.view
{
    partial class SewaKendaraan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tambahSewaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabelSewa = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cariBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelSewa)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 30, 50, 10);
            this.panel2.Size = new System.Drawing.Size(1228, 102);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tambahSewaBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(995, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 62);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // tambahSewaBtn
            // 
            this.tambahSewaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(63)))), ((int)(((byte)(219)))));
            this.tambahSewaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tambahSewaBtn.FlatAppearance.BorderSize = 0;
            this.tambahSewaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahSewaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahSewaBtn.ForeColor = System.Drawing.Color.White;
            this.tambahSewaBtn.Location = new System.Drawing.Point(3, 4);
            this.tambahSewaBtn.Name = "tambahSewaBtn";
            this.tambahSewaBtn.Size = new System.Drawing.Size(176, 55);
            this.tambahSewaBtn.TabIndex = 1;
            this.tambahSewaBtn.Text = "Tambah Sewa";
            this.tambahSewaBtn.UseVisualStyleBackColor = false;
            this.tambahSewaBtn.Click += new System.EventHandler(this.tambahSewaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sewa Kendaraan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50);
            this.panel1.Size = new System.Drawing.Size(1228, 562);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabelSewa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(50, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1128, 406);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tabelSewa
            // 
            this.tabelSewa.AllowUserToAddRows = false;
            this.tabelSewa.AllowUserToDeleteRows = false;
            this.tabelSewa.BackgroundColor = System.Drawing.Color.White;
            this.tabelSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelSewa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.tabelSewa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelSewa.Location = new System.Drawing.Point(0, 0);
            this.tabelSewa.Name = "tabelSewa";
            this.tabelSewa.ReadOnly = true;
            this.tabelSewa.RowHeadersWidth = 51;
            this.tabelSewa.RowTemplate.Height = 24;
            this.tabelSewa.Size = new System.Drawing.Size(1128, 406);
            this.tabelSewa.TabIndex = 0;
            this.tabelSewa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelSewa_CellClick);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "code";
            this.Column10.HeaderText = "Kode";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nama_pelanggan";
            this.Column1.HeaderText = "Nama Pelanggan";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "alamat_pelanggan";
            this.Column2.HeaderText = "Alamat";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "jenis_kendaraan";
            this.Column5.HeaderText = "Jenis Kendaraan";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nama_kendaraan";
            this.Column3.HeaderText = "Nama Kendaraan";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "plat_nomor";
            this.Column4.HeaderText = "Plat Nomor";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "total_hari";
            this.Column6.HeaderText = "Total Hari";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mulai";
            this.Column7.HeaderText = "Tgl Mulai";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "selesai";
            this.Column8.HeaderText = "Tgl Selesai";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "total_harga";
            this.Column9.HeaderText = "Total Harga";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(50, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 56);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.searchTxt);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(928, 56);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // searchTxt
            // 
            this.searchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(0, 0);
            this.searchTxt.MinimumSize = new System.Drawing.Size(4, 35);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(928, 27);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cariBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(928, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 56);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // cariBtn
            // 
            this.cariBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(63)))), ((int)(((byte)(219)))));
            this.cariBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cariBtn.FlatAppearance.BorderSize = 0;
            this.cariBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cariBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariBtn.ForeColor = System.Drawing.Color.White;
            this.cariBtn.Location = new System.Drawing.Point(20, 3);
            this.cariBtn.Name = "cariBtn";
            this.cariBtn.Size = new System.Drawing.Size(176, 39);
            this.cariBtn.TabIndex = 0;
            this.cariBtn.Text = "Cari";
            this.cariBtn.UseVisualStyleBackColor = false;
            this.cariBtn.Click += new System.EventHandler(this.cariBtn_Click);
            // 
            // SewaKendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1228, 664);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "SewaKendaraan";
            this.Text = "SewaKendaraan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SewaKendaraan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelSewa)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tambahSewaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tabelSewa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button cariBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}