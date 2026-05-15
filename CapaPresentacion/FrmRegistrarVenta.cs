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
    public partial class FrmRegistrarVenta : Form
    {

        private string idProductoSeleccionado = "0";
        private string idClienteSeleccionado = "0";

        public FrmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            this.Top = 0;   
            this.Left = 0;
        }


        private void CalcularTotal()
        {
            decimal total = 0;

            // Recorremos todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                // Sumamos el valor de la columna "SubTotal" (asegúrate de que el nombre coincida con la propiedad Name de tu columna)
                if (row.Cells["SubTotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }

            // Actualizamos el Label (cambia 'lblTotalPagar' por el nombre que le hayas puesto a tu texto verde)
            lblTotalPagar.Text = "Total a Pagar: $" + total.ToString("0.00");
        }

        private void LimpiarProducto()
        {
            // Cambia los nombres por los que usaste en tus TextBox
            txtCodigo.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Value = 0; // Asumiendo que usaste un NumericUpDown
            txtCodigo.Focus(); // Regresamos el cursor al código
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // 1. Validamos que haya un producto seleccionado y la cantidad sea mayor a 0
            if (string.IsNullOrWhiteSpace(txtProducto.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe seleccionar un producto primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Extraemos y calculamos los valores
            string idProducto = idProductoSeleccionado;
            string producto = txtProducto.Text;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Value);
            decimal subTotal = precio * cantidad;

            // 3. Agregamos la fila al DataGridView (El orden debe coincidir con tus columnas)
             dgvDetalleVenta.Rows.Add(new object[] {
                idProducto,
                producto,
                precio,
                cantidad,
                subTotal,
                 null
            });

            // 4. Recalculamos el total y limpiamos para el siguiente
            CalcularTotal();
            LimpiarProducto();
            idProductoSeleccionado = "0";
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // 1. Instanciamos la ventana del buscador
            FrmVistaCliente vista = new FrmVistaCliente();

            // 2. La abrimos con ShowDialog() para que congele la pantalla de fondo
            if (vista.ShowDialog() == DialogResult.OK)
            {
                // 3. Si el usuario hizo doble clic, la ventana devolverá "OK" 
                // y podemos extraer las variables públicas que creamos
                idClienteSeleccionado = vista.IdCliente;
                txtnum_documento.Text = vista.Documento;
                txtNombreCliente.Text = vista.NombreCompleto;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmVistaProducto vista = new FrmVistaProducto();

            if (vista.ShowDialog() == DialogResult.OK)
            {
                // Pasamos los datos recolectados a las cajas de texto
                idProductoSeleccionado = vista.IdProducto;
                txtCodigo.Text = vista.Codigo;
                txtProducto.Text = vista.NombreProducto;
                txtPrecio.Text = vista.Precio;
                txtCantidad.Select();
            }
        }

        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetalleVenta.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Desea quitar este producto del carrito?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Borramos la fila
                    dgvDetalleVenta.Rows.RemoveAt(e.RowIndex);
                    
                    CalcularTotal();
                }
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == "0")
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de cobrar.", "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue productos para vender.", "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTipoDocumento.SelectedIndex == -1 || cboTipoDocumento.Text == string.Empty)
            {
                MessageBox.Show("Seleccione el tipo de documento (Boleta o Factura).", "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal total = 0;
                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                    }
                }

                // Calculamos el desglose (Aplicando el 16% estándar)
                decimal subtotal = total / 1.16m;
                decimal iva = total - subtotal;

                DateTime fecha = dtpFecha.Value;
                string serie = "001";

                string num_documento = DateTime.Now.ToString("ddMMyyHHmmss");

                string tipoDocumento = cboTipoDocumento.Text;
                string estado = "ACTIVO";

                int idUsuario = 1;
                int idCliente = Convert.ToInt32(idClienteSeleccionado);

                // 4. GUARDAR CABECERA (Y atrapar el ID mágico)
                int idVentaGenerada = CNVenta.Guardar(fecha, serie, num_documento, tipoDocumento, subtotal, iva, total, estado, idUsuario, idCliente);

                if (idVentaGenerada > 0)
                {
                    bool errorEnDetalle = false;
                    string respuestaDetalle = ""; // <--- ¡AQUÍ LA DECLARAMOS AFUERA DEL CICLO!

                    // 5. GUARDAR EL CARRITO (El ciclo mágico)
                    foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                    {
                        if (row.Cells["IdProducto"].Value != null)
                        {
                            int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                            decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                            decimal subTotalLinea = Convert.ToDecimal(row.Cells["SubTotal"].Value);

                            // Insertamos y guardamos el error en la variable (quitamos la palabra "string" aquí)
                            respuestaDetalle = CNVenta.InsertarDetalle(idVentaGenerada, idProducto, cantidad, precio, subTotalLinea);

                            if (respuestaDetalle != "OK")
                            {
                                errorEnDetalle = true;
                                break; // Si falla uno, rompemos el ciclo
                            }
                        }
                    }

                    // 6. Finalizar y limpiar la pantalla
                    if (!errorEnDetalle)
                    {
                        MessageBox.Show($"¡Venta registrada exitosamente!\nTicket Nro: {num_documento}", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvDetalleVenta.Rows.Clear();
                        CalcularTotal();
                        txtnum_documento.Clear();
                        txtNombreCliente.Clear();
                        idClienteSeleccionado = "0";
                    }
                    else
                    {
                        // Ahora sí podemos usarla porque nació antes del ciclo
                        MessageBox.Show("Error en el detalle: " + respuestaDetalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
                else
                {
                    MessageBox.Show("Error crítico: No se pudo generar la cabecera de la venta en SQL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción no controlada: " + ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
