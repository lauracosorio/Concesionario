using System;
using System.Collections.Generic;
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
    }
}
