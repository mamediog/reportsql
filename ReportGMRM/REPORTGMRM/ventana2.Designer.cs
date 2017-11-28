namespace REPORTGMRM
{
    partial class ventana2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewerVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetReportVenta_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GetReportVenta_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(267, 37);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(100, 28);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(71, 12);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(161, 20);
            this.txtDesc.TabIndex = 1;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(71, 41);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(161, 20);
            this.txtClient.TabIndex = 2;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(71, 68);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(161, 20);
            this.txtMes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mes:";
            // 
            // reportViewerVentas
            // 
            reportDataSource1.Name = "VentReport";
            reportDataSource1.Value = this.GetReportVenta_ResultBindingSource;
            this.reportViewerVentas.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerVentas.LocalReport.ReportEmbeddedResource = "REPORTGMRM.VentReport.rdlc";
            this.reportViewerVentas.Location = new System.Drawing.Point(2, 94);
            this.reportViewerVentas.Name = "reportViewerVentas";
            this.reportViewerVentas.Size = new System.Drawing.Size(688, 246);
            this.reportViewerVentas.TabIndex = 7;
            // 
            // GetReportVenta_ResultBindingSource
            // 
            this.GetReportVenta_ResultBindingSource.DataSource = typeof(REPORTGMRM.GetReportVenta_Result);
            // 
            // ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 357);
            this.Controls.Add(this.reportViewerVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnGenerar);
            this.Name = "ventana2";
            this.Text = "ventana2";
            this.Load += new System.EventHandler(this.ventana2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetReportVenta_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerVentas;
        private System.Windows.Forms.BindingSource GetReportVenta_ResultBindingSource;
    }
}