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
    public partial class FrmVistaProveedor : Form
    {
        public string IdProveedor { get; set; }
        public string Documento { get; set; }
        public string Razonsocial { get; set; }

        public FrmVistaProveedor()
        {
            InitializeComponent();
        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                IdProveedor = dlistado.Rows[e.RowIndex].Cells["idproveedor"].Value.ToString();
                Razonsocial = dlistado.Rows[e.RowIndex].Cells["razonsocial"].Value.ToString();

                Documento = dlistado.Rows[e.RowIndex].Cells["rfc"].Value.ToString();

                // Le decimos a la ventana que todo salió bien y la cerramos
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void MostrarClientes()
        {
            dlistado.DataSource = CNCliente.Listar();

        }

        private void FrmVistaProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                dlistado.DataSource = CNProveedor.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}