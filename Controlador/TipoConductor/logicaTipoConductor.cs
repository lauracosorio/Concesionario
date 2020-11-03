using Modelo.TipoConductor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoConductor
{
    public class logicaTipoConductor
    {
        //Metodo que nos permite negociar la inserción INSERT

        public int NegociarInsertTipoConducto(int id, string name)
        {
            AccesoMetodosCRUDTipoConductor NegociarInsercion = new AccesoMetodosCRUDTipoConductor();
            return NegociarInsercion.InsertTipoConductor(id, name);
        }

        //Negociar SELECT

        public static DataTable NegociarSeleccionTipoConductor()
        {
            return AccesoMetodosCRUDTipoConductor.listTipoConductor();
        }

        //Negociar UPDATE
        public int NegociarModificarTipoConductor(int id, string name)
        {
            AccesoMetodosCRUDTipoConductor negociarModificacion = new AccesoMetodosCRUDTipoConductor();
            return negociarModificacion.updateTipoConductor(id, name);
        }

        //Negociar DELETE

        public int NegociarBorrarTipoConductor(int id)
        {
            AccesoMetodosCRUDTipoConductor negociarBorrar = new AccesoMetodosCRUDTipoConductor();
            return negociarBorrar.deleteTipoConductor(id);
        }
    }
}
