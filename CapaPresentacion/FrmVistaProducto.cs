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
    public partial class FrmVistaProducto : Form
    {

        public string IdProducto { get; set; }
        public string Codigo { get; set; }
        public string NombreProducto { get; set; }
        public string Precio { get; set; }

        public FrmVistaProducto()
        {
            InitializeComponent();

            dgvProductos.DataSource = CNProducto.Listar();
        }

        private void FrmVistaProducto_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Asegúrate de que los nombres en comillas coincidan EXACTAMENTE con tus columnas de SQL
                IdProducto = dgvProductos.Rows[e.RowIndex].Cells["idproducto"].Value.ToString();
                Codigo = dgvProductos.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                NombreProducto = dgvProductos.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

                // Usamos el precio de venta (revisa cómo se llama tu columna en SQL, puede ser precio_venta o precioventa)
                Precio = dgvProductos.Rows[e.RowIndex].Cells["precio_venta"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
