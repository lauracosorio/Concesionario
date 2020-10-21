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
            
            if(resultadoAddTipoVehiculo > 0)
            {
                lblMensaje.Text = "Registro Éxitoso";
            } else
            {
                lblMensaje.Text = "No se pudo hacerle registro";
            }

            negocioAddTipoVehiculo = null;
            

        }

     
    }
}