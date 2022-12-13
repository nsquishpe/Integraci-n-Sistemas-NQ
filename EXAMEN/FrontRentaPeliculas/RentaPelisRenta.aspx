<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentaPelisRenta.aspx.cs" Inherits="FrontRentaPeliculas.RentaPelisRenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="FrontApi/HojasEstilo/Estilos.css" rel="stylesheet" />
</head>
<body>
    <h2 >&nbsp;</h2>
    <h1 class="titulos_pagCliente">Gestion de Fichas Renta</h1>
    <form id="form1" runat="server">
        <br />
        <asp:Button ID="Button1" runat="server" Text="Crear Nuevo" class="botones" OnClick="Button1_Click" />
        <br />
        <br />
        <div>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="RENTID" DataValueField="RENTID" AppendDataBoundItems="True" AutoPostBack="True" EnableViewState="False">
            <asp:ListItem Value="Buscar">All</asp:ListItem>
        </asp:DropDownList>
        &nbsp;
        <asp:Button ID="Button2" runat="server" Text="Buscar"  class="botonbusc" Width="73px" OnClick="Button2_Click" />
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SeleccionarRentaDef" TypeName="FrontRentaPeliculas.SWRentas.SWRentas">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="Buscar" Name="ID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
            <br />
&nbsp;<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="FrontRentaPeliculas.SWRentas.FICHARENTA" DeleteMethod="EliminarRenta" InsertMethod="InsertarRenta" SelectMethod="SeleccionarRentaDef" TypeName="FrontRentaPeliculas.SWRentas.SWRentas" UpdateMethod="ActualizarRenta">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="Buscar" Name="ID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
            <br />
            <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" class="tabla" DataKeyNames="RENTID">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="RENTID" HeaderText="RENTID" SortExpression="RENTID" />
                <asp:BoundField DataField="PELIID" HeaderText="PELIID" SortExpression="PELIID" />
                <asp:BoundField DataField="CLIID" HeaderText="CLIID" SortExpression="CLIID" />
                <asp:BoundField DataField="FECHAREGRENT" HeaderText="FECHAREGRENT" SortExpression="FECHAREGRENT" />
                <asp:BoundField DataField="FECHADEVRENT" HeaderText="FECHADEVRENT" SortExpression="FECHADEVRENT" />
                <asp:BoundField DataField="FECHAENTRENT" HeaderText="FECHAENTRENT" SortExpression="FECHAENTRENT" />
                <asp:BoundField DataField="CLIENTE" HeaderText="NOMBRE" SortExpression="CLIENTE" />
            </Columns>
        </asp:GridView>
        </div>
        
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" Text="Button" />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource6">
            <Columns>
                <asp:BoundField DataField="CLIID" HeaderText="CLIID" SortExpression="CLIID" />
                <asp:BoundField DataField="MEMID" HeaderText="MEMID" SortExpression="MEMID" />
                <asp:BoundField DataField="NOMBRECLI" HeaderText="NOMBRECLI" SortExpression="NOMBRECLI" />
                <asp:BoundField DataField="CEDULACLI" HeaderText="CEDULACLI" SortExpression="CEDULACLI" />
                <asp:BoundField DataField="EMAILCLI" HeaderText="EMAILCLI" SortExpression="EMAILCLI" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" SelectMethod="SeleccionarClientePorID" TypeName="FrontRentaPeliculas.SWClientes.SWClientes">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="ID" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource5" runat="server"></asp:ObjectDataSource>
        
        <br />
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
 
     
 
      
 
      
 
            <InsertItemTemplate>
                RENTID:
                <asp:TextBox ID="RENTIDTextBox" runat="server" Text='<%# Bind("RENTID") %>' />
                <br />
                PELI:
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource4" DataTextField="NOMBREPELI" DataValueField="PELIID"   Text='<%# Bind("PELIID") %>' >
        </asp:DropDownList>
                <br />
                CLI:
                <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="ObjectDataSource3" DataTextField="NOMBRECLI" DataValueField="CLIID"    Text='<%# Bind("CLIID") %>'  >
        </asp:DropDownList>
                <br />
                FECHAREGRENT:
                <asp:TextBox ID="FECHAREGRENTTextBox" runat="server" Text='<%# Bind("FECHAREGRENT") %>' />
                <br />
                FECHADEVRENT:
                <asp:TextBox ID="FECHADEVRENTTextBox" runat="server" Text='<%# Bind("FECHADEVRENT") %>' />
                <br />
                FECHAENTRENT:
                <asp:TextBox ID="FECHAENTRENTTextBox" runat="server" Text='<%# Bind("FECHAENTRENT") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
           
           
         
           
         
           
        </asp:FormView>
        <asp:Button ID="Button3" runat="server" PostBackUrl="~/Index.aspx" Text="Volver" class="botonbusc" />
        
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="SeleccionarCliente" TypeName="FrontRentaPeliculas.SWClientes.SWClientes"></asp:ObjectDataSource>
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="SeleccionarPeliculas" TypeName="FrontRentaPeliculas.SWPeliculas.SWPeliculas"></asp:ObjectDataSource>
        
    </form>
</body>
</html>
