<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aliens.aspx.cs" Inherits="AppLaNuevaLiga.Web.Aliens" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Aliens</title>
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
        .fooder {
            background-color:#0B0B3B;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="head">
        <div class="container">
            <h1 align="center" id="font1">Aliens</h1>
            <p align="center" id="font">Procedentes de planeta difente.</p>
            <p align="center" id="font">Yegados a la tierra para audar o destruir el mundo.</p>
       </div> 
    </div>
    <div class="container">
        <div class="row-fluid">
           <div class="span3">
               <img src="img/.png" alt="Heroe" />
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

               <h5>Debilidades:
                   <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                   </asp:RadioButtonList>
               </h5>
                   <asp:TextBox runat="server" />

               <h5>Armas:</h5>
                   <asp:TextBox runat="server" />
               
               <h5>Teenologia:</h5>
                   <asp:textbox runat="server" />
                
               <h5>Super Habilidades Naturales;</h5>
                   <asp:textbox runat="server" />

                <h5>Rasa:</h5>
                   <asp:textbox runat="server" />

                <h5>Planeta de Prosenncia:</h5>
                   <asp:textbox runat="server" />
               </center>

               <asp:Button Text="Enviar" runat="server" />
               <br />
               <br />
           </div>
           <div class="span3">
               <img src="img/alie.png" alt="Villano"/>
           </div>
       </div>
    </div>

    </form>


    <div class="fooder">
        <div class="container">
            <h4 align="center">Ⓒ Copyright Braulio and Luis Albrto</h4>
        </div>
    </div>
</body>
