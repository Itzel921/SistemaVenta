using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCompra
    {
        public DateTime Fecha { get; set; }
        public string Documento { get; set; }
        public string Tipo_Documento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }
        public int IdProveedor { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }

        public int Guardar(CDCompra compra)
        {
            int idGenerado = 0;
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand Cmd = new SqlCommand("sp_insertar_compra", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Parámetro de salida configurado correctamente
                SqlParameter parIdCompra = new SqlParameter("@idcompra", SqlDbType.Int);
                parIdCompra.Direction = ParameterDirection.Output;
                Cmd.Parameters.Add(parIdCompra);

                Cmd.Parameters.AddWithValue("@fecha", compra.Fecha);
                Cmd.Parameters.AddWithValue("@num_documento", compra.Documento);
                Cmd.Parameters.AddWithValue("@tipo_documento", compra.Tipo_Documento);
                Cmd.Parameters.AddWithValue("@subtotal", compra.Subtotal);
                Cmd.Parameters.AddWithValue("@iva", compra.Iva);
                Cmd.Parameters.AddWithValue("@total", compra.Total);
                Cmd.Parameters.AddWithValue("@estado", compra.Estado);
                Cmd.Parameters.AddWithValue("@idusuario", compra.IdUsuario);
                Cmd.Parameters.AddWithValue("@idproveedor", compra.IdProveedor  );
                Cmd.ExecuteNonQuery();

                idGenerado = Convert.ToInt32(Cmd.Parameters["@idcompra"].Value);
            }
            catch (Exception ex)
            {
                idGenerado = 0;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return idGenerado;
        }

        public string InsertarDetalle(CDCompra compra)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand Cmd = new SqlCommand("sp_insertar_detalle_compra", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@cantidad", compra.Cantidad);
                Cmd.Parameters.AddWithValue("@precio", compra.Precio);
                Cmd.Parameters.AddWithValue("@total", compra.Total);
                Cmd.Parameters.AddWithValue("@idcompra", compra.IdCompra);
                Cmd.Parameters.AddWithValue("@idproducto", compra.IdProducto);

                Cmd.ExecuteNonQuery();
                resul = "OK";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return resul;
        }
    }
}