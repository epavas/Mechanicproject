<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Amigos.aspx.cs" Inherits="Amigos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
        .btn:hover {
            background-color: #ddd;
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
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click1">Buscar Mecanico</asp:LinkButton></li>
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
            <div class="perfil" style="">
                <asp:Label ID="Label3" runat="server" Text="Panel de Busqueda"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:RadioButton ID="RadioButton1" AutoPostBack="true" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" />&nbsp;<asp:RadioButton AutoPostBack="true" ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
                <br />
                <asp:RadioButton ID="RadioButton3" AutoPostBack="true" runat="server" OnCheckedChanged="RadioButton3_CheckedChanged" />&nbsp;<asp:RadioButton AutoPostBack="true" ID="RadioButton4" runat="server" OnCheckedChanged="RadioButton4_CheckedChanged" />
                &nbsp;<div style="width: 50%; margin: 0px auto;">
                    <br />
                    <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
                    <br />
                    <br />
                </div>
            </div>
            <div class="centro"  style="width: 70%; height: auto; background-color: white;">
                <asp:Label ID="Label4" runat="server" Text="Resultados:"></asp:Label>
                <br />
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
                <br />
            </div>
        </div>
    </form>
</body>
</html>
