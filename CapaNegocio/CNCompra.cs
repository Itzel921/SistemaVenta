using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCompra
    {
        public static int Guardar(DateTime fecha, string documento, string tipoDocumento, decimal subtotal, decimal iva, decimal total, string estado, int idUsuario, int idproveedor)
        {
            CDCompra Datos = new CDCompra();
            Datos.Fecha = fecha;
            Datos.Documento = documento;
            Datos.Tipo_Documento = tipoDocumento;
            Datos.Subtotal = subtotal;
            Datos.Iva = iva;
            Datos.Total = total;
            Datos.Estado = estado;
            Datos.IdUsuario = idUsuario;
            Datos.IdProveedor = idproveedor;

            return Datos.Guardar(Datos);
        }

        public static string InsertarDetalle(int idCompra, int idProducto, decimal cantidad, decimal precio, decimal totalLinea)
        {
            CDCompra Datos = new CDCompra();
            Datos.IdCompra = idCompra;
            Datos.IdProducto = idProducto;
            Datos.Cantidad = cantidad;
            Datos.Precio = precio;
            Datos.Total = totalLinea;

            return Datos.InsertarDetalle(Datos);
        }
    }
}
