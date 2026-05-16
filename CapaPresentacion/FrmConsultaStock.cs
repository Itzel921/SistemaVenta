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
    public partial class FrmConsultaStock : Form
    {
        public FrmConsultaStock()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ldlStock.DataSource = CNProducto.ConsultarStockMinimo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el stock: " + ex.Message);
            }
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            new FrmReporteStockMinimo().ShowDialog();
        }
    }
}
