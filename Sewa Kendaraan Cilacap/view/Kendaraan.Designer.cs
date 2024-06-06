namespace Sewa_Kendaraan_Cilacap.view
{
    partial class Kendaraan
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.JenisCmb = new System.Windows.Forms.ComboBox();
            this.BatalBtn = new System.Windows.Forms.Button();
            this.HapusBtn = new System.Windows.Forms.Button();
            this.UbahBtn = new System.Windows.Forms.Button();
            this.SimpanBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NamaTxt = new System.Windows.Forms.TextBox();
            this.DataGridKendaraan = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plat_nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HargaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlatTxt = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridKendaraan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(0, 18);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(648, 27);
            this.SearchBox.TabIndex = 15;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SearchBtn);
            this.panel3.Controls.Add(this.SearchBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(51, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 60);
            this.panel3.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(653, 18);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 27);
            this.SearchBtn.TabIndex = 16;
            this.SearchBtn.Text = "Cari";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Jenis Kendaraan";
            // 
            // JenisCmb
            // 
            this.JenisCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JenisCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisCmb.FormattingEnabled = true;
            this.JenisCmb.Location = new System.Drawing.Point(165, 135);
            this.JenisCmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JenisCmb.Name = "JenisCmb";
            this.JenisCmb.Size = new System.Drawing.Size(399, 28);
            this.JenisCmb.TabIndex = 26;
            // 
            // BatalBtn
            // 
            this.BatalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatalBtn.Location = new System.Drawing.Point(467, 287);
            this.BatalBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatalBtn.Name = "BatalBtn";
            this.BatalBtn.Size = new System.Drawing.Size(99, 32);
            this.BatalBtn.TabIndex = 25;
            this.BatalBtn.Text = "Batal";
            this.BatalBtn.UseVisualStyleBackColor = true;
            this.BatalBtn.Click += new System.EventHandler(this.BatalBtn_Click);
            // 
            // HapusBtn
            // 
            this.HapusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HapusBtn.Location = new System.Drawing.Point(360, 287);
            this.HapusBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HapusBtn.Name = "HapusBtn";
            this.HapusBtn.Size = new System.Drawing.Size(100, 32);
            this.HapusBtn.TabIndex = 24;
            this.HapusBtn.Text = "Hapus";
            this.HapusBtn.UseVisualStyleBackColor = true;
            this.HapusBtn.Click += new System.EventHandler(this.HapusBtn_Click);
            // 
            // UbahBtn
            // 
            this.UbahBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UbahBtn.Location = new System.Drawing.Point(261, 287);
            this.UbahBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UbahBtn.Name = "UbahBtn";
            this.UbahBtn.Size = new System.Drawing.Size(93, 32);
            this.UbahBtn.TabIndex = 23;
            this.UbahBtn.Text = "Ubah";
            this.UbahBtn.UseVisualStyleBackColor = true;
            this.UbahBtn.Click += new System.EventHandler(this.UbahBtn_Click);
            // 
            // SimpanBtn
            // 
            this.SimpanBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SimpanBtn.FlatAppearance.BorderSize = 0;
            this.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimpanBtn.ForeColor = System.Drawing.Color.White;
            this.SimpanBtn.Location = new System.Drawing.Point(165, 287);
            this.SimpanBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SimpanBtn.Name = "SimpanBtn";
            this.SimpanBtn.Size = new System.Drawing.Size(89, 32);
            this.SimpanBtn.TabIndex = 22;
            this.SimpanBtn.Text = "Simpan";
            this.SimpanBtn.UseVisualStyleBackColor = false;
            this.SimpanBtn.Click += new System.EventHandler(this.SimpanBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama Kendaraan";
            // 
            // NamaTxt
            // 
            this.NamaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaTxt.Location = new System.Drawing.Point(165, 85);
            this.NamaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamaTxt.Name = "NamaTxt";
            this.NamaTxt.Size = new System.Drawing.Size(399, 27);
            this.NamaTxt.TabIndex = 20;
            // 
            // DataGridKendaraan
            // 
            this.DataGridKendaraan.AllowUserToAddRows = false;
            this.DataGridKendaraan.AllowUserToDeleteRows = false;
            this.DataGridKendaraan.BackgroundColor = System.Drawing.Color.White;
            this.DataGridKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridKendaraan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama,
            this.jenis_id,
            this.plat_nomor,
            this.harga});
            this.DataGridKendaraan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridKendaraan.Location = new System.Drawing.Point(0, 0);
            this.DataGridKendaraan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridKendaraan.Name = "DataGridKendaraan";
            this.DataGridKendaraan.ReadOnly = true;
            this.DataGridKendaraan.RowHeadersWidth = 51;
            this.DataGridKendaraan.RowTemplate.Height = 24;
            this.DataGridKendaraan.Size = new System.Drawing.Size(965, 210);
            this.DataGridKendaraan.TabIndex = 0;
            this.DataGridKendaraan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridKendaraan_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id Kendaraan";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 107;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama Kendaraan";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // jenis_id
            // 
            this.jenis_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jenis_id.DataPropertyName = "jenis_id";
            this.jenis_id.HeaderText = "Jenis Kendaraan";
            this.jenis_id.MinimumWidth = 6;
            this.jenis_id.Name = "jenis_id";
            this.jenis_id.ReadOnly = true;
            // 
            // plat_nomor
            // 
            this.plat_nomor.DataPropertyName = "plat_nomor";
            this.plat_nomor.HeaderText = "Plat Nomor";
            this.plat_nomor.MinimumWidth = 6;
            this.plat_nomor.Name = "plat_nomor";
            this.plat_nomor.ReadOnly = true;
            this.plat_nomor.Width = 125;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            this.harga.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id Kendaraan";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(51, 0, 51, 30);
            this.panel2.Size = new System.Drawing.Size(1067, 300);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DataGridKendaraan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(51, 60);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 210);
            this.panel4.TabIndex = 1;
            // 
            // IdTxt
            // 
            this.IdTxt.Enabled = false;
            this.IdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.Location = new System.Drawing.Point(165, 41);
            this.IdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(399, 27);
            this.IdTxt.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(51, 20, 51, 20);
            this.panel1.Size = new System.Drawing.Size(1067, 388);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.HargaTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PlatTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.JenisCmb);
            this.groupBox1.Controls.Add(this.BatalBtn);
            this.groupBox1.Controls.Add(this.HapusBtn);
            this.groupBox1.Controls.Add(this.UbahBtn);
            this.groupBox1.Controls.Add(this.SimpanBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NamaTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IdTxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(51, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(648, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Kendaraan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Harga";
            // 
            // HargaTxt
            // 
            this.HargaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HargaTxt.Location = new System.Drawing.Point(165, 226);
            this.HargaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HargaTxt.Name = "HargaTxt";
            this.HargaTxt.Size = new System.Drawing.Size(399, 27);
            this.HargaTxt.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Plat Nomor";
            // 
            // PlatTxt
            // 
            this.PlatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatTxt.Location = new System.Drawing.Point(165, 183);
            this.PlatTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlatTxt.Name = "PlatTxt";
            this.PlatTxt.Size = new System.Drawing.Size(399, 27);
            this.PlatTxt.TabIndex = 28;
            // 
            // Kendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kendaraan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kendaraan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kendaraan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridKendaraan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox JenisCmb;
        private System.Windows.Forms.Button BatalBtn;
        private System.Windows.Forms.Button HapusBtn;
        private System.Windows.Forms.Button UbahBtn;
        private System.Windows.Forms.Button SimpanBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NamaTxt;
        private System.Windows.Forms.DataGridView DataGridKendaraan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HargaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlatTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plat_nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
    }
}