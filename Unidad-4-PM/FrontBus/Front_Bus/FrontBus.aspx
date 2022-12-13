<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontBus.aspx.cs" Inherits="Front_Bus.FrontBus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label ID="Label1" runat="server" Text="Vehículos Ecuador" Font-Bold="True" Font-Italic="False" Font-Names="Bookman Old Style" Font-Size="XX-Large" ></asp:Label>
        </div>
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SeleccionarAutosChev" TypeName="Front_Bus.WebService_AutosEC.SWAutosEC"></asp:ObjectDataSource>
        <asp:Label ID="Label2" runat="server" Text="Tipo:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SeleccionarAutosEcuadorPorTipo" TypeName="Front_Bus.WebService_AutosEC.SWAutosEC">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" DefaultValue="All" Name="Tipo" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" HorizontalAlign="Center" Font-Bold="False" Font-Names="Arial Black" Font-Overline="False" Font-Size="Medium" Width="80%">
            <Columns>
                <asp:BoundField DataField="Marca_autosEC" HeaderText="Marca" SortExpression="Marca_autosEC" />
                <asp:BoundField DataField="Modelo_autosEC" HeaderText="Modelo" SortExpression="Modelo_autosEC" />
                <asp:BoundField DataField="Tipo_autosEC" HeaderText="Tipo" SortExpression="Tipo_autosEC" />
                <asp:BoundField DataField="Color_autosEC" HeaderText="Color" SortExpression="Color_autosEC" />
                <asp:BoundField DataField="Anio_autosEC" HeaderText="Año" SortExpression="Anio_autosEC" />
                <asp:BoundField DataField="Cons_autosEC" HeaderText="Concesionaria" SortExpression="Cons_autosEC" />
                <asp:TemplateField HeaderText="Imágen">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" Height="60px" Width="100px" ImageUrl='<%# Eval("img_autosEC") %>' />
                </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <RowStyle Font-Names="Arial" HorizontalAlign="Center" VerticalAlign="Middle" />
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
    </form>
</body>
</html>
