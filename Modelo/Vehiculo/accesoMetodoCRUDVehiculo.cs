using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
   public class accesoMetodoCRUDVehiculo
    {
        //operacion INSERT
        public int insertarVehiculo(int id, string marca, string modelo, string matricula, int anio, int id_tipo_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.insertarVehiculo();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@matricula", matricula);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo);

            return MetodosCRUDVehiculo.ejecutarInsertarVehiculo(_comando);

        }

        //Operación SELECT
        public static DataTable listarVehiculo()
        {
            SqlCommand _comando = MetodosCRUDVehiculo.selecionarVehiculo();
            _comando.CommandText = "select * from vehiculo";

            return MetodosCRUDVehiculo.EjecutarSeleccionarVehiculo(_comando);
        }

        //Operacion UPDATE
        public int updateVehiculo(int id, string marca, string modelo, string matricula, int anio, int id_tipo_vehiculo)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.modificarVehiculo();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@matricula", matricula);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo);

            return MetodosCRUDVehiculo.EjecutarmodificacionVehiculo(_comando);
        }

        //Operacion DELETE
        public int deleteVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.borrarVehiculo();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDVehiculo.EjecutarBorrarVehiculo(_comando);
        }
    }
}
