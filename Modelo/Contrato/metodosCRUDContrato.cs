using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
   public class metodosCRUDContrato
    {
        public static SqlCommand InsertarContrato()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("registrarContrato", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando INSERT
        public static int EjecutarInsertarContrato(SqlCommand comando)
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
        public static SqlCommand crearSeleccionContrato()
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
        public static DataTable EjecutarSeleccionContrato(SqlCommand comando)
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
        public static SqlCommand CrearModificacionContrato()
        {
            //usar la conexión
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            //crear la instrucción select
            SqlCommand _comando = new SqlCommand("updateContrato", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando Update
        public static int EjecutarModificacionContrato(SqlCommand comando)
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
        public static SqlCommand borrarContrato()
        {
            //usar la conexión
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            //crear la instrucción select
            SqlCommand _comando = new SqlCommand("deleteContrato", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando DELETE
        public static int EjecutarBorrarContrato(SqlCommand comando)
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
