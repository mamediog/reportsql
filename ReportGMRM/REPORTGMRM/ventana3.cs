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
    public partial class ventana3 : Form
    {
        public ventana3()
        {
            InitializeComponent();
        }

        private void ventana3_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            txtProducto.Text = "%" + txtProducto.Text + "%";
            using (DemoDWGMRM2017Entities3 db = new DemoDWGMRM2017Entities3())
            {
                GetReportProducto_ResultBindingSource.DataSource = db.GetReportProducto(
                    Convert.ToDateTime(txtFrom.Text), Convert.ToDateTime(txtTo.Text), txtProducto.Text
                    ).ToList();
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("fromFecha", Convert.ToDateTime(txtFrom.Text).Date.ToShortDateString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("toFecha", Convert.ToDateTime(txtTo.Text).Date.ToShortDateString())
                };
                reportViewerProducto.LocalReport.SetParameters(rParams);
                this.reportViewerProducto.RefreshReport();
            }
        }
    }
}
