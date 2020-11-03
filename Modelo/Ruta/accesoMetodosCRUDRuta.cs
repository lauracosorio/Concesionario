using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
   public class accesoMetodosCRUDRuta
    {
        //Operacion INSERT
        public int InsertarRuta(int id, string estacion, int idVehiculo)
        {
            SqlCommand _comando = metodosCRUDRuta.InsertarRuta();
            
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);
            
            return metodosCRUDRuta.EjecutarInsertarRuta(_comando);
        }

        //Operación SELECT
        public static DataTable listarRuta()
        {
            SqlCommand _comando = metodosCRUDRuta.crearSeleccionRuta();
            _comando.CommandText = "select * from ruta";

            return metodosCRUDRuta.EjecutarSeleccionRuta(_comando);
        }

        //Operacion UPDATE
        public int modificarRuta (int id, string estacion, int idVehiculo)
        {
            SqlCommand _comando = metodosCRUDRuta.CrearModificacionRuta();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);

            return metodosCRUDRuta.EjecutarModificacionRuta(_comando);
        }

        //Operacion DELETE
        public int borrarRuta(int id)
        {
            SqlCommand _comando = metodosCRUDRuta.borrarRuta();

            _comando.Parameters.AddWithValue("@id", id);

            return metodosCRUDRuta.EjecutarBorrarRuta(_comando);
        }
    }
}
