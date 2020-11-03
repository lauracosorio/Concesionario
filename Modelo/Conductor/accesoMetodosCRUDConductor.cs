using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class accesoMetodosCRUDConductor
    {
        //Operacion INSERT
        public int InsertarConductor(int id, string nombre, string tipoLicencia, int idVehiculo, int idTipoConductor)
        {
            SqlCommand _comando = metodosCRUDConductor.crearInsertarConductor();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipoLicencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", idTipoConductor);

            return metodosCRUDConductor.ejecutarInsertarConductor(_comando);
        }

        //Operación SELECT
        public static DataTable listarConductor()
        {
            SqlCommand _comando = metodosCRUDConductor.crearSeleccionarConductor();
            _comando.CommandText = "select * from conductor";

            return metodosCRUDConductor.EjecutarSeleccionConductor(_comando);
        }

        //Operacion UPDATE
        public int modificarConductor(int id, string nombre, string tipoLicencia, int idVehiculo, int idTipoConductor)
        {
            SqlCommand _comando = metodosCRUDConductor.crearModificarConductor();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipoLicencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", idTipoConductor);

            return metodosCRUDConductor.ejecutarModificarConductor(_comando);
        }

        //Operacion DELETE
        public int borrarConductor(int id)
        {
            SqlCommand _comando = metodosCRUDConductor.crearBorrarConductor();

            _comando.Parameters.AddWithValue("@id", id);

            return metodosCRUDConductor.ejecutarBorrarConductor(_comando);
        }
    }
}
