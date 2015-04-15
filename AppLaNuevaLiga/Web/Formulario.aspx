<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="AppLaNuevaLiga.Web.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario</title>
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
            <h1 align="center" id="font1">Heroe o Villano</h1>
            <p align="center" id="font">Crea tu propio personaje de ficción, dale tu voluntad y furza para covatir con sus enemigos.</p>
            <p align="center" id="font">Elige con sabiduría que camino tomar para recorrer tu vida.</p>
       </div> 
    </div>
        <br />
        <br />
   <div class="container">
       <div class="row-fluid">
           <div class="span3">
               <img src="img/sman.png" alt="Heroe" />
           </div>
           <div class="span6">
               <br />
               <br />
               <h3 align="center">Que deseas ser:</h3>
               <center>
                    <a href="Humano.aspx">Humano</a> &nbsp | &nbsp
                    <a href="SuperHumano.aspx">Super Humano</a> &nbsp | &nbsp
                    <a href="Aliens.aspx">Aliens</a> &nbsp | &nbsp
                    <a href="Artificiales.aspx">Artificiales</a> 
               </center>
           </div>
           <div class="span3">
               <img src="img/lex.png" alt="Villano"/>
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
