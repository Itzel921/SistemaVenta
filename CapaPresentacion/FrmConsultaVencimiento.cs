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
    public partial class FrmConsultaVencimiento : Form
    {
        public FrmConsultaVencimiento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                lblVencimiento.DataSource = CNProducto.ConsultarVencimiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar vencimientos: " + ex.Message);
            }
        }

        private void brnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteVencimiento frmReporte = new FrmReporteVencimiento();

            frmReporte.ShowDialog();
        }
    }
}
