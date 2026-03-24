using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDProveedor
    {
        public int Idproveedor { get; set; }
        public string Razonsocial { get; set; }
        public string Dni { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Buscar { get; set; }


        public DataTable Listar()
        {
            DataTable resul = new DataTable("proveedor");
            SqlConnection conexion = new SqlConnection();

            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("splistar_proveedor", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Usar SqlDataAdapter para llenar el DataTable con los resultados del SP
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);  // Ejecuta el SP y llena el DataTable
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return resul;
        }



        public string Guardar(CDProveedor prov)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("spguardar_proveedor", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros del stored procedure
                Cmd.Parameters.AddWithValue("@idproveedor", SqlDbType.Int).Direction = ParameterDirection.Output;
                Cmd.Parameters.AddWithValue("@razonsocial", prov.Razonsocial);
                Cmd.Parameters.AddWithValue("@dni", prov.Dni);
                Cmd.Parameters.AddWithValue("@rfc", prov.Rfc);
                Cmd.Parameters.AddWithValue("@telefono", prov.Telefono);
                Cmd.Parameters.AddWithValue("@direccion", prov.Direccion);
                Cmd.Parameters.AddWithValue("@estado", prov.Estado);

                // Ejecutar el stored procedure
                // ExecuteNonQuery() retorna el número de filas afectadas
                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }



        public string Editar(CDProveedor prov)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("speditar_proveedor", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros del stored procedure
                Cmd.Parameters.AddWithValue("@idproveedor", prov.Idproveedor);
                Cmd.Parameters.AddWithValue("@razonsocial", prov.Razonsocial);
                Cmd.Parameters.AddWithValue("@dni", prov.Dni);
                Cmd.Parameters.AddWithValue("@rfc", prov.Rfc);
                Cmd.Parameters.AddWithValue("@telefono", prov.Telefono);
                Cmd.Parameters.AddWithValue("@direccion", prov.Direccion);
                Cmd.Parameters.AddWithValue("@estado", prov.Estado);

                // Ejecutar el stored procedure
                // ExecuteNonQuery() retorna el número de filas afectadas (debe ser 1)
                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }



        public DataTable BuscarDni(CDProveedor prov)
        {
            DataTable resul = new DataTable("proveedor");
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("spbuscar_proveedor_dni", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de búsqueda
                Cmd.Parameters.AddWithValue("@dni", prov.Buscar);

                // Usar SqlDataAdapter para llenar el DataTable con los resultados del SP
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);  // Ejecuta el SP y llena el DataTable con los resultados filtrados
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }



        public DataTable BuscarRazonSocial(CDProveedor prov)
        {
            DataTable resul = new DataTable("proveedor");
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("spbuscar_proveedor_razonsocial", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de búsqueda
                Cmd.Parameters.AddWithValue("@razonsocial", prov.Buscar);

                // Usar SqlDataAdapter para llenar el DataTable con los resultados del SP
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);  // Ejecuta el SP y llena el DataTable con los resultados filtrados
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }



        public string Eliminar(CDProveedor prov)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("speliminar_proveedor ", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro del stored procedure (solo necesita el ID)
                Cmd.Parameters.AddWithValue("@idproveedor", prov.Idproveedor);

                // Ejecutar el stored procedure
                // ExecuteNonQuery() retorna el número de filas afectadas (debe ser 1)
                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }


    }


}
