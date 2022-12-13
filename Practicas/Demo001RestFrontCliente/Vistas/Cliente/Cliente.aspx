<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Demo001RestFrontCliente.Vistas.Cliente.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Gestionar clientes</h1>
            Ingresar el id: 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>

        <h1>Ingresar nuevo Cliente</h1>
        <div>
            
            ID: <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            <br />
            NOMBRE: <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            <br />
            EMAIL: <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnIngresar" runat="server" Text="Crear Nuevo" OnClick="btnIngresar_Click" />
            &nbsp;
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
            &nbsp;
            <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
            
            <br />
            <br />
            
        </div>
    </form>
</body>
</html>
