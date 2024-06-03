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
    public partial class Login : Form
    {
        LoginCls login = new LoginCls();

        public Login()
        {
            InitializeComponent();
        }

        private void MasukBtn_Click(object sender, EventArgs e)
        {
            if(login.isExist(UsernameTxt.Text, PassTxt.Text))
            {
                new Dashboard(UsernameTxt.Text).Show();
                Close();
            } else
            {
                MessageBox.Show("Login Gagal, maaf username atau password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KeluarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MasukBtn.PerformClick();
            }
        }

        private void UsernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PassTxt.Focus();
            }
        }
    }
}
