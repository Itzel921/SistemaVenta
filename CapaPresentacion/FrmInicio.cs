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
    public partial class FrmInicio : Form
    {
        public string NombreUsuarioLogueado { get; set; }
        string opcion;
        bool expanderalmacen;
        bool expandercompras;
        bool expanderventas;
        bool expanderconsultas;
        bool expanderconfiguraciones;
        bool expanderreportes;



        public FrmInicio()
        {
            InitializeComponent();

            MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;

        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tmrsubmenu_Tick(object sender, EventArgs e)
        {
            if (opcion.Equals("mnualmacen"))
            {
                if (expanderalmacen)
                {
                    mnualmacen.Height -= 10;
                    if (mnualmacen.Height == mnualmacen.MinimumSize.Height)
                    {
                        expanderalmacen = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnualmacen.Height += 10;
                    if (mnualmacen.Height == mnualmacen.MaximumSize.Height)
                    {
                        expanderalmacen = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnucompras"))
            {
                if (expandercompras)
                {
                    mnucompra.Height -= 10;
                    if (mnucompra.Height == mnucompra.MinimumSize.Height)
                    {
                        expandercompras = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnucompra.Height += 10;
                    if (mnucompra.Height == mnucompra.MaximumSize.Height)
                    {
                        expandercompras = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnuventas"))
            {
                if (expanderventas)
                {
                    mnuventa.Height -= 10;
                    if (mnuventa.Height == mnuventa.MinimumSize.Height)
                    {
                        expanderventas = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnuventa.Height += 10;
                    if (mnuventa.Height == mnuventa.MaximumSize.Height)
                    {
                        expanderventas = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnuconsultas"))
            {
                if (expanderconsultas)
                {
                    mnuconsultas.Height -= 10;
                    if (mnuconsultas.Height == mnuconsultas.MinimumSize.Height)
                    {
                        expanderconsultas = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnuconsultas.Height += 10;
                    if (mnuconsultas.Height == mnuconsultas.MaximumSize.Height)
                    {
                        expanderconsultas = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnuconfiguraciones"))
            {
                if (expanderconfiguraciones)
                {
                    mnuconfiguraciones.Height -= 10;
                    if (mnuconfiguraciones.Height == mnuconfiguraciones.MinimumSize.Height)
                    {
                        expanderconfiguraciones = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnuconfiguraciones.Height += 10;
                    if (mnuconfiguraciones.Height == mnuconfiguraciones.MaximumSize.Height)
                    {
                        expanderconfiguraciones = true;
                        tmrsubmenu.Stop();
                    }
                }
            }

            if (opcion.Equals("mnureportes"))
            {
                if (expanderreportes)
                {
                    mnureportes.Height -= 10;
                    if (mnureportes.Height == mnureportes.MinimumSize.Height)
                    {
                        expanderreportes = false;
                        tmrsubmenu.Stop();
                    }
                }
                else
                {
                    mnureportes.Height += 10;
                    if (mnureportes.Height == mnureportes.MaximumSize.Height)
                    {
                        expanderreportes = true;
                        tmrsubmenu.Stop();
                    }
                }
            }
        }

        

        private void btnalmacen_Click(object sender, EventArgs e)
        {
            opcion = "mnualmacen";
            tmrsubmenu.Start();

        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            opcion = "mnucompras";
            tmrsubmenu.Start();

        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            opcion = "mnuventas";
            tmrsubmenu.Start();

        }

        private void btnconfiguraciones_Click(object sender, EventArgs e)
        {
            opcion = "mnuconfiguraciones";
            tmrsubmenu.Start();

        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            opcion = "mnuconsultas";
            tmrsubmenu.Start();

        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            opcion = "mnureportes";
            tmrsubmenu.Start();

        }

        private void producto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProducto());

            mnualmacen.Width = 214;
            mnualmacen.Height = 37;

        }

        private void categoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoCategoria());

            mnualmacen.Width = 214;
            mnualmacen.Height = 37;

        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoCliente());

            mnualmacen.Width = 214;
            mnualmacen.Height = 37;

        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProveedor());

            mnucompra.Width = 214;
            mnucompra.Height = 37;

        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoEmpleado());

            mnuconfiguraciones.Width = 214;
            mnuconfiguraciones.Height = 37;
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoUsuario());

            mnuconfiguraciones.Width = 214;
            mnuconfiguraciones.Height = 37;

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lblUsuarioLogueado.Text = NombreUsuarioLogueado;
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            // Preguntamos al usuario si realmente quiere salir
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Sistema ventas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close(); // Cierra el FrmInicio actual

                // Volvemos a mostrar el formulario de Login
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }

        private void AbrirFormulario(Form formulario)
        {
            // Cerramos todos los formularios hijos abiertos actualmente
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }

            // Configuramos y mostramos el nuevo formulario
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill; // hace que se pegue perfectamente desde la esquina superior izquierda cubriendo toda el área gris.
            formulario.Show(); 
        }

        private void btnAtajoClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoCliente());
        }

        private void btnAtajoEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoEmpleado());
        }

        private void btnAtajoProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProducto());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
