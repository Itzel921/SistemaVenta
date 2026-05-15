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
    public partial class FrmRegistrarCompra : Form
    {

        private string idProveedorSeleccionado = "0";
        private string idProductoSeleccionado = "0";

        public FrmRegistrarCompra()
        {
            InitializeComponent();
        }

        private void FrmRegistrarCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmVistaProveedor vista = new FrmVistaProveedor();

            if (vista.ShowDialog() == DialogResult.OK)
            {
                idProveedorSeleccionado = vista.IdProveedor;
                txtdocumento.Text = vista.Documento;
                txtrazonsocial.Text = vista.Razonsocial;
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (idProveedorSeleccionado == "0")
            {
                MessageBox.Show("Por favor, seleccione un proveedor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvDetalleCompra.Rows.Count == 0) 
            {
                MessageBox.Show("El carrito está vacío. Agregue productos a la compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTipoDocumento.SelectedIndex == -1 || cboTipoDocumento.Text == string.Empty)
            {
                MessageBox.Show("Seleccione el tipo de documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Cálculo de Totales 
                decimal total = 0;
                foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                    }
                }

                decimal subtotal = total / 1.16m;
                decimal iva = total - subtotal;

                // 3. Preparar los datos de la Cabecera (¡Sin serie!)
                DateTime fecha = dtpFecha.Value;
                string num_documento = DateTime.Now.ToString("ddMMyyHHmmss"); // Ticket dinámico
                string tipoDocumento = cboTipoDocumento.Text;
                string estado = "ACTIVO";
                int idUsuario = 1; // ID temporal de prueba
                int idProveedor = Convert.ToInt32(idProveedorSeleccionado);

                // 4. GUARDAR CABECERA EN COMPRAS
                int idCompraGenerada = CNCompra.Guardar(fecha, num_documento, tipoDocumento, subtotal, iva, total, estado, idUsuario, idProveedor);

                if (idCompraGenerada > 0)
                {
                    bool errorEnDetalle = false;
                    string respuestaDetalle = "";

                    // 5. GUARDAR EL CARRITO 
                    foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                    {
                        if (row.Cells["IdProducto"].Value != null)
                        {
                            int idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value);
                            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value); // Ojo: Este es precio de compra
                            decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                            decimal subTotalLinea = Convert.ToDecimal(row.Cells["SubTotal"].Value);

                            // Insertamos el detalle en compras
                            respuestaDetalle = CNCompra.InsertarDetalle(idCompraGenerada, idProducto, cantidad, precio, subTotalLinea);

                            if (respuestaDetalle != "OK")
                            {
                                errorEnDetalle = true;
                                break;
                            }
                        }
                    }

                    // 6. Limpiar
                    if (!errorEnDetalle)
                    {
                        MessageBox.Show($"¡Compra registrada exitosamente!\nFolio Nro: {num_documento}", "Sistema de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvDetalleCompra.Rows.Clear();
                        CalcularTotal();
                        txtdocumento.Clear();
                        idProveedorSeleccionado = "0";
                    }
                    else
                    {
                        MessageBox.Show("Error en el detalle: " + respuestaDetalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error crítico: No se pudo generar la cabecera de la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción no controlada: " + ex.Message, "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CalcularTotal()
        {
            decimal total = 0;

            // Recorremos todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
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
            txtCodigo.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Value = 0;
            txtCodigo.Focus();
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
            dgvDetalleCompra.Rows.Add(new object[] {
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

        private void dgvDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetalleCompra.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Desea quitar este producto de la compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvDetalleCompra.Rows.RemoveAt(e.RowIndex);
                    CalcularTotal(); // Magia: el total se recalcula solo
                }
            }
        }
    }
}
