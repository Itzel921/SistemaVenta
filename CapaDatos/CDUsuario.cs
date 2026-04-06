using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDUsuario
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Acceso { get; set; }
        public string Estado { get; set; }
        public int IdEmpleado { get; set; }
        public string Buscar { get; set; }


        public DataTable Listar()
        {
            DataTable resul = new DataTable("usuario");
            SqlConnection conexion = new SqlConnection();

            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("splistar_usuario", conexion);
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


        public string Guardar(CDUsuario usu)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("spguardar_usuario", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros del stored procedure
                Cmd.Parameters.AddWithValue("@idusuario", SqlDbType.Int).Direction = ParameterDirection.Output;  // Parámetro de salida
                Cmd.Parameters.AddWithValue("@usuario", usu.Usuario);
                Cmd.Parameters.AddWithValue("@pass", usu.Password);
                Cmd.Parameters.AddWithValue("@acceso", usu.Acceso);
                Cmd.Parameters.AddWithValue("@estado", usu.Estado);
                Cmd.Parameters.AddWithValue("@idempleado", usu.IdEmpleado);

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


        public string Editar(CDUsuario usu)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("speditar_usuario", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros del stored procedure
                Cmd.Parameters.AddWithValue("@idusuario", usu.IdUsuario);  // ID del usuario a actualizar
                Cmd.Parameters.AddWithValue("@usuario", usu.Usuario);
                Cmd.Parameters.AddWithValue("@pass", usu.Password);
                Cmd.Parameters.AddWithValue("@acceso", usu.Acceso);
                Cmd.Parameters.AddWithValue("@estado", usu.Estado);
                Cmd.Parameters.AddWithValue("@idempleado", usu.IdEmpleado);

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


        public string Eliminar(CDUsuario usu)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("speliminar_usuario", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro del stored procedure (solo necesita el ID)
                Cmd.Parameters.AddWithValue("@idusuario", usu.IdUsuario);

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


        public DataTable BuscarNombre(CDUsuario usu)
        {
            DataTable resul = new DataTable("usuario");
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("spbuscar_usuario_nombre", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de búsqueda
                Cmd.Parameters.AddWithValue("@nombre", usu.Buscar);

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


        public DataTable BuscarNombreUsuario(CDUsuario usu)
        {
            DataTable resul = new DataTable("usuario");
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("spbuscar_usuario_nombreusuario", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de búsqueda
                Cmd.Parameters.AddWithValue("@nombreusuario", usu.Buscar);

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


        public DataTable Logeo(CDUsuario usu)
        {
            DataTable resul = new DataTable("usuario");
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("spinicio_sesion", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de búsqueda
                Cmd.Parameters.AddWithValue("@usuario", usu.Usuario);
                Cmd.Parameters.AddWithValue("@password", usu.Password);

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

    }
}
