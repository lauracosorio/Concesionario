using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
   public class AccesoMetodosCRUDTipoConductor
    {
        //Operacion INSERT
        public int InsertTipoConductor(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.InsertarTC();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDTipoConductor.EjecutarInsertarTC(_comando);
        }

        //Operación SELECT
        public static DataTable listTipoConductor()
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.crearSeleccionTC();
            _comando.CommandText = "select * from Tipo_conductor";

            return MetodosCRUDTipoConductor.EjecutarSeleccionTC(_comando);
        }

        //Operacion UPDATE
        public int updateTipoConductor(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.CrearModificacionTC();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUDTipoConductor.EjecutarModificacionTC(_comando);
        }

        //Operacion DELETE
        public int deleteTipoConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDTipoConductor.borrarTC();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDTipoConductor.EjecutarBorrarTC(_comando);
        }
    }
}
