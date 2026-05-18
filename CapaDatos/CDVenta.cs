using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDVenta
    {
        public DateTime Fecha { get; set; }
        public string Serie { get; set; }
        public string Documento { get; set; }
        public string Tipo_Documento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public int Guardar(CDVenta ven)
        {
            int idGenerado = 0;
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand Cmd = new SqlCommand("sp_insertar_venta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Parámetro de salida configurado correctamente
                SqlParameter parIdVenta = new SqlParameter("@idventa", SqlDbType.Int);
                parIdVenta.Direction = ParameterDirection.Output;
                Cmd.Parameters.Add(parIdVenta);

                Cmd.Parameters.AddWithValue("@fecha", ven.Fecha);
                Cmd.Parameters.AddWithValue("@serie", ven.Serie);
                Cmd.Parameters.AddWithValue("@num_documento", ven.Documento);
                Cmd.Parameters.AddWithValue("@tipo_documento", ven.Tipo_Documento);
                Cmd.Parameters.AddWithValue("@subtotal", ven.Subtotal);
                Cmd.Parameters.AddWithValue("@iva", ven.Iva);
                Cmd.Parameters.AddWithValue("@total", ven.Total);
                Cmd.Parameters.AddWithValue("@estado", ven.Estado);
                Cmd.Parameters.AddWithValue("@idusuario", ven.IdUsuario);
                Cmd.Parameters.AddWithValue("@idcliente", ven.IdCliente);

                Cmd.ExecuteNonQuery();

                idGenerado = Convert.ToInt32(Cmd.Parameters["@idventa"].Value);
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

        public string InsertarDetalle(CDVenta ven)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand Cmd = new SqlCommand("sp_InsertarDetalleVenta", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@cantidad", ven.Cantidad);
                Cmd.Parameters.AddWithValue("@precio", ven.Precio);
                Cmd.Parameters.AddWithValue("@total", ven.Total);
                Cmd.Parameters.AddWithValue("@idventa", ven.IdVenta);
                Cmd.Parameters.AddWithValue("@idproducto", ven.IdProducto);

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


        public DataTable ConsultarVentasPorFecha(CDVenta ven)
        {
            DataTable dtResultado = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                SqlCommand Cmd = new SqlCommand("sp_consultar_ventas_fecha", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Pasamos las fechas asegurando el formato correcto para SQL
                Cmd.Parameters.AddWithValue("@fechaInicio", ven.FechaInicio);
                Cmd.Parameters.AddWithValue("@fechaFin", ven.FechaFin);

                SqlDataAdapter da = new SqlDataAdapter(Cmd);  
                da.Fill(dtResultado);
                return dtResultado;
            }

            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }      
        }


        public DataTable ReporteFactura(int idventa)
        {
            DataTable dtResultado = new DataTable();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = Conexion.Conn;
                SqlCommand Cmd = new SqlCommand("sp_reporte_factura", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Le enviamos el ID de la venta que el usuario quiere imprimir
                Cmd.Parameters.AddWithValue("@idventa", idventa);

                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                da.Fill(dtResultado);
                return dtResultado;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }
    }
}