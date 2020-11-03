<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestionarTipoConductor.aspx.cs" Inherits="Vista.gestionarTipoConductor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
    <title>Tipo Conductor</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">
            Concesionario
        </a>
    </nav>
    <nav class="navbar navbar-expand-lg navbar-ligth bg-light">
        <div class=" collapse navbar-collapse" id="navbarNav">
              <ul class="navbar-nav ">
                <li class="nav-item">
                    <a class="nav-link" href="gestionarTipoVehiculo.aspx">Registro Tipo Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarVehiculos.aspx">Registro Vehiculos</a>
                </li>
                <li class="nav-item active">
                    <a class="nav-link" href="gestionarTipoConductor.aspx">Registro Tipo Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarConductor.aspx">Registro Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarContrato.aspx">Contrato</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="gestionarRuta.aspx">Ruta</a>
                </li>
            </ul>
        </div>
    </nav>
    
    <div class="container">
        <br />
        <h1> Gestión Tipo de Conductor</h1>
        <br />

    <form id="form1" runat="server">
        <div class="form-group">
            <label for="txtId">
                Id
            </label>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

         <div class="form-group">
            <label for="txtName">
                Nombre
            </label>
            <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-row">
            <div class="col-8">
                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-success" OnClick="btnAddTC_Click" />
            </div>
            <div class ="text-right col-4">
                <asp:Button ID="btnList" runat="server" Text="List" class="btn btn-primary" OnClick ="btnListTC_Click"/>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-warning" OnClick ="btnUpdateTC_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-danger" OnClick ="btnDeleteTC_Click" />
            </div>
        </div>


        

        <div class="form-row">
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false">
            </asp:Label>
        </div>
        <br />

        <table class="table">
            <tr>
                <th>
                    <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="Id"/>
                            <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                        </Columns>
                    </asp:GridView>
                </th>
            </tr>
        </table>
    </form>
  </div>
</body>
</html>
