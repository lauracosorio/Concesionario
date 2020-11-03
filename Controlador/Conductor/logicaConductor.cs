using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class logicaConductor
    {
        //Metodo que nos permite negociar la inserción INSERT

        public int negociarInsertarConductor(int id, string nombre, string tipoLicencia, int idVehiculo, int idTipoConductor)
        {
            accesoMetodosCRUDConductor NegociarInsercion = new accesoMetodosCRUDConductor();
            return NegociarInsercion.InsertarConductor(id, nombre, tipoLicencia, idVehiculo, idTipoConductor);
        }

        //Negociar SELECT

        public static DataTable NegociarSeleccionConductor()
        {
            return accesoMetodosCRUDConductor.listarConductor();
        }

        //Negociar UPDATE
        public int NegociarModificarTipoVehiculo(int id, string nombre, string tipoLicencia, int idVehiculo, int idTipoConductor)
        {
            accesoMetodosCRUDConductor negociarModificar = new accesoMetodosCRUDConductor();
            return negociarModificar.modificarConductor(id, nombre, tipoLicencia, idVehiculo, idTipoConductor);
        }

        //Negociar DELETE

        public int NegociarBorrarTipoConductor(int id)
        {
            accesoMetodosCRUDConductor negociarBorrar = new accesoMetodosCRUDConductor();
            return negociarBorrar.borrarConductor(id);
        }
    }
}
