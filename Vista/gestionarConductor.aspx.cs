using Modelo.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionarConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddC_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = TxtNombre.Text;
            string tipoLicencia = TxtLicencia.Text;
            int idVehiculo = Int32.Parse(TxtIdV.Text);
            int idTipoConductor = Int32.Parse(TxtITC.Text);

            logicaConductor negocioInsertarConductor = new logicaConductor();

            int resultadoInsertarConductor = negocioInsertarConductor.negociarInsertarConductor(id, nombre,tipoLicencia,idVehiculo,idTipoConductor);

            if (resultadoInsertarConductor > 0)
            {
                lblMensaje.Text = "Registro Éxitoso";
            }
            else
            {
                lblMensaje.Text = "No se pudo hacerle registro";
            }

            negocioInsertarConductor = null;
        }

        protected void btnListC_Click(object sender, EventArgs e)
        {
            gridView.DataSource = logicaConductor.NegociarSeleccionConductor();
            gridView.DataBind();
            txtId.Text = TxtNombre.Text = TxtLicencia.Text = TxtIdV.Text = TxtITC.Text = "";
        }

        protected void btnUpdateC_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = TxtNombre.Text;
            string tipoLicencia = TxtLicencia.Text;
            int idVehiculo = Int32.Parse(TxtIdV.Text);
            int idTipoConductor = Int32.Parse(TxtITC.Text);

            logicaConductor negocioModificarConductor = new logicaConductor();

            int resultadoModificarConductor = negocioModificarConductor.NegociarModificarTipoVehiculo(id,nombre,tipoLicencia,idVehiculo,idTipoConductor);

            if (resultadoModificarConductor > 0)
            {
                lblMensaje.Text = "Registro Actualizado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";
            }

            negocioModificarConductor = null;
        }

        protected void btnDeleteC_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);


            logicaConductor negocioBorrarConductor = new logicaConductor();

            int resultadoBorrarConductor = negocioBorrarConductor.NegociarBorrarTipoConductor(id) ;

            if (resultadoBorrarConductor > 0)
            {
                lblMensaje.Text = "Registro Eliminado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el registro";
            }

            negocioBorrarConductor = null;
        }
    }
}