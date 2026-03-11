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
    public partial class FrmListadoProducto : Form
    {
        public FrmListadoProducto()
        {
            InitializeComponent();
        }

        private void FrmListadoProducto_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left = 100;

            Mostrar();
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNProducto.Listar();
        }

        //Metodo para buscar clientes por nombre
        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNProducto.BuscarNombre(txtbuscar.Text);
        }

        //Metodo para buscar por dni
        public void BuscarCodigo()
        {
            this.dlistado.DataSource = CNProducto.BuscarCodigo(txtbuscar.Text);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rbtnnombre.Checked)
            {
                BuscarNombre();
            }
            else if (rbtncodigo.Checked)
            {
                BuscarCodigo();
            }
            else
            {
                MessageBox.Show("Seleccione un criterio de busqueda", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto form = new FrmRegistrarProducto();

            form.Show();
            form.Insert = true;
            this.Hide();
        }
    }

    }
