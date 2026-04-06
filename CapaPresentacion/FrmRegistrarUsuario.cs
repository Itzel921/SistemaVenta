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
    public partial class FrmRegistrarUsuario : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 150;
        }

        private void btnbuscarempleado_Click(object sender, EventArgs e)
        {
            FrmVistaEmpleado form = new FrmVistaEmpleado();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                txtidempleado.Text = Convert.ToString(form.dlistado.CurrentRow.Cells["idempleado"].Value);
            }
                txtnombre.Text = Convert.ToString(form.dlistado.CurrentRow.Cells["nombre"].Value);
                txtapellidos.Text = Convert.ToString(form.dlistado.CurrentRow.Cells["apellidos"].Value);
            
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

                if (this.txtnombre.Text == string.Empty || this.txtapellidos.Text == string.Empty || this.txtpassword.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del Empleado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (this.Insert)
                    {
                        CNUsuario.Guardar(this.txtusuario.Text, this.txtpassword.Text, this.cboacceso.Text, estado, Convert.ToInt32(txtidempleado.Text));
                        MessageBox.Show("Usuario registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (this.Edit)
                    {
                        CNUsuario.Editar(Convert.ToInt32(txtidusuario.Text), this.txtusuario.Text, this.txtpassword.Text, this.cboacceso.Text, estado, Convert.ToInt32(txtidempleado.Text));
                        MessageBox.Show("Usuario registrado correctamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoUsuario form = new FrmListadoUsuario();
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
            FrmListadoUsuario form = new FrmListadoUsuario();
            
            form.Show();
            this.Hide();
        }
    }
}
