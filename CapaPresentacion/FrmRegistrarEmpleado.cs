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
    public partial class FrmRegistrarEmpleado : Form
    {

        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmRegistrarEmpleado_Load(object sender, EventArgs e)
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

                if (this.txtnombre.Text == string.Empty || this.txtapellidos.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del empleado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (this.Insert == true)
                    {
                        CNEmpleado.Guardar(this.txtnombre.Text, this.txtapellidos.Text, this.txtdni.Text, this.txttelefono.Text, this.txtdireccion.Text, estado);

                        MessageBox.Show("Cliente registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (this.Edit == true)
                    {
                        CNEmpleado.Editar(Convert.ToInt32(this.txtidempleado.Text), this.txtnombre.Text, this.txtapellidos.Text, this.txtdni.Text, this.txttelefono.Text, this.txtdireccion.Text, estado);
                        MessageBox.Show("Cliente editado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoEmpleado form = new FrmListadoEmpleado();
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
            FrmListadoEmpleado form = new FrmListadoEmpleado();
            form.Show();
            this.Hide();
        }

    }

}
