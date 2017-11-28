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
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void ventana2_Load(object sender, EventArgs e)
        {

           // this.reportViewerVentas.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "%" + txtDesc.Text + "%";
            txtClient.Text = "%" + txtClient.Text + "%";
            using (DemoDWGMRM2017Entities21 db = new DemoDWGMRM2017Entities21())
            {
                GetReportVenta_ResultBindingSource.DataSource = db.GetReportVenta(txtDesc.Text, txtClient.Text, txtMes.Text);
                reportViewerVentas.RefreshReport(); 
            }
        }

    }
}
