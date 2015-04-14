<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="AppLaNuevaLiga.Web.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1 align="center">Heroe o Villano</h1>
        <p align="center">Crea tu propio personaje de ficción, dale tu voluntad y furza para covatir con sus enemmigos.</p>
        <p align="center">Elige con sabiduría que camino tomar para recorrer tu vida.</p>

        <asp:Label Text="Nombre del Heroe o Villano:" runat="server" />

        <asp:TextBox ID="NombretBox" runat="server" Text='<%# Bind("Nombre") %>' OnTextChanged="NombretBox_TextChanged" />

        <asp:Label Text="Tipo:" runat="server" '<%# Bind("Tipo") %>' OnTextChanged="TipotBox_TextChanged"/>

        <asp:TextBox ID="TipotBox" runat="server" text/>

    </div>
    </form>
</body>
</html>
