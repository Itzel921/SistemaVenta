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
    public partial class FrmRegistrarProveedor : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarProveedor()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 150;
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (rbtnactivo.Checked == true)
            {
                estado = "ACTIVO";

            }
            else
            {
                estado = "INACTIVO";
            }

            try
            {

                if (this.txtrazonsocial.Text == string.Empty || this.txtdni.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del Proveedor", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (this.Insert == true)
                    {
                        CNProveedor.Guardar(this.txtrazonsocial.Text, this.txtdni.Text, this.txtrfc.Text, this.txttelefono.Text, this.txtdireccion.Text, estado);

                        MessageBox.Show("Proveedor registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (this.Edit == true)
                    {
                        CNProveedor.Editar(Convert.ToInt32(this.txtidproveedor.Text), this.txtrazonsocial.Text, this.txtdni.Text, this.txtrfc.Text, this.txttelefono.Text, this.txtdireccion.Text, estado);
                        MessageBox.Show("Proveedor editado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoProveedor form = new FrmListadoProveedor();
                    form.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoProveedor form = new FrmListadoProveedor();
            form.Show();
            this.Hide();
        }
    }
}
