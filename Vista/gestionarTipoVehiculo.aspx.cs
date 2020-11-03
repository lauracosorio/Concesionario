using Controlador.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionarTipoVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int idTipoVehiculo = Int32.Parse(txtId.Text);
            string nameTipoVehiculo = TxtName.Text;

            LogicaControladorTipoVehiculo negocioAddTipoVehiculo = new LogicaControladorTipoVehiculo();

            int resultadoAddTipoVehiculo = negocioAddTipoVehiculo.NegociarInsertTipoVehiculo(idTipoVehiculo, nameTipoVehiculo);

            if (resultadoAddTipoVehiculo > 0)
            {
                lblMensaje.Text = "Registro Éxitoso";
            }
            else
            {
                lblMensaje.Text = "No se pudo hacerle registro";
            }

            negocioAddTipoVehiculo = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            gridView.DataSource = LogicaControladorTipoVehiculo.NegociarSelectTipoVehiculo();
            gridView.DataBind();
            txtId.Text = TxtName.Text = "";
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int idTipoVehiculo = Int32.Parse(txtId.Text);
            string nameTipoVehiculo = TxtName.Text;

            LogicaControladorTipoVehiculo negocioUpdateTipoVehiculo = new LogicaControladorTipoVehiculo();

            int resultadoUpdateTipoVehiculo = negocioUpdateTipoVehiculo.NegociarUpdateTipoVehiculo(idTipoVehiculo, nameTipoVehiculo);

            if (resultadoUpdateTipoVehiculo > 0)
            {
                lblMensaje.Text = "Registro Actualizado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";
            }

            negocioUpdateTipoVehiculo = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int idTipoVehiculo = Int32.Parse(txtId.Text);


            LogicaControladorTipoVehiculo negocioDeleteTipoVehiculo = new LogicaControladorTipoVehiculo();

            int resultadoDeleteTipoVehiculo = negocioDeleteTipoVehiculo.NegociarDeleteTipoVehiculo(idTipoVehiculo);

            if (resultadoDeleteTipoVehiculo > 0)
            {
                lblMensaje.Text = "Registro Eliminado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el registro";
            }

            negocioDeleteTipoVehiculo = null;
        }
    }
         
}