using Controlador.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionarContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddContrato_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int idVehiculo = Int32.Parse(TxtIdV.Text);
            int idTipoConductor = Int32.Parse(TxtIdTC.Text);

            logicaContrato negocioInsertarContrato = new logicaContrato(); 

            int resultadoInsertarContrato = negocioInsertarContrato.NegociarInsertarContrato(id, idVehiculo, idTipoConductor);

            if (resultadoInsertarContrato > 0)
            {
                lblMensaje.Text = "Registro Éxitoso";
            }
            else
            {
                lblMensaje.Text = "No se pudo hacerle registro";
            }

            negocioInsertarContrato = null;
        }

        protected void btnListContrato_Click(object sender, EventArgs e)
        {
            gridView.DataSource = logicaContrato.NegociarSeleccionContrato();
            gridView.DataBind();
            txtId.Text  = TxtIdV.Text = TxtIdTC.Text = "";
        }

        protected void btnUpdateContrato_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int idVehiculo = Int32.Parse(TxtIdV.Text);
            int idTipoConductor = Int32.Parse(TxtIdTC.Text);

            logicaContrato negocioModificarContrato = new logicaContrato();

            int resultadoModificarContrato = negocioModificarContrato.NegociarModificarContrato(id, idVehiculo, idTipoConductor);

            if (resultadoModificarContrato > 0)
            {
                lblMensaje.Text = "Registro Actualizado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";
            }

            negocioModificarContrato = null;
        }

        protected void btnDeleteContrato_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);


            logicaContrato negocioBorrarContrato = new logicaContrato();

            int resultadoBorrarContrato = negocioBorrarContrato.NegociarBorrarContrato(id);

            if (resultadoBorrarContrato > 0)
            {
                lblMensaje.Text = "Registro Eliminado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el registro";
            }

            negocioBorrarContrato = null;
        }
    }
}