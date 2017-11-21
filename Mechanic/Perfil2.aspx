<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Perfil2.aspx.cs" Inherits="Perfil" %>

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
    </style>
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet">
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" rel="stylesheet" integrity="sha256-MfvZlkHCEqatNoGiOXveE8FIwMzZg4W85qfrfIFBfYc= sha512-dTfge/zgoMYpP7QbHy4gWMEGsbsdZeCXz7irItjcC3sPUFtf0kuFbDz/ixG7ArTxmDjLXDmezHubeNikyKGVyQ==" crossorigin="anonymous">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
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
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Buscar Mecanico</asp:LinkButton></li>
                    <li style="height: 20px;">
                        </li>
                    <!--<li style="padding-right: 50px;">
                        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click"></asp:LinkButton>
                    </li>

                    <li style="padding-top: 10px;">
                        <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="431px"></asp:TextBox></li>-->
                    <li style="padding: 0px 100px 0px 0px; float: left;">
                        <a style="background-color: white;" href="Index.aspx">
                            <img alt="" src="Imagenes/logotipo.png" style="width: 80px;" /></a></li>
                </ul>
            </div>
        </div>
        <div class="row" style="margin-top: 10%">
            <div class="col-md-2" style="margin-left: 10%">
                <div class="card">
                    <i class="fa fa-address-card" style="font-size: 64px"></i>
                    <div class="card-block">
                        <h4 class="card-title">Informacion del usuario</h4>
                        <p class="card-text">
                            <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>&nbsp;<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Apellido: "></asp:Label>&nbsp;<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="Label3" runat="server" Text="Especialidad: "></asp:Label>&nbsp;<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="Label4" runat="server" Text="Esperiencia: "></asp:Label>&nbsp;<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                            <br />
                        </p>
                    </div>
                </div>
            </div>

            <div class="col-md-2" style="margin-left: 10%">
                <div class="card">
                    <i class="fa fa-briefcase" style="font-size: 64px"></i>
                    <div class="card-block">
                        <h4 class="card-title">Trabajos</h4>
                        <p class="card-text">
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Subir Comentarios</asp:LinkButton>


                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" ForeColor="#333333" GridLines="Vertical" PageSize="5" Width="100%" BorderColor="#333333" OnPageIndexChanging="GridView1_PageIndexChanging">
                                <AlternatingRowStyle BackColor="White" />
                                <EditRowStyle BackColor="#2461BF" BorderColor="Black" BorderStyle="Dotted" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                            </asp:GridView>
                        </p>
                    </div>
                </div>
            </div>
            <br />
            <!--<div class="col-md-2" style="margin-left: 10%">
                <div class="card">
                    <i class="fa fa-users" style="font-size: 64px"></i>
                    <div class="card-block">
                        <h4 class="card-title">Amigos</h4>
                        <p class="card-text">Juan</p>
                    </div>
                    <div class="card-block">
                        <i class="fa fa-address-book" style="font-size: 64px"></i>
                        <h4 class="card-title">sugerido</h4>
                        <p class="card-text">Pedro</p>
                    </div>
                </div>
            </div>-->
        </div>
    </form>
</body>
</html>
