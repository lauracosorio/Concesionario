using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    class MetodosCRUDVehiculo
    {
        //comando INSERT
        public static SqlCommand insertarVehiculo()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("registrarVehiculo", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int ejecutarInsertarVehiculo(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        //crear tipo comando SELECT
        public static SqlCommand selecionarVehiculo()
        {
            //usar la conexión
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //crear la instrucción select
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;

            return _comando;
        }

        //Ejecutar el tipo de comando SELECT
        public static DataTable EjecutarSeleccionarVehiculo(SqlCommand comando)
        {
            DataTable _table = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                comando.Connection.Close();
            }

            return _table;
        }

        //crear tipo comando Update
        public static SqlCommand modificarVehiculo()
        {
            //usar la conexión
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            //crear la instrucción select
            SqlCommand _comando = new SqlCommand("updateVehiculo", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando Update
        public static int EjecutarmodificacionVehiculo(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }

        }

        //crear tipo comando DELETE
        public static SqlCommand borrarVehiculo()
        {
            //usar la conexión
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            //crear la instrucción select
            SqlCommand _comando = new SqlCommand("deleteVehiculo", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando DELETE
        public static int EjecutarBorrarVehiculo(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }

        }
    }
}
