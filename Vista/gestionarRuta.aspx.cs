using Controlador.Ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionarRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddRuta_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string estacion = TxtEstacion.Text;
            int idVehiculo = Int32.Parse(TxtIdV.Text);
            

            logicaRuta negocioInsertarRuta = new logicaRuta();

            int resultadoInsertarRuta = negocioInsertarRuta.NegociarInsertarRuta(id, estacion, idVehiculo);

            if (resultadoInsertarRuta > 0)
            {
                lblMensaje.Text = "Registro Éxitoso";
            }
            else
            {
                lblMensaje.Text = "No se pudo hacerle registro";
            }

            negocioInsertarRuta = null;
        }

        protected void btnListRuta_Click(object sender, EventArgs e)
        {
            gridView.DataSource = logicaRuta.NegociarSeleccionRuta();
            gridView.DataBind();
            txtId.Text = TxtEstacion.Text = TxtIdV.Text = "";
        }

        protected void btnUpdateRuta_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string estacion = TxtEstacion.Text;
            int idVehiculo = Int32.Parse(TxtIdV.Text);
            

            logicaRuta negocioModificarRuta = new logicaRuta();

            int resultadoModificarRuta = negocioModificarRuta.NegociarModificarRuta(id, estacion, idVehiculo);

            if (resultadoModificarRuta > 0)
            {
                lblMensaje.Text = "Registro Actualizado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";
            }

            negocioModificarRuta = null;
        }

        protected void btnDeleteRuta_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);


            logicaRuta negocioBorrarRuta = new logicaRuta();

            int resultadoBorrarRuta = negocioBorrarRuta.NegociarBorrarRuta(id);

            if (resultadoBorrarRuta > 0)
            {
                lblMensaje.Text = "Registro Eliminado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el registro";
            }

            negocioBorrarRuta = null;
        }
    }
}