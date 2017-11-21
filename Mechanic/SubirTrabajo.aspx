<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SubirTrabajo.aspx.cs" Inherits="SubirTrabajo" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Inicio.css" rel="stylesheet" type="text/css">
    <style>
        .btn:hover {
            background-color: #ddd;
            cursor: pointer;
        }

        .contenedor {
            text-align: center;
            margin-top: 30px;
            width: 26%;
            height: 121px;
            margin: 0px auto;
            height: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor" style="display: inline; width: 100%;">
            <div class="derecha" style="">
                <ul>
                    <li style="padding-right: 30px;">&nbsp;</li>
                    <li>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Cerrar Sesión</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Buscar Amigos</asp:LinkButton></li>
                    <li style="height: 20px;">
                        <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">Buscar Empleo</asp:LinkButton></li>
                    <!-- <li style="padding-right: 50px;">
                            <asp:LinkButton ID="LinkButton5" runat="server"></asp:LinkButton>
                    </li>-->

                    <!--<li style="padding-top: 10px;">
                        <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="431px"></asp:TextBox></li>-->
                    <li style="padding: 0px 100px 0px 0px; float: left;">
                        <a style="background-color: white;" href="Index.aspx">
                            <img alt="" src="Imagenes/logotipo.png" style="width: 80px;" /></a></li>
                </ul>
            </div>
        </div>
        <div class="contenedor">
            <div style="margin: 0px auto; box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24); margin-top: 30px; background-color: white;">
                <div style="padding-top: 40px; padding-bottom: 40px; padding-left: 40px; padding-right: 40px;">
                    <a>Registrar Trabajo</a>
                    <br />
                    <br />
                    <asp:TextBox ID="nom" placeholder="Nombre de la empresa" runat="server" Height="30px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="car" placeholder="Cargo" runat="server" Height="30px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="fechaini" placeholder="Fecha inicial" TextMode="Date" runat="server" Height="30px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="fechafin" placeholder="Fecha final" TextMode="Date" runat="server" Height="30px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Registrar" Height="40px" Width="140px" Font-Names="Berlin Sans FB" Font-Size="Larger" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
