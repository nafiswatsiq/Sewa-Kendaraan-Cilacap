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
            this.KeluarBtn = new System.Windows.Forms.Button();
            this.ProdiBtn = new System.Windows.Forms.Button();
            this.JurusanBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NavPnl = new System.Windows.Forms.Panel();
            this.DateLbl = new System.Windows.Forms.Label();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.ContentPnl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SidebarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NavPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarPnl
            // 
            this.SidebarPnl.BackColor = System.Drawing.Color.RoyalBlue;
            this.SidebarPnl.Controls.Add(this.KeluarBtn);
            this.SidebarPnl.Controls.Add(this.ProdiBtn);
            this.SidebarPnl.Controls.Add(this.JurusanBtn);
            this.SidebarPnl.Controls.Add(this.label1);
            this.SidebarPnl.Controls.Add(this.pictureBox1);
            this.SidebarPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPnl.Location = new System.Drawing.Point(0, 0);
            this.SidebarPnl.Name = "SidebarPnl";
            this.SidebarPnl.Size = new System.Drawing.Size(247, 739);
            this.SidebarPnl.TabIndex = 0;
            // 
            // KeluarBtn
            // 
            this.KeluarBtn.FlatAppearance.BorderSize = 0;
            this.KeluarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeluarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeluarBtn.ForeColor = System.Drawing.Color.White;
            this.KeluarBtn.Location = new System.Drawing.Point(3, 226);
            this.KeluarBtn.Name = "KeluarBtn";
            this.KeluarBtn.Size = new System.Drawing.Size(241, 40);
            this.KeluarBtn.TabIndex = 5;
            this.KeluarBtn.Text = "Keluar";
            this.KeluarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KeluarBtn.UseVisualStyleBackColor = true;
            this.KeluarBtn.Click += new System.EventHandler(this.KeluarBtn_Click);
            // 
            // ProdiBtn
            // 
            this.ProdiBtn.FlatAppearance.BorderSize = 0;
            this.ProdiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdiBtn.ForeColor = System.Drawing.Color.White;
            this.ProdiBtn.Location = new System.Drawing.Point(0, 180);
            this.ProdiBtn.Name = "ProdiBtn";
            this.ProdiBtn.Size = new System.Drawing.Size(241, 40);
            this.ProdiBtn.TabIndex = 3;
            this.ProdiBtn.Text = "Prodi";
            this.ProdiBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProdiBtn.UseVisualStyleBackColor = true;
            this.ProdiBtn.Click += new System.EventHandler(this.ProdiBtn_Click);
            // 
            // JurusanBtn
            // 
            this.JurusanBtn.FlatAppearance.BorderSize = 0;
            this.JurusanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JurusanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JurusanBtn.ForeColor = System.Drawing.Color.White;
            this.JurusanBtn.Location = new System.Drawing.Point(3, 134);
            this.JurusanBtn.Name = "JurusanBtn";
            this.JurusanBtn.Size = new System.Drawing.Size(241, 40);
            this.JurusanBtn.TabIndex = 2;
            this.JurusanBtn.Text = "Jurusan";
            this.JurusanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JurusanBtn.UseVisualStyleBackColor = true;
            this.JurusanBtn.Click += new System.EventHandler(this.JurusanBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIPERPUS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NavPnl
            // 
            this.NavPnl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.NavPnl.Controls.Add(this.DateLbl);
            this.NavPnl.Controls.Add(this.WelcomeLbl);
            this.NavPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPnl.Location = new System.Drawing.Point(247, 0);
            this.NavPnl.Name = "NavPnl";
            this.NavPnl.Size = new System.Drawing.Size(1019, 127);
            this.NavPnl.TabIndex = 1;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.ForeColor = System.Drawing.Color.White;
            this.DateLbl.Location = new System.Drawing.Point(23, 84);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(71, 16);
            this.DateLbl.TabIndex = 1;
            this.DateLbl.Text = "00/00/0000";
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.ForeColor = System.Drawing.Color.White;
            this.WelcomeLbl.Location = new System.Drawing.Point(22, 30);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(218, 20);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Halo Selamat Datang Nama";
            // 
            // ContentPnl
            // 
            this.ContentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPnl.Location = new System.Drawing.Point(247, 127);
            this.ContentPnl.Name = "ContentPnl";
            this.ContentPnl.Size = new System.Drawing.Size(1019, 612);
            this.ContentPnl.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 739);
            this.Controls.Add(this.ContentPnl);
            this.Controls.Add(this.NavPnl);
            this.Controls.Add(this.SidebarPnl);
            this.Name = "Dashboard";
            this.Text = "Dashboard Siperpus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SidebarPnl.ResumeLayout(false);
            this.SidebarPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NavPnl.ResumeLayout(false);
            this.NavPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPnl;
        private System.Windows.Forms.Panel NavPnl;
        private System.Windows.Forms.Panel ContentPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button JurusanBtn;
        private System.Windows.Forms.Button KeluarBtn;
        private System.Windows.Forms.Button ProdiBtn;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Timer timer1;
    }
}