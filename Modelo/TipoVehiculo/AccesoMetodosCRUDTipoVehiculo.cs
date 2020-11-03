using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class AccesoMetodosCRUDTipoVehiculo
    {
        //Operacion INSERT
        public int InsertTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDTipoVehiculo.crearComandoTipoProcedimientoAlmacenadoInsertarTV();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDTipoVehiculo.EjecutarComandoTipoProcedimientoAlmacenadoInsertarTV(_comando);
        }
    
        //Operación SELECT
        public static DataTable listTipoVehiculo()
        {
            SqlCommand _comando = MetodosCRUDTipoVehiculo.crearComandoSelectTV();
            _comando.CommandText = "select * from Tipo_Vehiculo";

            return MetodosCRUDTipoVehiculo.EjecutarComandoSelectTV(_comando);
        }

        //Operacion UPDATE
        public int updateTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDTipoVehiculo.CrearComandoUpdateTV();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDTipoVehiculo.EjecutarComandoUpdateTV(_comando);
        }

        //Operacion DELETE
        public int deleteTipoVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDTipoVehiculo.CrearComandoDeleteTV();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDTipoVehiculo.EjecutarComandoDeleteTV(_comando);
        }
    }
}
