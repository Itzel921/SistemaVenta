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
    public partial class FrmReporteVentasFechas : Form
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public FrmReporteVentasFechas()
        {
            InitializeComponent();
        }

        private void FrmReporteVentasFechas_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CNVenta.ConsultarVentasPorFecha(FechaInicio, FechaFin);

                this.reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("DataSet_Ventas", dt);
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }

    }

