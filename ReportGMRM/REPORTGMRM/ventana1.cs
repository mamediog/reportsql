using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPORTGMRM
{
    public partial class ventana1 : Form
    {
        public ventana1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            using (DemoDWGMRM2017Entities db = new DemoDWGMRM2017Entities())
            {
                GetReportFechas_ResultBindingSource.DataSource = db.GetReportFechas(
                    Convert.ToDateTime(txtFrom.Text),Convert.ToDateTime(txtTo.Text)
                    ).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("fromDate", Convert.ToDateTime(txtFrom.Text).Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("toDate", Convert.ToDateTime(txtTo.Text).Date.ToShortDateString())
                };
                reportViewerFecha.LocalReport.SetParameters(rParams);
                reportViewerFecha.RefreshReport();
            }
        }
    }
}
