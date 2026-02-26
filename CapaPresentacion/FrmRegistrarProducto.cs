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
    public partial class FrmRegistrarProducto : Form
    {

        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarProducto()
        {
            InitializeComponent();
            this.Insert = true;
            this.txtidcategoria.Text = "1";
        }

      

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {

            this.Top = 150;
            this.Left = 100;

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (rbActivo.Checked == true)
            {
                estado = "ACTIVO";

            }
            else
            {
                estado = "INACTIVO";
            }

            try
            {
                if (this.txtnombre.Text == string.Empty || this.txtcodigo.Text == string.Empty || this.txtdescripcion.Text == string.Empty || this.txtPcompra.Text == string.Empty || this.txtPventa.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos de los productos", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (this.Insert == true)
                    {
                        CNProducto.Guardar(this.txtcodigo.Text, this.txtnombre.Text, this.txtdescripcion.Text, this.dateFingreso.Value, this.dateFvencimiento.Value, Convert.ToDouble(this.txtPcompra.Text), Convert.ToDouble(this.txtPventa.Text), Convert.ToInt32(this.txtStock.Text), estado, Convert.ToInt32(this.txtidcategoria.Text));
                        MessageBox.Show("Producto registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (this.Edit == true)
                    {
                        CNProducto.Editar(Convert.ToInt32(this.txtidproducto.Text), this.txtcodigo.Text, this.txtnombre.Text, this.txtdescripcion.Text, this.dateFingreso.Value, this.dateFvencimiento.Value, Convert.ToDouble(this.txtPcompra.Text), Convert.ToDouble(this.txtPventa.Text), Convert.ToInt32(this.txtStock.Text), estado, Convert.ToInt32(this.txtidcategoria.Text));
                        MessageBox.Show("Producto editado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        
        }
    }
}
