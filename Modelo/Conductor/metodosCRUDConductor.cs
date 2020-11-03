using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
  public class metodosCRUDConductor
    {
        public static SqlCommand crearInsertarConductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("registrarConductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int ejecutarInsertarConductor(SqlCommand comando)
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

        public static SqlCommand crearSeleccionarConductor()
        {
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
        public static DataTable EjecutarSeleccionConductor(SqlCommand comando)
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

        public static SqlCommand crearModificarConductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            //crear la instrucción select
            SqlCommand _comando = new SqlCommand("updateConductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int ejecutarModificarConductor(SqlCommand comando)
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

        public static SqlCommand crearBorrarConductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            //crear la instrucción select
            SqlCommand _comando = new SqlCommand("deleteConductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        public static int ejecutarBorrarConductor(SqlCommand comando)
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
