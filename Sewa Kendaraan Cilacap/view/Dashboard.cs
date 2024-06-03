using Siperpus.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siperpus.view
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
            Jurusan jurusan = new Jurusan();
            jurusan.TopLevel = false;
            jurusan.AutoScroll = true;

            ContentPnl.Controls.Add(jurusan);
            jurusan.Show();

            WelcomeLbl.Text = "Hallo Selamat Datang " + login.getUserName(userLogin);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = "Tanggal: " + DateTime.Now.ToShortDateString();
        }

        private void JurusanBtn_Click(object sender, EventArgs e)
        {
            Jurusan jurusan = new Jurusan();
            jurusan.TopLevel = false;
            jurusan.AutoScroll = true;

            ContentPnl.Controls.Add(jurusan);
            jurusan.Show();
        }

        private void ProdiBtn_Click(object sender, EventArgs e)
        {
            Prodi prodi = new Prodi();
            prodi.TopLevel = false;
            prodi.AutoScroll = true;

            ContentPnl.Controls.Add(prodi);
            prodi.Show();
        }

        private void KeluarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
