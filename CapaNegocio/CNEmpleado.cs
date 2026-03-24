using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNEmpleado
    {
        public static DataTable Listar()
        {
            return new CDEmpleado().Listar();
        }


        public static string Guardar(string nombre, string apellidos, string dni, string telefono, string direccion, string estado)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Dni = dni;
            Datos.Telefono = telefono;
            Datos.Direccion = direccion;
            Datos.Estado = estado;

            return Datos.Guardar(Datos);
        }


        public static string Editar(int idempleado, string nombre, string apellidos, string dni, string telefono, string direccion, string estado)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.IdEmpleado = idempleado;
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Dni = dni;
            Datos.Telefono = telefono;
            Datos.Direccion = direccion;
            Datos.Estado = estado;

            return Datos.Editar(Datos);
        }


        public static string Eliminar(int idempleado)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.IdEmpleado = idempleado;
            return Datos.Eliminar(Datos);
        }


        public static DataTable BuscarNombre(string buscar)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.Buscar = buscar;
            return Datos.BuscarNombre(Datos);
        }


        public static DataTable BuscarDni(string buscar)
        {
            CDEmpleado Datos = new CDEmpleado();
            Datos.Buscar = buscar;
            return Datos.BuscarDni(Datos);
        }

    }
}
