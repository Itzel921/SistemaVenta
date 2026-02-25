using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProducto
    {

        public static DataTable Listar()
        {
            return new CDProducto().Listar();
        }

        public static string Guardar(string codigo, string nombre, string descripcion, DateTime fingreso, DateTime fvencimiento, double pcompra, double pventa, int stock, string estado, int idcategoria)
        {
            CDProducto Datos = new CDProducto();
            Datos.Codigo = codigo;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Fvencimiento = fvencimiento;
            Datos.Pcompra = pcompra;
            Datos.Pventa = pventa;
            Datos.Stock = stock;
            Datos.Estado = estado;
            Datos.IdCategoria = idcategoria;


            return Datos.Guardar(Datos);
        }

        public static string Editar(int idproducto, string codigo, string nombre, string descripcion, DateTime fingreso, DateTime fvencimiento, double pcompra, double pventa, int stock, string estado, int idcategoria)
        {
            CDProducto Datos = new CDProducto();
            Datos.IdProducto = idproducto;
            Datos.Codigo = codigo;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Fvencimiento = fvencimiento;
            Datos.Pcompra = pcompra;
            Datos.Pventa = pventa;
            Datos.Stock = stock;
            Datos.Estado = estado;
            Datos.IdCategoria = idcategoria;


            return Datos.Editar(Datos);
        }

        public static string Eliminar(int idproducto)
        {
            CDProducto Datos = new CDProducto();
            Datos.IdProducto = idproducto;
            return Datos.Eliminar(Datos);
        }

        // MÉTODO PARA BUSCAR CLIENTES POR NOMBRE
        // Parámetro: texto a buscar en el nombre

        public static DataTable BuscarNombre(string textobuscar)
        {
            CDProducto Datos = new CDProducto();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }

        public static DataTable BuscarCodigo(string textobuscar)
        {
            CDProducto Datos = new CDProducto();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }

    }
}
