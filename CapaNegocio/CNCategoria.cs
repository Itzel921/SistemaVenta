using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocio
{
    public class CNCategoria
    {
        public static DataTable Listar()
        {
           return new CDCategoria().Listar();
        }

        public static string Guardar(string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Descripcion = descripcion;

            return Datos.Guardar(Datos);
        }

        public static string Editar(int idcategoria, string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idcategoria;
            Datos.Descripcion = descripcion;

            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idcategoria)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idcategoria;
            return Datos.Eliminar(Datos);
        }

        // MÉTODO PARA BUSCAR CLIENTES POR NOMBRE
        // Parámetro: texto a buscar en el nombre

        public static DataTable BuscarNombre(string buscar)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Buscar = buscar;
            return Datos.BuscarNombre(Datos);
        }
    }
}

