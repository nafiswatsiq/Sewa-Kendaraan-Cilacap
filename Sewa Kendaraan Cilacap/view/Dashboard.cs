﻿using Sewa_Kendaraan_Cilacap.model;
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

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void JurusanBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProdiBtn_Click(object sender, EventArgs e)
        {

        }

        private void KeluarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
