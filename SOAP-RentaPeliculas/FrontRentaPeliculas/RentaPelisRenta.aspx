<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentaPelisRenta.aspx.cs" Inherits="FrontRentaPeliculas.RentaPelisRenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="FrontApi/HojasEstilo/Estilos.css" rel="stylesheet" />
</head>
<body>
    <h1 class="titulos_pagCliente">Gestion de Fichas Renta</h1>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Crear Nuevo" class="botones" OnClick="Button1_Click" />
        <br />
        <br />
        <div>
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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" class="tabla" DataKeyNames="RENTID">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="RENTID" HeaderText="RENTID" SortExpression="RENTID" />
                <asp:BoundField DataField="PELIID" HeaderText="PELIID" SortExpression="PELIID" />
                <asp:BoundField DataField="CLIID" HeaderText="CLIID" SortExpression="CLIID" />
                <asp:BoundField DataField="FECHAREGRENT" HeaderText="FECHAREGRENT" SortExpression="FECHAREGRENT" />
                <asp:BoundField DataField="FECHADEVRENT" HeaderText="FECHADEVRENT" SortExpression="FECHADEVRENT" />
                <asp:BoundField DataField="FECHAENTRENT" HeaderText="FECHAENTRENT" SortExpression="FECHAENTRENT" />
            </Columns>
        </asp:GridView>
        </div>
        
        <br />
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
 
     
 
      
 
      
 
            <InsertItemTemplate>
                RENTID:
                <asp:TextBox ID="RENTIDTextBox" runat="server" Text='<%# Bind("RENTID") %>' />
                <br />
                PELIID:
                <asp:TextBox ID="PELIIDTextBox" runat="server" Text='<%# Bind("PELIID") %>' />
                <br />
                CLIID:
                <asp:TextBox ID="CLIIDTextBox" runat="server" Text='<%# Bind("CLIID") %>' />
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
    </form>
</body>
</html>
