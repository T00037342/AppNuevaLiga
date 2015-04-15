<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuperHumanos.aspx.cs" Inherits="AppLaNuevaLiga.Web.SuperHumanos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Super Humaos</title>
<link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <style type="text/css">
        #font1 {
            color:#FFFFFF;
            font:Algerian;
        }
        #font {
            color:#FFFFFF;
        }
        .head {
            background-color:#0B0B3B;
        }
        body {

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="head">
        <div class="container">
            <h1 align="center" id="font1">Super Humaos</h1>
            <p align="center" id="font">Humanos con cualidades especiales.</p>
            <p align="center" id="font">Nacidos o  Aqurido estas Atraves de acidentes o experimentos Fallidos </p>
       </div> 
    </div>
    <div class="container">
        <div class="row-fluid">
           <div class="span3">
               <img src="img/Araña.png" alt="Heroe" />
           </div>
           <div class="span6">
               <br />
               <center>
               <h5>Nombre Super:</h5>
               <asp:TextBox runat="server" />

               <h5>Heroe o Villano:</h5>
               <INPUT TYPE ="radio" NAME ="Tipe" VALUE="Heroe"> Heroe |  <INPUT TYPE ="radio" NAME ="Tipe" VALUE="Villano"> Villano

               <h5>Nombre o Identidad secreta:</h5>
               <asp:TextBox runat="server" />

               <h5>Trabajo:</h5>
               <asp:TextBox runat="server" />

               <h5>Lugar de Origen:</h5>
               <asp:TextBox runat="server" />

               <h5>Sexo:</h5>
               <INPUT TYPE ="radio" NAME ="sex" VALUE="Masculino"> M |  <INPUT TYPE ="radio" NAME ="sex" VALUE="Famenino"> F

               <h5>Abilidades:</h5>
               <asp:TextBox runat="server" />

               <h5>Debilidades:<asp:RadioButtonList ID="RadioButtonList1" runat="server">
                   </asp:RadioButtonList>
               </h5>
               <asp:TextBox runat="server" />

               <h5>Armas:</h5>
               <asp:TextBox runat="server" />


                <h5></h5>
               </center>

               <asp:Button Text="Enviar" runat="server" />
           </div>
           <div class="span3">
               <img src="img/oto.png" alt="Villano"/>
           </div>
       </div>
    </div>
    <div id="fooder">
        <div class="container">
            <h4 align="center">Ⓒ Copyright Braulio and Luis Albrto.</h4>
        </div>
    </div>
    </form>
</body>
</html>