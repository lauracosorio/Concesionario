using Modelo.TipoVehiculo;
using System;
using System.Collections.Generic;
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
    }
}
