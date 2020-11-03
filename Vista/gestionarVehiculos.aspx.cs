using Controlador.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class gestionarVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddV_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string marca = TxtMarca.Text;
            string modelo = TxtModelo.Text;
            string matricula = TxtMatricula.Text;
            int anio = Int32.Parse(TxtAnio.Text);
            int idTipoVehiculo = Int32.Parse(TxtIDV.Text);


            logicaVehiculo negociarInsertarVehiculo = new logicaVehiculo();

            int resultadoInsertarVehiculo = negociarInsertarVehiculo.NegociarInsertarVehiculo(id, marca, modelo, matricula, anio, idTipoVehiculo);

            if (resultadoInsertarVehiculo > 0)
            {
                lblMensaje.Text = "Registro Éxitoso";
            }
            else
            {
                lblMensaje.Text = "No se pudo hacerle registro";
            }

            negociarInsertarVehiculo = null;
        }

        protected void btnListV_Click(object sender, EventArgs e)
        {
            gridView.DataSource = logicaVehiculo.NegociarSeleccionVehiculo();
            gridView.DataBind();
            txtId.Text = TxtMarca.Text = TxtModelo.Text = TxtMatricula.Text = TxtAnio.Text = TxtIDV.Text = "";
        }

        protected void btnUpdateV_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string marca = TxtMarca.Text;
            string modelo = TxtModelo.Text;
            string matricula = TxtMatricula.Text;
            int anio = Int32.Parse(TxtAnio.Text);
            int idTipoVehiculo = Int32.Parse(TxtIDV.Text);

            logicaVehiculo negociarModificacionVehiculo = new logicaVehiculo();

            int resultadoModificacionVehiculo = negociarModificacionVehiculo.NegociarModificacionVehiculo(id, marca, modelo, matricula, anio, idTipoVehiculo);

            if (resultadoModificacionVehiculo > 0)
            {
                lblMensaje.Text = "Registro Actualizado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo actualizar el registro";
            }

            negociarModificacionVehiculo = null;
        }

        protected void btnDeleteV_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);


            logicaVehiculo negocioBorrarVehiculo = new logicaVehiculo();

            int resultadoBorrarVehiculo = negocioBorrarVehiculo.NegociarBorrarVehiculo(id);

            if (resultadoBorrarVehiculo > 0)
            {
                lblMensaje.Text = "Registro Eliminado Exitosamente";
            }
            else
            {
                lblMensaje.Text = "No se pudo eliminar el registro";
            }

            negocioBorrarVehiculo = null;
        }
    }
}