using CapaNegocio;
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
    public partial class FrmConsultaVentas : Form
    {
        public FrmConsultaVentas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                lblventas.DataSource = CNVenta.ConsultarVentasPorFecha(dtpFechaInicio.Value, dtpFechaFin.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las ventas: " + ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteVentasFechas frmReporte = new FrmReporteVentasFechas();

            frmReporte.FechaInicio = dtpFechaInicio.Value;
            frmReporte.FechaFin = dtpFechaFin.Value;
            frmReporte.ShowDialog();
        }
    }
}
