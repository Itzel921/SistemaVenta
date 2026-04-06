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
    public partial class FrmListadoUsuario : Form
    {
        public FrmListadoUsuario()
        {
            InitializeComponent();
        }

        private void FrmListadoUsuario_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                this.BuscarNombre();
            }
            else if (rbtnusuario.Checked) 
            {
                this.BuscarUsuario();
            }
            else
            {
                MessageBox.Show("Ingrese un criterio de busqueda", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario form = new FrmRegistrarUsuario();

            form.Show();
            form.Insert = true;
            form.Edit = false;
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario form = new FrmRegistrarUsuario();
            form.Edit = true;
            form.Insert = false;

            form.txtidusuario.Text  = dlistado.CurrentRow.Cells["idusuario"].Value.ToString();
            form.txtidempleado.Text = dlistado.CurrentRow.Cells["idempleado"].Value.ToString();
            form.txtnombre.Text     = dlistado.CurrentRow.Cells["nombre"].Value.ToString();
            form.txtapellidos.Text  = dlistado.CurrentRow.Cells["apellidos"].Value.ToString();
            form.txtusuario.Text    = dlistado.CurrentRow.Cells["usuario"].Value.ToString();
            form.txtpassword.Text   = dlistado.CurrentRow.Cells["pass"].Value.ToString();
            form.cboacceso.Text     = dlistado.CurrentRow.Cells["acceso"].Value.ToString();

            string estado = dlistado.CurrentRow.Cells["estado"].Value.ToString();

            if(estado == "ACTIVO")
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
                        string idusuario = dlistado.CurrentRow.Cells["idusuario"].Value.ToString();
                        CNUsuario.Eliminar(Convert.ToInt32(idusuario.ToString()));

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
            this.dlistado.DataSource = CNUsuario.Listar();
        }

        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNUsuario.BuscarNombre(txtbuscar.Text);
        } 

        public void BuscarUsuario()
        {
            this.dlistado.DataSource = CNUsuario.BuscarNombreUsuario(txtbuscar.Text);
        }
    }
}
