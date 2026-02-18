using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrarCliente : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 150;
        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoCliente form = new FrmListadoCliente();
            form.Show();
            this.Hide();
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

            try { 

                if (this.txtnombre.Text == string.Empty || this.txtapellidos.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del cliente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (this.Insert == true)
                    {
                        CNCliente.Guardar(this.txtnombre.Text, this.txtapellidos.Text, this.txtrfc.Text, this.txtdni.Text, this.txttelefono.Text, estado);

                        MessageBox.Show("Cliente registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (this.Edit == true)
                    {
                        CNCliente.Editar(Convert.ToInt32(this.txtidcliente.Text), this.txtnombre.Text, this.txtapellidos.Text, this.txtrfc.Text, this.txtdni.Text, this.txttelefono.Text, estado);
                        MessageBox.Show("Cliente editado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoCliente form = new FrmListadoCliente();
                    form.Show();
                    this.Hide();

                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void rbtninactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
