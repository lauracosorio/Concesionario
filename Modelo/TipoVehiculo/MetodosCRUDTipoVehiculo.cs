using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class MetodosCRUDTipoVehiculo
    {
        //crear metodo que permita ejecutar procedimientos almacenados 
        //crear tipo comando INSERT
        public static SqlCommand crearComandoTipoProcedimientoAlmacenadoInsertarTV() 
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            
            SqlCommand _comando = new SqlCommand("registrarTipoVehiculo", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar el tipo de comando INSERT
        public static int EjecutarComandoTipoProcedimientoAlmacenadoInsertarTV(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            } catch
            {
                throw;
            } finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
