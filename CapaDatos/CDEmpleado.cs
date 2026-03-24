using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDEmpleado
    {

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string Buscar { get; set; }



        public DataTable Listar()
        {
            DataTable resul = new DataTable("empleado");
            SqlConnection conexion = new SqlConnection();

            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPListar_empleado", conexion);
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


        public string Guardar(CDEmpleado emp)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPGuardar_empleado", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros del stored procedure
                Cmd.Parameters.AddWithValue("@idempleado", SqlDbType.Int).Direction = ParameterDirection.Output;  // Parámetro de salida
                Cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
                Cmd.Parameters.AddWithValue("@apellidos", emp.Apellidos);
                Cmd.Parameters.AddWithValue("@dni", emp.Dni);
                Cmd.Parameters.AddWithValue("@telefono", emp.Telefono);
                Cmd.Parameters.AddWithValue("@direccion", emp.Direccion);
                Cmd.Parameters.AddWithValue("@estado", emp.Estado);

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


        public string Editar(CDEmpleado emp)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPEditar_empleado", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros del stored procedure
                Cmd.Parameters.AddWithValue("@idempleado", emp.IdEmpleado);  // ID del cliente a actualizar
                Cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
                Cmd.Parameters.AddWithValue("@apellidos", emp.Apellidos);
                Cmd.Parameters.AddWithValue("@dni", emp.Dni);
                Cmd.Parameters.AddWithValue("@telefono", emp.Telefono);
                Cmd.Parameters.AddWithValue("@direccion", emp.Direccion);
                Cmd.Parameters.AddWithValue("@estado", emp.Estado);

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


        public string Eliminar(CDEmpleado emp)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPEliminar_empleado", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro del stored procedure (solo necesita el ID)
                Cmd.Parameters.AddWithValue("@idempleado", emp.IdEmpleado);

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


        public DataTable BuscarNombre(CDEmpleado emp)
        {
            DataTable resul = new DataTable("empleado");
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPBuscar_empleado_nombre", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de búsqueda
                Cmd.Parameters.AddWithValue("@nombre", emp.Buscar);

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


        public DataTable BuscarDni(CDEmpleado emp)
        {
            DataTable resul = new DataTable("empleado");
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPBuscar_empleado_dni", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de búsqueda
                Cmd.Parameters.AddWithValue("@dni", emp.Buscar);

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
