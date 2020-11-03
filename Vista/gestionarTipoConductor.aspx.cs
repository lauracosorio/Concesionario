using Controlador.TipoConductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionarTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTC_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = TxtName.Text;

            logicaTipoConductor negocioInsertarTipoConductor = new logicaTipoConductor();

            int resultadoInsertarTipoConductor = negocioInsertarTipoConductor.NegociarInsertTipoConducto(id, nombre);

            if (resultadoInsertarTipoConductor > 0)
            {
                lblMensaje.Text = "Registro Éxitoso";
            }
            else
            {
                lblMensaje.Text = "No se pudo hacerle registro";
            }

            negocioInsertarTipoConductor = null;
        }

        protected void btnListTC_Click(object sender, EventArgs e)
        {
            gridView.DataSource = logicaTipoConductor.NegociarSeleccionTipoConductor();
            gridView.DataBind();
            txtId.Text = TxtName.Text = "";
        }

        protected void btnUpdateTC_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string nombre = TxtName.Text;

            logicaTipoConductor negocioModificarTipoConductor = new logicaTipoConductor();

            int resultadoModificarTipoConductor = negocioModificarTipoConductor.NegociarModificarTipoConductor(id, nombre);

            if (resultadoModificarTipoConductor > 0)
            {
                lblMensaje.Text = "Registro Actualizado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";
            }

            negocioModificarTipoConductor = null;
        }

        protected void btnDeleteTC_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);


            logicaTipoConductor negocioBorrarTipoConductor = new logicaTipoConductor();

            int resultadoBorrarTipoConductor = negocioBorrarTipoConductor.NegociarBorrarTipoConductor(id);

            if (resultadoBorrarTipoConductor > 0)
            {
                lblMensaje.Text = "Registro Eliminado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el registro";
            }

            negocioBorrarTipoConductor = null;
        }
    }
}