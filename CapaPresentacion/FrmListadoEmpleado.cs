using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmListadoEmpleado : Form
    {
        public FrmListadoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmListadoEmpleado_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 100;

            Mostrar();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rbtndni.Checked)
            {
                BuscarDni();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de busqueda", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado form = new FrmRegistrarEmpleado();
            form.Insert = true;
            form.Edit = false;

            form.Show();
            this.Hide();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado form = new FrmRegistrarEmpleado();
            form.Edit = true;

            form.txtidempleado.Text = this.dlistado.CurrentRow.Cells["idempleado"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtapellidos.Text = this.dlistado.CurrentRow.Cells["apellidos"].Value.ToString();
            form.txtdni.Text = this.dlistado.CurrentRow.Cells["dni"].Value.ToString();
            form.txttelefono.Text = this.dlistado.CurrentRow.Cells["telefono"].Value.ToString();
            form.txtdireccion.Text = this.dlistado.CurrentRow.Cells["direccion"].Value.ToString();

            string estado = this.dlistado.CurrentRow.Cells["estado"].Value.ToString();

            if (estado == "ACTIVO")
            {
                form.rbtnactivo.Checked = true;
            }
            else
            {
                form.rbtninactivo.Checked = true;
            }

            form.Show();
            this.Hide();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar el(los) registro(s)?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlistado.SelectedRows.Count > 0)
                {
                    if (opcion == DialogResult.OK)
                    {
                        string idempleado = dlistado.CurrentRow.Cells["idempleado"].Value.ToString();
                        CNEmpleado.Eliminar(Convert.ToInt32(idempleado.ToString()));

                        MessageBox.Show("Registro eliminado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Mostrar();
                    }
                }

                Mostrar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        public void Mostrar()
        {
            this.dlistado.DataSource = CNEmpleado.Listar();
        }


        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNEmpleado.BuscarNombre(txtbuscar.Text);
        }


        public void BuscarDni()
        {
            this.dlistado.DataSource = CNEmpleado.BuscarDni(txtbuscar.Text);
        }



    }
}
