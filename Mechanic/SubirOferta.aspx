<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SubirOferta.aspx.cs" Inherits="SubirOferta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Inicio.css" rel="stylesheet" type="text/css">
    <style>
        /* ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            overflow: hidden;
            border: 1px solid #e7e7e7;
            background-color: #f3f3f3;
        }

        li {
            float: right;
            text-decoration: none;
        }

        a {
            text-decoration: none;
            color: #666;
            text-align: center;
            display: block;
            padding: 14px 16px;
            height: 20px;
        }
          li a {
                display: block;
                color: #666;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                height: 100%;
            }

        li a:hover {
            background-color: #ddd;
        }

        .foto {
            height: 100px;
            width: 100px;
            border-radius: 50%;
        }*/
        .of:hover {
            background-color: #ddd;
        }

        .contenedor {
            text-align: center;
            margin-top: 30px;
            width: 26%;
            height: 121px;
            margin: 0px auto;
            height: auto;
        }
        .btn:hover {
            cursor:pointer;
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
                    <a>Nueva Oferta</a>
                    <br />
                    <br />
                    <asp:TextBox ID="nom" placeholder="Empresa" runat="server" required Height="30px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="ncontacto" placeholder="Nombre Contacto" required runat="server" Height="30px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="tel" placeholder="Telefono Contacto" required runat="server" Height="30px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="desc" placeholder="Descripcion Trabajo" required runat="server" Height="60px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <b>Disponible para:</b>
                    <asp:DropDownList ID="carrerasop" runat="server" Height="30px" Width="240px">
                        <asp:ListItem Value="1" Text="Fisica y Geociencias"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Matematicas y Estadistica"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Quimica y Biologia"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Enfermeria"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Medicina"></asp:ListItem>
                        <asp:ListItem Value="6" Text="Odontologia"></asp:ListItem>
                        <asp:ListItem Value="7" Text="Comunicacion Social"></asp:ListItem>
                        <asp:ListItem Value="8" Text="Economia"></asp:ListItem>
                        <asp:ListItem Value="9" Text="Humanidades y Filosofia"></asp:ListItem>
                        <asp:ListItem Value="10" Text="Psicologia"></asp:ListItem>
                        <asp:ListItem Value="11" Text="Ing. Civil y Ambiental"></asp:ListItem>
                        <asp:ListItem Value="12" Text="Ing. Electrica y Electronica"></asp:ListItem>
                        <asp:ListItem Value="13" Text="Ing. Industrial"></asp:ListItem>
                        <asp:ListItem Value="14" Text="Ing. Mecanica"></asp:ListItem>
                        <asp:ListItem Value="15" Text="Ing. Sistemas y Computacion"></asp:ListItem>
                        <asp:ListItem Value="16" Text="Musica"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:TextBox ID="sal" placeholder="Salario" required runat="server" Height="30px" Width="240px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Registrar" Height="40px" Width="140px" Font-Names="Berlin Sans FB" Font-Size="Larger" OnClick="Button1_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
