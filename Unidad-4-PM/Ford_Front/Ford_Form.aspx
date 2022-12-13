<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ford_Form.aspx.cs" Inherits="Ford_Front.Ford_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <h2>Gestión de Automóviles Ford</h2>
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Font-Names="Arial" HorizontalAlign="Center" Width="80%">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        Id <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Marca&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Modelo&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Cilindraje&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Año&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Color&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        Tipo&nbsp; <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        Concesionaria&nbsp; <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
           <br />
           Fecha Registro&nbsp;
           <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
           <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear" BackColor="#66FF33" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Width="8%" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Editar" BackColor="#66CCFF" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Width="8%" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Eliminar" BackColor="#FF6666" Font-Bold="True" Font-Names="Arial" Font-Size="Medium" Width="8%" />
    </form>
</body>
</html>
