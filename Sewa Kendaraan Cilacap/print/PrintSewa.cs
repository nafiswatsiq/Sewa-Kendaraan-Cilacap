using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    
    public partial class PrintSewa : Form
    {
        public string code = "";

        public PrintSewa()
        {
            InitializeComponent();
        }

        private void PrintSewa_Load(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load(@"D:\C# project\Sewa KEndaraan Cilacap\Sewa Kendaraan Cilacap\print\PrintReport1.rpt");
            reportDocument.SetDatabaseLogon("root", "");
            reportDocument.Refresh();

            ParameterFieldDefinitions Flds;
            ParameterFieldDefinition Fld;
            ParameterValues parVal = new ParameterValues();
            ParameterDiscreteValue parDis = new ParameterDiscreteValue();

            parDis.Value = code;
            Flds = reportDocument.DataDefinition.ParameterFields;
            Fld = Flds["Codep"];
            parVal = Fld.CurrentValues;

            parVal.Clear(); 
            parVal.Add(parDis);
            Fld.ApplyCurrentValues(parVal);


            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
        }
    }
}
