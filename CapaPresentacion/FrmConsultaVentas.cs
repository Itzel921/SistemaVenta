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

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if (lblventas.SelectedRows.Count > 0)
            {
                // Capturamos el idventa de la fila que está seleccionada actualmente
                int idVenta = Convert.ToInt32(lblventas.CurrentRow.Cells["idventa"].Value);

                // Abrimos la ventana del reporte pasándole ese ID
                FrmReporteFactura frm = new FrmReporteFactura();
                frm.IdVenta = idVenta;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una venta de la lista para imprimir su comprobante.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
