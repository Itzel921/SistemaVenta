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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable log = CNUsuario.Logeo(txtUsuario.Text, txtPassword.Text);

                if (log != null && log.Rows.Count > 0)
                {
                    // Extraemos los datos de la primera fila devuelta (índice 0)
                    string nombreEmpleado = log.Rows[0]["nombre"].ToString();
                    string apellidosEmpleado = log.Rows[0]["apellidos"].ToString();

                    // Unimos el nombre y apellido
                    string nombreCompleto = nombreEmpleado + " " + apellidosEmpleado;

                    this.Hide();

                    FrmInicio menuPrincipal = new FrmInicio();
                    // Le pasamos el nombre completo a la propiedad que creamos en FrmInicio
                    menuPrincipal.NombreUsuarioLogueado = nombreCompleto;
                    menuPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, o cuenta inactiva.", "Error de Acceso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
