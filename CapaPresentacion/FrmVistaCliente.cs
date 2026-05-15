using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVistaCliente : Form
    {
        public string IdCliente { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public FrmVistaCliente()
        {
            InitializeComponent();
        }

        private void FrmVistaCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            dgvClientes.DataSource = CNCliente.Listar();
            
        }


        //Doble clic en una celda
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdCliente = dgvClientes.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
                Documento = dgvClientes.Rows[e.RowIndex].Cells["dni"].Value.ToString();

                string nombre = dgvClientes.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                string apellido = dgvClientes.Rows[e.RowIndex].Cells["apellidos"].Value.ToString();
                NombreCompleto = nombre + " " + apellido;

                // Le decimos a la ventana que todo salió bien y la cerramos
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    
    }
    
}
