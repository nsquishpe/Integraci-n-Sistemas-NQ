<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentaPelisMembresia.aspx.cs" Inherits="FrontRentaPeliculas.RentaPelisMembresia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="FrontApi/HojasEstilo/Estilos.css" rel="stylesheet" />
</head>
<body>
    <h1 class="titulos_pagCliente">Gestión de Membresias</h1>
    <p class="titulos_pagCliente">&nbsp;</p>
    <form id="form1" runat="server">
         <asp:Button ID="Button1" runat="server" Text="Crear Nuevo" class="botones" OnClick="Button1_Click" />
        <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="FrontRentaPeliculas.SWMembresias.MEMBRESIA" DeleteMethod="EliminarMembresia" InsertMethod="InsertarMembresia" SelectMethod="SeleccionarMembresiasDef" TypeName="FrontRentaPeliculas.SWMembresias.SWMembresias" UpdateMethod="ActualizarMembresia">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="Buscar" Name="ID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="MEMID" DataValueField="MEMID" EnableViewState="False">
            <asp:ListItem Value="Buscar">All</asp:ListItem>
        </asp:DropDownList>
        &nbsp;<asp:Button ID="Button2" runat="server" Text="Buscar" class="botonbusc" OnClick="Button2_Click" />
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SeleccionarMembresiasDef" TypeName="FrontRentaPeliculas.SWMembresias.SWMembresias">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="Buscar" Name="ID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        &nbsp; 
            <br />
        <br />
        </div>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" class="tabla" DataKeyNames="MEMID">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="MEMID" HeaderText="MEMID" SortExpression="MEMID" />
                <asp:BoundField DataField="CLIID" HeaderText="CLIID" SortExpression="CLIID" />
                <asp:BoundField DataField="FECHAREGMEM" HeaderText="FECHAREGMEM" SortExpression="FECHAREGMEM" />
                <asp:BoundField DataField="FECHAEXOMEM" HeaderText="FECHAEXOMEM" SortExpression="FECHAEXOMEM" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
   

   
            <InsertItemTemplate>
                MEMID:
                <asp:TextBox ID="MEMIDTextBox" runat="server" Text='<%# Bind("MEMID") %>' />
                <br />
                CLIID:
                <asp:TextBox ID="CLIIDTextBox" runat="server" Text='<%# Bind("CLIID") %>' />
                <br />
                FECHAREGMEM:
                <asp:TextBox ID="FECHAREGMEMTextBox" runat="server" Text='<%# Bind("FECHAREGMEM") %>' />
                <br />
                FECHAEXOMEM:
                <asp:TextBox ID="FECHAEXOMEMTextBox" runat="server" Text='<%# Bind("FECHAEXOMEM") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
  
          
  
        </asp:FormView>
        <asp:Button ID="Button3" runat="server" PostBackUrl="~/Index.aspx" Text="Volver" class="botonbusc" />
    </form>
</body>
</html>
