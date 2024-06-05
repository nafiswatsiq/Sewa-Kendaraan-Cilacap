namespace Sewa_Kendaraan_Cilacap.view
{
    partial class Jenis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BatalBtn = new System.Windows.Forms.Button();
            this.HapusBtn = new System.Windows.Forms.Button();
            this.UbahBtn = new System.Windows.Forms.Button();
            this.SimpanBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NamaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridJenis = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cetak = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJenis)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.panel1.Size = new System.Drawing.Size(1282, 232);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BatalBtn);
            this.groupBox1.Controls.Add(this.HapusBtn);
            this.groupBox1.Controls.Add(this.UbahBtn);
            this.groupBox1.Controls.Add(this.SimpanBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NamaTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IdTxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(50, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Kendaraan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BatalBtn
            // 
            this.BatalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatalBtn.Location = new System.Drawing.Point(480, 140);
            this.BatalBtn.Name = "BatalBtn";
            this.BatalBtn.Size = new System.Drawing.Size(99, 29);
            this.BatalBtn.TabIndex = 17;
            this.BatalBtn.Text = "Batal";
            this.BatalBtn.UseVisualStyleBackColor = true;
            this.BatalBtn.Click += new System.EventHandler(this.BatalBtn_Click);
            // 
            // HapusBtn
            // 
            this.HapusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HapusBtn.Location = new System.Drawing.Point(374, 140);
            this.HapusBtn.Name = "HapusBtn";
            this.HapusBtn.Size = new System.Drawing.Size(100, 29);
            this.HapusBtn.TabIndex = 16;
            this.HapusBtn.Text = "Hapus";
            this.HapusBtn.UseVisualStyleBackColor = true;
            this.HapusBtn.Click += new System.EventHandler(this.HapusBtn_Click);
            // 
            // UbahBtn
            // 
            this.UbahBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UbahBtn.Location = new System.Drawing.Point(275, 140);
            this.UbahBtn.Name = "UbahBtn";
            this.UbahBtn.Size = new System.Drawing.Size(93, 29);
            this.UbahBtn.TabIndex = 15;
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
            this.SimpanBtn.Location = new System.Drawing.Point(180, 140);
            this.SimpanBtn.Name = "SimpanBtn";
            this.SimpanBtn.Size = new System.Drawing.Size(89, 29);
            this.SimpanBtn.TabIndex = 14;
            this.SimpanBtn.Text = "Simpan";
            this.SimpanBtn.UseVisualStyleBackColor = false;
            this.SimpanBtn.Click += new System.EventHandler(this.SimpanBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jenis Kendaraan";
            // 
            // NamaTxt
            // 
            this.NamaTxt.Location = new System.Drawing.Point(180, 96);
            this.NamaTxt.Name = "NamaTxt";
            this.NamaTxt.Size = new System.Drawing.Size(399, 22);
            this.NamaTxt.TabIndex = 12;
            this.NamaTxt.TextChanged += new System.EventHandler(this.NamaTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id Jenis";
            // 
            // IdTxt
            // 
            this.IdTxt.Enabled = false;
            this.IdTxt.Location = new System.Drawing.Point(180, 52);
            this.IdTxt.MinimumSize = new System.Drawing.Size(4, 10);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(399, 22);
            this.IdTxt.TabIndex = 10;
            this.IdTxt.TextChanged += new System.EventHandler(this.IdTxt_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 232);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this.panel2.Size = new System.Drawing.Size(1282, 481);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DataGridJenis);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(50, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 390);
            this.panel4.TabIndex = 13;
            // 
            // DataGridJenis
            // 
            this.DataGridJenis.AllowUserToAddRows = false;
            this.DataGridJenis.AllowUserToDeleteRows = false;
            this.DataGridJenis.BackgroundColor = System.Drawing.Color.White;
            this.DataGridJenis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridJenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridJenis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama});
            this.DataGridJenis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridJenis.Location = new System.Drawing.Point(0, 0);
            this.DataGridJenis.Name = "DataGridJenis";
            this.DataGridJenis.ReadOnly = true;
            this.DataGridJenis.RowHeadersWidth = 51;
            this.DataGridJenis.RowTemplate.Height = 24;
            this.DataGridJenis.Size = new System.Drawing.Size(1182, 390);
            this.DataGridJenis.TabIndex = 11;
            this.DataGridJenis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridJurusan_CellClick);
            this.DataGridJenis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridJurusan_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id Jenis";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Jenis Kendaraan";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cetak);
            this.panel3.Controls.Add(this.SearchBtn);
            this.panel3.Controls.Add(this.SearchBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(50, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 61);
            this.panel3.TabIndex = 12;
            // 
            // cetak
            // 
            this.cetak.BackColor = System.Drawing.Color.RoyalBlue;
            this.cetak.FlatAppearance.BorderSize = 0;
            this.cetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cetak.ForeColor = System.Drawing.Color.White;
            this.cetak.Location = new System.Drawing.Point(754, 20);
            this.cetak.Name = "cetak";
            this.cetak.Size = new System.Drawing.Size(72, 23);
            this.cetak.TabIndex = 18;
            this.cetak.Text = "Cetak";
            this.cetak.UseVisualStyleBackColor = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(653, 20);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 14;
            this.SearchBtn.Text = "Cari";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(0, 20);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(647, 22);
            this.SearchBox.TabIndex = 13;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // Jenis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jenis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jurusan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Jenis_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridJenis)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BatalBtn;
        private System.Windows.Forms.Button HapusBtn;
        private System.Windows.Forms.Button UbahBtn;
        private System.Windows.Forms.Button SimpanBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NamaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DataGridJenis;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.Button cetak;
    }
}