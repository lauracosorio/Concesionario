<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestionarTipoVehiculo.aspx.cs" Inherits="Vista.gestionarTipoVehiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
    <title>Concesionario</title>
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
                <li class="nav-item active">
                    <a class="nav-link" href="gestionarTipoVehiculo.aspx">Registro Tipo Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Registro Vehiculos</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Registro Tipo Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Registro Conductor</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Contrato</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Ruta</a>
                </li>
            </ul>
        </div>
    </nav>
    
    <div class="container">
        <br />
        <h1> Gestión Tipos de Vehiculos</h1>
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
                Name
            </label>
            <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-row">
            <div class="col-8">
                <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="btn btn-primary" OnClick="btnAdd_Click" />
            </div>
        </div>

        <div class="form-row">
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false">

            </asp:Label>

        </div>
    </form>

    </div>


</body>
</html>
