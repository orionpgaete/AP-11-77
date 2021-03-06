<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HolaMundoWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="form-group">
                <!-- Es un HTMLElement -->
                <h1 class="text-success" runat="server" id="mensajeH1" >Hola Mundo mi pagina mas bkan de ASP.net</h1>
            </div>
            
            <div class="form-group">
                <label for="nombreTxt">Nombre :</label>
                <asp:TextBox runat="server" ID="nombreTxt" CssClass="form-control"></asp:TextBox>

            </div>

            <div class="form-group">
                <!-- es un componente ASP.NET-->
                <asp:Button CssClass="btn btn-primary" OnClick="saludarBtn_Click" runat="server" ID="saludarBtn" Text="Saludame" />
            </div>
            
        </div>
    </form>
    <!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
</body>
</html>
