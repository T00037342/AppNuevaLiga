<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="AppLaNuevaLiga.Web.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario</title>
    <style type="text/css">
        .container {
            height: 414px;
        }
        #Radio1 {
            margin-left: 0px;
        }
        #Select1 {
            width: 89px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1 align="center">Heroe o Villano</h1>
        <p align="center">Crea tu propio personaje de ficción, dale tu voluntad y furza para covatir con sus enemmigos.</p>
        <p align="center">Elige con sabiduría que camino tomar para recorrer tu vida.</p>

        <asp:Label Text="Que tipo de Personaje quieres ser?" runat="server" />

        <br />
        <br />
        <br />
        <asp:Button ID="BtnHumano" runat="server" Text="Humano" />
        <asp:Button ID="BtnSHumano" runat="server" Text="Super Humano" />
        <asp:Button ID="BtnAliens" runat="server" Text="Aliens" />
        <asp:Button ID="BtnArtificiales" runat="server" OnClick="Button4_Click" Text="Artificiales" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
