using CapaNegocio;
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

namespace CapaPresentacion
{
    public partial class FrmReporteStockMinimo : Form
    {
        public FrmReporteStockMinimo()
        {
            InitializeComponent();
        }

        private void FrmReporteStockMinimo_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CNProducto.ConsultarStockMinimo();

                this.reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("DataTable_Productos", dt);
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
