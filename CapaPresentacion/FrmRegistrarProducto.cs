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
using Type = BarcodeStandard;
using BarcodeLib; // Asegúrate de tener este using

namespace CapaPresentacion
{
    public partial class FrmRegistrarProducto : Form
    {

        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarProducto()
        {
            InitializeComponent();
            this.Insert = true;
            this.cboidcategoria.Text = "1";
        }

      

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {

            this.Top = 150;
            this.Left = 100;

            this.CargarCategoria();

        }

        private void CargarCategoria()
        {

            cboidcategoria.DataSource = CNCategoria.Listar();
            cboidcategoria.DisplayMember = "descripcion";
            cboidcategoria.ValueMember = "idcategoria";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {

            string estado = "";
            if (rbactivo.Checked == true)
            {
                estado = "ACTIVO";

            }
            else
            {
                estado = "INACTIVO";
            }

            try
            {
                if (this.txtnombre.Text == string.Empty || this.txtcodigo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos de los productos", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (this.Insert == true)
                    {
                        CNProducto.Guardar(
                            this.txtcodigo.Text,
                            this.txtnombre.Text,
                            this.txtdescripcion.Text,
                            this.dtfechaingreso.Value,
                            this.dtfechavencimiento.Value,
                            Convert.ToDouble(this.txtpreciocompra.Text),
                            Convert.ToDouble(this.txtprecioventa.Text),
                            Convert.ToInt32(this.txtcantidad.Text),
                            estado,
                            Convert.ToInt32(this.cboidcategoria.SelectedValue) 
                        );
                        MessageBox.Show("Producto registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNProducto.Editar(
                            Convert.ToInt32(this.txtidproducto.Text),
                            this.txtcodigo.Text,
                            this.txtnombre.Text,
                            this.txtdescripcion.Text,
                            this.dtfechaingreso.Value,
                            this.dtfechavencimiento.Value,
                            Convert.ToDouble(this.txtpreciocompra.Text),
                            Convert.ToDouble(this.txtprecioventa.Text),
                            Convert.ToInt32(this.txtcantidad.Text),
                            estado,
                            Convert.ToInt32(this.cboidcategoria.SelectedValue) 
                        );
                        MessageBox.Show("Producto editado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    this.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            picCodigoBarras.Image = barcode.Encode(TYPE.CODE128, txtcodigo.Text, Color.Black, Color.White, 250, 80);
        }
    }
}
