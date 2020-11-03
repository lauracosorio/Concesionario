using Modelo.Contrato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Contrato
{
    public class logicaContrato
    {
        //Metodo que nos permite negociar la inserción INSERT

        public int NegociarInsertarContrato(int id, int idVehiculo, int idTipoConductor)
        {
            accesoMetodosCRUDContrato NegociarInsercion = new accesoMetodosCRUDContrato();
            return NegociarInsercion.InsertarContrato(id, idVehiculo, idTipoConductor);
        }

        //Negociar SELECT

        public static DataTable NegociarSeleccionContrato()
        {
            return accesoMetodosCRUDContrato.listarContrato();
        }

        //Negociar UPDATE
        public int NegociarModificarContrato(int id, int idVehiculo, int idTipoConductor)
        {
            accesoMetodosCRUDContrato negociarModificacion = new accesoMetodosCRUDContrato();
            return negociarModificacion.modificarContrato(id, idVehiculo, idTipoConductor);
        }

        //Negociar DELETE

        public int NegociarBorrarContrato(int id)
        {
            accesoMetodosCRUDContrato negociarBorrar = new accesoMetodosCRUDContrato();
            return negociarBorrar.borrarContrato(id);
        }
    }
}
