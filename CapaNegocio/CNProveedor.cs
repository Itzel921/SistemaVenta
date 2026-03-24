using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class CNProveedor
    {

        public static DataTable Listar()
        {
            return new CDProveedor().Listar();
        }



        public static string Guardar(string razonsocial, string dni, string rfc, string telefono, string direccion, string estado)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Razonsocial = razonsocial;
            Datos.Dni = dni;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Direccion = direccion;
            Datos.Estado = estado;

            return Datos.Guardar(Datos);
        }

        public static string Editar(int idproveedor, string razonsocial, string dni, string rfc, string telefono, string direccion, string estado)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Idproveedor = idproveedor;
            Datos.Razonsocial = razonsocial;
            Datos.Dni = dni;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Direccion = direccion;
            Datos.Estado = estado;
            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idproveedor)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Idproveedor = idproveedor;
            return Datos.Eliminar(Datos);
        }


        public static DataTable BuscarRazonSocial(string textobuscar)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Buscar = textobuscar;
            return Datos.BuscarRazonSocial(Datos);
        }

        public static DataTable BuscarDni(string textobuscar)
        {
            CDProveedor Datos = new CDProveedor();
            Datos.Buscar = textobuscar;
            return Datos.BuscarDni(Datos);
        }



    }
}
