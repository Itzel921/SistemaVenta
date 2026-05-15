using CapaNegocio;
using Microsoft.Reporting.WinForms; 
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteProducto : Form
    {
        public FrmReporteProducto()
        {
            InitializeComponent();
        }

        private void FrmReporteProducto_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtProductos = CNProducto.Listar();

                this.reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("DataSet_Productos", dtProductos);

                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
