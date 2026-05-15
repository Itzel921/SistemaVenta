using CapaDatos;
using System;

namespace CapaNegocio
{
    public class CNVenta
    {
        public static int Guardar(DateTime fecha, string serie, string documento, string tipoDocumento, decimal subtotal, decimal iva, decimal total, string estado, int idUsuario, int idCliente)
        {
            CDVenta Datos = new CDVenta();
            Datos.Fecha = fecha;
            Datos.Serie = serie;
            Datos.Documento = documento;
            Datos.Tipo_Documento = tipoDocumento;
            Datos.Subtotal = subtotal;
            Datos.Iva = iva;
            Datos.Total = total;
            Datos.Estado = estado;
            Datos.IdUsuario = idUsuario;
            Datos.IdCliente = idCliente;

            return Datos.Guardar(Datos);
        }

        public static string InsertarDetalle(int idVenta, int idProducto, decimal cantidad, decimal precio, decimal totalLinea)
        {
            CDVenta Datos = new CDVenta();
            Datos.IdVenta = idVenta;
            Datos.IdProducto = idProducto;
            Datos.Cantidad = cantidad;
            Datos.Precio = precio;
            Datos.Total = totalLinea;

            return Datos.InsertarDetalle(Datos);
        }
    }
}