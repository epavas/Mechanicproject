<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

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
</head>
<body>
    <form id="form1" runat="server" style="m">
        <div class="contenedor" style="display: inline; width: 100%;">
            <div class="derecha" style="">
                <ul>
                    <li style="padding-right: 30px;">&nbsp;</li>
                    <li>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Cerrar Sesión</asp:LinkButton></li>
                    <li>
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Buscar Mecanico</asp:LinkButton></li>
                    <li>
                        </li>
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
        <div class="contenedor2">
            <br />
            <br />
            <br />
            <div class="perfil">
                <asp:Image ID="Image1" CssClass="foto" runat="server" ImageUrl="~/Imagenes/user-icon.png" />
                <asp:LinkButton ID="LinkButton1" CssClass="ver-perfil" runat="server" OnClick="LinkButton1_Click">Ver perfil</asp:LinkButton>
                <asp:Label ID="nombre" runat="server" Text="Nombre" ForeColor="#666666"></asp:Label>
                <br />
                <br />
                <br />
                <div style="width: 50%; margin: 0px auto;">
                    <asp:LinkButton ID="LinkButton2" CssClass="of" runat="server" OnClick="LinkButton2_Click1">Necesito Mecanico</asp:LinkButton>
                </div>
            </div>
            <div class="centro" style="width: 70%; height: auto; background-color: white;">
                <table>
                    <tr>
                        <td>Mecanicos Disponibles</td>
                    </tr>
                </table>                
                <br />
                <br />
                <tr>
                    <td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" Width="100%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField SelectText="Ver Perfil" ShowSelectButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
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
                    </td>
                </tr>

            </div>
        </div>

    </form>
</body>
</html>
