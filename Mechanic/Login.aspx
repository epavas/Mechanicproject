<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Login.css" rel="stylesheet" />
    <style>
        .btn:hover {
            background-color: #ddd;
            cursor:pointer;
        }
        .btn {}
    </style>
</head>
<body style="background-color:rgba(230, 227, 227, 0.20)">
    <form id="form1" runat="server" style="">
        <div style="text-align:center; margin-top:40px;">
            <a href="">
                <img  alt="" src="Imagenes/logotipoHD.png" style="height: 61px; width: 184px" /></a>
        </div>
        <div class="contenedor">
            <div style="margin:0px auto; box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24); margin-top:30px; background-color:white;">
                <div style="padding-top:40px; padding-bottom:40px; padding-left:40px; padding-right:40px;">
                <asp:TextBox ID="TextBox1" placeholder="Correo" runat="server" Height="30px" Width="240"></asp:TextBox>
                <br />                                                                                  
                <br />
                <asp:TextBox ID="TextBox2" placeholder="Contraseña" runat="server" Height="30px" Width="240px"></asp:TextBox>
                <br />
                <br />
                <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Iniciar Sesión" Font-Names="Berlin Sans FB" Font-Size="Larger" ForeColor="#190000" Height="40px" Width="140px" />
                </div>
               
            </div>
        </div>
    </form>
</body>
</html>
