namespace Sewa_Kendaraan_Cilacap.view
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.SidebarPnl = new System.Windows.Forms.Panel();
            this.SewaBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KeluarBtn = new System.Windows.Forms.Button();
            this.KendaraanBtn = new System.Windows.Forms.Button();
            this.JenisBtn = new System.Windows.Forms.Button();
            this.NavPnl = new System.Windows.Forms.Panel();
            this.ContentPnl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SidebarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarPnl
            // 
            this.SidebarPnl.BackColor = System.Drawing.Color.Black;
            this.SidebarPnl.Controls.Add(this.SewaBtn);
            this.SidebarPnl.Controls.Add(this.pictureBox1);
            this.SidebarPnl.Controls.Add(this.KeluarBtn);
            this.SidebarPnl.Controls.Add(this.KendaraanBtn);
            this.SidebarPnl.Controls.Add(this.JenisBtn);
            this.SidebarPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPnl.Location = new System.Drawing.Point(0, 0);
            this.SidebarPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidebarPnl.Name = "SidebarPnl";
            this.SidebarPnl.Size = new System.Drawing.Size(278, 924);
            this.SidebarPnl.TabIndex = 0;
            // 
            // SewaBtn
            // 
            this.SewaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SewaBtn.FlatAppearance.BorderSize = 0;
            this.SewaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SewaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SewaBtn.ForeColor = System.Drawing.Color.White;
            this.SewaBtn.Location = new System.Drawing.Point(14, 282);
            this.SewaBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SewaBtn.Name = "SewaBtn";
            this.SewaBtn.Size = new System.Drawing.Size(261, 50);
            this.SewaBtn.TabIndex = 6;
            this.SewaBtn.Text = "Sewa";
            this.SewaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SewaBtn.UseVisualStyleBackColor = true;
            this.SewaBtn.Click += new System.EventHandler(this.SewaBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // KeluarBtn
            // 
            this.KeluarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeluarBtn.FlatAppearance.BorderSize = 0;
            this.KeluarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeluarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeluarBtn.ForeColor = System.Drawing.Color.White;
            this.KeluarBtn.Location = new System.Drawing.Point(14, 475);
            this.KeluarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KeluarBtn.Name = "KeluarBtn";
            this.KeluarBtn.Size = new System.Drawing.Size(261, 50);
            this.KeluarBtn.TabIndex = 5;
            this.KeluarBtn.Text = "Keluar";
            this.KeluarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KeluarBtn.UseVisualStyleBackColor = true;
            this.KeluarBtn.Click += new System.EventHandler(this.KeluarBtn_Click);
            // 
            // KendaraanBtn
            // 
            this.KendaraanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KendaraanBtn.FlatAppearance.BorderSize = 0;
            this.KendaraanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KendaraanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KendaraanBtn.ForeColor = System.Drawing.Color.White;
            this.KendaraanBtn.Location = new System.Drawing.Point(14, 225);
            this.KendaraanBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.KendaraanBtn.Name = "KendaraanBtn";
            this.KendaraanBtn.Size = new System.Drawing.Size(264, 50);
            this.KendaraanBtn.TabIndex = 3;
            this.KendaraanBtn.Text = "Kendaraan";
            this.KendaraanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KendaraanBtn.UseVisualStyleBackColor = true;
            this.KendaraanBtn.Click += new System.EventHandler(this.KendaraanBtn_Click);
            // 
            // JenisBtn
            // 
            this.JenisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JenisBtn.FlatAppearance.BorderSize = 0;
            this.JenisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JenisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisBtn.ForeColor = System.Drawing.Color.White;
            this.JenisBtn.Location = new System.Drawing.Point(14, 168);
            this.JenisBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.JenisBtn.Name = "JenisBtn";
            this.JenisBtn.Size = new System.Drawing.Size(261, 50);
            this.JenisBtn.TabIndex = 2;
            this.JenisBtn.Text = "Jenis Kendaraan";
            this.JenisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JenisBtn.UseVisualStyleBackColor = true;
            this.JenisBtn.Click += new System.EventHandler(this.JenisBtn_Click);
            // 
            // NavPnl
            // 
            this.NavPnl.BackColor = System.Drawing.Color.Black;
            this.NavPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPnl.Location = new System.Drawing.Point(278, 0);
            this.NavPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NavPnl.Name = "NavPnl";
            this.NavPnl.Size = new System.Drawing.Size(1146, 134);
            this.NavPnl.TabIndex = 1;
            // 
            // ContentPnl
            // 
            this.ContentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPnl.Location = new System.Drawing.Point(278, 134);
            this.ContentPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContentPnl.Name = "ContentPnl";
            this.ContentPnl.Size = new System.Drawing.Size(1146, 790);
            this.ContentPnl.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 924);
            this.Controls.Add(this.ContentPnl);
            this.Controls.Add(this.NavPnl);
            this.Controls.Add(this.SidebarPnl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard Siperpus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SidebarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPnl;
        private System.Windows.Forms.Panel NavPnl;
        private System.Windows.Forms.Panel ContentPnl;
        private System.Windows.Forms.Button JenisBtn;
        private System.Windows.Forms.Button KeluarBtn;
        private System.Windows.Forms.Button KendaraanBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button SewaBtn;
    }
}