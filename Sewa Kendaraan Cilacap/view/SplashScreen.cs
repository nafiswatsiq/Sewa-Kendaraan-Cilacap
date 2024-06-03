using Siperpus.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Nama: Nafis WAtsiq Amrulloh
//NIM: 220302017
//Kelas = TI-2A

namespace Siperpus
{
    public partial class SplashScreen : Form
    {
        byte counter = 0;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter == 3)
            {
                timer1.Enabled = false;
                new Login().Show();

                this.Hide();
            }
        }
    }
}
