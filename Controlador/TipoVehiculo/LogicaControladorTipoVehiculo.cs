using Modelo.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoVehiculo
{
   public class LogicaControladorTipoVehiculo
    {
        //Metodo que nos permite negociar la inserción INSERT

        public int NegociarInsertTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDTipoVehiculo NegociarAcceso = new AccesoMetodosCRUDTipoVehiculo();

            return NegociarAcceso.InsertTipoVehiculo(id, name);

        }

        //Negociar SELECT

        public static DataTable NegociarSelectTipoVehiculo()
        {
            return AccesoMetodosCRUDTipoVehiculo.listTipoVehiculo();

        }

        //Negociar UPDATE
        public int NegociarUpdateTipoVehiculo(int id, string name)
        {
            AccesoMetodosCRUDTipoVehiculo NegociarAcceso = new AccesoMetodosCRUDTipoVehiculo();

            return NegociarAcceso.updateTipoVehiculo(id, name);

        }

        //Negociar DELETE

        public int NegociarDeleteTipoVehiculo(int id)
        {
            AccesoMetodosCRUDTipoVehiculo NegociarAcceso = new AccesoMetodosCRUDTipoVehiculo();

            return NegociarAcceso.deleteTipoVehiculo(id);

        }
    }
}
