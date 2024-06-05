using Sewa_Kendaraan_Cilacap.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sewa_Kendaraan_Cilacap.view
{
    public partial class Dashboard : Form
    {
        string userLogin;
        LoginCls login = new LoginCls();

        public Dashboard(string username)
        {
            userLogin = username;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Jenis jenisKendaraan = new Jenis();
            jenisKendaraan.TopLevel = false;
            jenisKendaraan.AutoScroll = true;

            ContentPnl.Controls.Add(jenisKendaraan);
            jenisKendaraan.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void KeluarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SewaBtn_Click(object sender, EventArgs e)
        {
            JenisBtn.BackColor = Color.FromArgb(0, 0, 0);
            KendaraanBtn.BackColor = Color.FromArgb(0, 0, 0);
            SewaBtn.BackColor = Color.FromArgb(10, 63, 219);

            SewaKendaraan sewaKendaraan = new SewaKendaraan();
            sewaKendaraan.TopLevel = false;
            sewaKendaraan.AutoScroll = true;

            ContentPnl.Controls.Add(sewaKendaraan);
            sewaKendaraan.Show();
        }

        private void JenisBtn_Click(object sender, EventArgs e)
        {
            SewaBtn.BackColor = Color.FromArgb(0, 0, 0);
            KendaraanBtn.BackColor = Color.FromArgb(0, 0, 0);
            JenisBtn.BackColor = Color.FromArgb(10, 63, 219);

            Jenis jenisKendaraan = new Jenis();
            jenisKendaraan.TopLevel = false;
            jenisKendaraan.AutoScroll = true;

            ContentPnl.Controls.Add(jenisKendaraan);
            jenisKendaraan.Show();
        }

        private void KendaraanBtn_Click(object sender, EventArgs e)
        {
            SewaBtn.BackColor = Color.FromArgb(0, 0, 0);
            JenisBtn.BackColor = Color.FromArgb(0, 0, 0);
            KendaraanBtn.BackColor = Color.FromArgb(10, 63, 219);

            Kendaraan kendaraan = new Kendaraan();
            kendaraan.TopLevel = false;
            kendaraan.AutoScroll = true;

            ContentPnl.Controls.Add(kendaraan);
            kendaraan.Show();
        }
    }
}
