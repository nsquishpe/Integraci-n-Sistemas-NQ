<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pelicula.aspx.cs" Inherits="FrontRP.Pelicula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="HojasEstilo/Estilo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Gestionar Películas</h1>
            <asp:Label ID="Label1" runat="server" Text="Ingresar ID:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" class="botones" Text="Buscar" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <div>
            <h1>CRUD Películas</h1>
            <asp:Label ID="Label2" runat="server" Text="ID:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="NOMBRE:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="DIRECTOR:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="GÉNERO:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="Crear" class="botones" runat="server" Text="Crear Nuevo" OnClick="Crear_Click" />
        &nbsp;&nbsp;
            <asp:Button ID="Actualizar" class="botones" runat="server" Text="Actualizar" OnClick="Actualizar_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Eliminar" class="botones" runat="server" Text="Eliminar" OnClick="Eliminar_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" class="botonbusc" Text="Volver" PostBackUrl="~/Index.aspx" />
        </div>
    </form>
</body>
</html>
