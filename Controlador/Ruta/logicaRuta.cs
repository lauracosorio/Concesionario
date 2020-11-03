using Modelo.Ruta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Ruta
{
    public class logicaRuta
    {
        public int NegociarInsertarRuta(int id, string estacion, int idVehiculo)
        {
            accesoMetodosCRUDRuta NegociarInsercion = new accesoMetodosCRUDRuta();
            return NegociarInsercion.InsertarRuta(id, estacion, idVehiculo);
        }

        //Negociar SELECT

        public static DataTable NegociarSeleccionRuta()
        {
            return accesoMetodosCRUDRuta.listarRuta();
        }

        //Negociar UPDATE
        public int NegociarModificarRuta(int id, string estacion, int idVehiculo)
        {
            accesoMetodosCRUDRuta negociarModificacion = new accesoMetodosCRUDRuta();
            return negociarModificacion.modificarRuta(id,estacion, idVehiculo);
        }

        //Negociar DELETE

        public int NegociarBorrarRuta(int id)
        {
            accesoMetodosCRUDRuta negociarBorrar = new accesoMetodosCRUDRuta();
            return negociarBorrar.borrarRuta(id);
        }
    }
}
