<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chevrolet.aspx.cs" Inherits="Chev_Front.Chevrolet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <h2>Gestión de Autos Chevrolet</h2>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Bold="True" Font-Italic="False" Font-Names="Arial" Font-Size="Medium" ForeColor="#000066">Crear</asp:LinkButton>
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Chev_Front.SW_Chev.Auto_CHEV" DeleteMethod="EliminarAutoChev" InsertMethod="InsertarAutoChev" SelectMethod="SeleccionarAutosChev" TypeName="Chev_Front.SW_Chev.SW_Chev" UpdateMethod="ActualizarAutoChev"></asp:ObjectDataSource>
            <br />
            <br />
        </div>
        <br />
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="id" BackColor="#FFFF99" BorderColor="#FF9933" Font-Names="Arial" Font-Overline="False" HorizontalAlign="Center" Width="80%">
             <Columns>
                 <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                 <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                 <asp:BoundField DataField="Marca_Chevrolet" HeaderText="Marca" SortExpression="Marca_Chevrolet" />
                 <asp:BoundField DataField="Modelo_Chevrolet" HeaderText="Modelo" SortExpression="Modelo_Chevrolet" />
                 <asp:BoundField DataField="Cilindraje_Chevrolet" HeaderText="Cilindraje" SortExpression="Cilindraje_Chevrolet" />
                 <asp:BoundField DataField="Anio_Chevrolet" HeaderText="Año" SortExpression="Anio_Chevrolet" />
                 <asp:BoundField DataField="Color_Chevrolet" HeaderText="Color" SortExpression="Color_Chevrolet" />
                 <asp:BoundField DataField="Tipo_Chevrolet" HeaderText="Tipo" SortExpression="Tipo_Chevrolet" />
                 <asp:BoundField DataField="Con_Chevrolet" HeaderText="Concesionaria" SortExpression="Con_Chevrolet" />
                 <asp:BoundField DataField="Fecha_Chevrolet" HeaderText="Fecha Registro" SortExpression="Fecha_Chevrolet" />
             </Columns>
         </asp:GridView>
         <br />
         <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" Font-Names="Arial">

             <InsertItemTemplate>
                 id:
                 <asp:TextBox ID="idTextBox" runat="server" Text='<%# Bind("id") %>' />
                 <br />
                 Marca_Chevrolet:
                 <asp:TextBox ID="Marca_ChevroletTextBox" runat="server" Text='<%# Bind("Marca_Chevrolet") %>' />
                 <br />
                 Modelo_Chevrolet:
                 <asp:TextBox ID="Modelo_ChevroletTextBox" runat="server" Text='<%# Bind("Modelo_Chevrolet") %>' />
                 <br />
                 Cilindraje_Chevrolet:
                 <asp:TextBox ID="Cilindraje_ChevroletTextBox" runat="server" Text='<%# Bind("Cilindraje_Chevrolet") %>' />
                 <br />
                 Anio_Chevrolet:
                 <asp:TextBox ID="Anio_ChevroletTextBox" runat="server" Text='<%# Bind("Anio_Chevrolet") %>' />
                 <br />
                 Color_Chevrolet:
                 <asp:TextBox ID="Color_ChevroletTextBox" runat="server" Text='<%# Bind("Color_Chevrolet") %>' />
                 <br />
                 Tipo_Chevrolet:
                 <asp:TextBox ID="Tipo_ChevroletTextBox" runat="server" Text='<%# Bind("Tipo_Chevrolet") %>' />
                 <br />
                 Con_Chevrolet:
                 <asp:TextBox ID="Con_ChevroletTextBox" runat="server" Text='<%# Bind("Con_Chevrolet") %>' />
                 <br />
                 Fecha_Chevrolet:
                 <asp:TextBox ID="Fecha_ChevroletTextBox" runat="server" Text='<%# Bind("Fecha_Chevrolet") %>' />
                 <br />
                 <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                 &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
             </InsertItemTemplate>

         </asp:FormView>
       
    </form>
</body>
</html>
