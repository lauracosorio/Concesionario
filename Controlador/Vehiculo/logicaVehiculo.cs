using Modelo.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Vehiculo
{
   public class logicaVehiculo
    {
        //Metodo INSERT
        public int NegociarInsertarVehiculo(int id, string marca, string modelo, string matricula, int anio, int id_tipo_vehiculo )
        {
            accesoMetodoCRUDVehiculo NegociarAcceso = new accesoMetodoCRUDVehiculo();

            return NegociarAcceso.insertarVehiculo(id, marca, modelo, matricula, anio, id_tipo_vehiculo);
        }

        //Negociar SELECT

        public static DataTable NegociarSeleccionVehiculo()
        {
            return accesoMetodoCRUDVehiculo.listarVehiculo();

        }

        //Negociar UPDATE

        public int NegociarModificacionVehiculo(int id, string marca, string modelo, string matricula, int anio, int id_tipo_vehiculo)
        {
            accesoMetodoCRUDVehiculo NegociarAcceso = new accesoMetodoCRUDVehiculo();

            return NegociarAcceso.updateVehiculo(id, marca, modelo, matricula, anio, id_tipo_vehiculo);

        }

        //Negociar DELETE

        public int NegociarBorrarVehiculo(int id)
        {
            accesoMetodoCRUDVehiculo NegociarAcceso = new accesoMetodoCRUDVehiculo();

            return NegociarAcceso.deleteVehiculo(id);

        }
    }
}
