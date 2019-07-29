using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanadaSalesManagement1.Reports
{
    public partial class FrmViewReport : Form
    {

        public string reptName;
        public ReportDataSource reptSource;

        public void ViewReport(ReportDataSource rd, string reptName)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rd);
            reportViewer1.LocalReport.ReportEmbeddedResource = reptName;
            reportViewer1.RefreshReport();
        }

        public FrmViewReport()
        {
            InitializeComponent();
        }

        private void FrmViewReport_Load(object sender, EventArgs e)
        {
            ViewReport(reptSource, reptName);
        }
    }
}
