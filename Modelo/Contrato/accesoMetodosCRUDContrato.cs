using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
   public class accesoMetodosCRUDContrato
    {
        //Operacion INSERT
        public int InsertarContrato(int id, int idVehiculo, int idTipoConductor)
        {
            SqlCommand _comando = metodosCRUDContrato.InsertarContrato();
            
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", idTipoConductor);

            return metodosCRUDContrato.EjecutarInsertarContrato(_comando);
        }

        //Operación SELECT
        public static DataTable listarContrato()
        {
            SqlCommand _comando = metodosCRUDContrato.crearSeleccionContrato();
            _comando.CommandText = "select * from contrato";

            return metodosCRUDContrato.EjecutarSeleccionContrato(_comando);
        }

        //Operacion UPDATE
        public int modificarContrato(int id, int idVehiculo, int idTipoConductor)
        {
            SqlCommand _comando = metodosCRUDContrato.CrearModificacionContrato();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", idTipoConductor);

            return metodosCRUDContrato.EjecutarModificacionContrato(_comando);
        }

        //Operacion DELETE
        public int borrarContrato(int id)
        {
            SqlCommand _comando = metodosCRUDContrato.borrarContrato();

            _comando.Parameters.AddWithValue("@id", id);

            return metodosCRUDContrato.EjecutarBorrarContrato(_comando);
        }

    }
}
