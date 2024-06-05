using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sewa_Kendaraan_Cilacap.print
{
    public partial class RekapSewa : Form
    {
        public RekapSewa()
        {
            InitializeComponent();
        }

        private void RekapSewa_Load(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            document.Load(@"D:\Praktikum PBO\Sewa-Kendaraan-Cilacap\Sewa Kendaraan Cilacap\print\PrintSewa.rpt");
            document.SetDatabaseLogon("root", "");
            document.Refresh();
            crystalReportViewer1.ReportSource = document;
            crystalReportViewer1.Refresh();
        }
    }
}
