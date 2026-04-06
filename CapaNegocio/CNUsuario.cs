using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaNegocio
{
    public class CNUsuario
    {
        public static DataTable Listar()
        {
            return new CDUsuario().Listar();
        }


        public static string Guardar(string usuario, string password, string acceso, string estado, int idempleado)
        {
            CDUsuario Datos = new CDUsuario();
            Datos.Usuario = usuario;
            Datos.Password = password;
            Datos.Acceso = acceso;
            Datos.Estado = estado;
            Datos.IdEmpleado = idempleado;

            return Datos.Guardar(Datos);
        }


        public static string Editar(int idusuario, string usuario, string password, string acceso, string estado, int idempleado)
        {
            CDUsuario Datos = new CDUsuario();
            Datos.IdUsuario = idusuario;
            Datos.Usuario = usuario;
            Datos.Password = password;
            Datos.Acceso = acceso;
            Datos.Estado = estado;
            Datos.IdEmpleado = idempleado;

            return Datos.Editar(Datos);

        }


        public static string Eliminar(int idusuario)
        {
            CDUsuario Datos = new CDUsuario();
            Datos.IdUsuario = idusuario;
            return Datos.Eliminar(Datos);
        }


        public static DataTable BuscarNombre(string buscar)
        {
            CDUsuario Datos = new CDUsuario();
            Datos.Buscar = buscar;
            return Datos.BuscarNombre(Datos);
        }


        public static DataTable BuscarNombreUsuario(string buscar)
        {
            CDUsuario Datos = new CDUsuario();
            Datos.Buscar = buscar;
            return Datos.BuscarNombreUsuario(Datos);
        }

        public static DataTable Logeo(string usuario, string password)
        {
            CDUsuario Datos = new CDUsuario();
            Datos.Usuario = usuario;
            Datos.Password = password;
            return Datos.Logeo(Datos);
        }

    }
}
