<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentaPelisFront.aspx.cs" Inherits="FrontRentaPeliculas.RentaPelisFront" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="FrontApi/HojasEstilo/Estilos.css" rel="stylesheet" />
</head>
<body>
    <h1 class="titulos_pagCliente">Gestión de Clientes</h1>
    <p class="titulos_pagCliente">&nbsp;</p>
    <form id="form1" runat="server">
        <asp:Button runat="server" Text="Crear nuevo" class="botones" OnClick="Unnamed1_Click" />
        <br />
        <div>
            &nbsp;<asp:Label ID="Label1" runat="server" Text="ID Cliente:" CssClass="combo"></asp:Label>
&nbsp; &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="CLIID" DataValueField="CLIID" AppendDataBoundItems="True" AutoPostBack="True" EnableViewState="False" CssClass="combo">
                <asp:ListItem Value="Buscar">All</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Nombre:" CssClass="combo"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="ObjectDataSource3" DataTextField="NOMBRECLI" DataValueField="CLIID" EnableViewState="False" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="Buscar">All</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="Buscar" class="botonbusc" />
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="SeleccionarClientesSPorNombreDef" TypeName="FrontRentaPeliculas.SWClientes.SWClientes">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList2" DefaultValue="Buscar" Name="Nombre" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
&nbsp;<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SeleccionarClientesDef" TypeName="FrontRentaPeliculas.SWClientes.SWClientes">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" DefaultValue="Buscar" Name="ID" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            &nbsp;&nbsp;
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="FrontRentaPeliculas.SWClientes.CLIENTE" DeleteMethod="EliminarCliente" InsertMethod="InsertarCliente" SelectMethod="SeleccionarClientesDef" TypeName="FrontRentaPeliculas.SWClientes.SWClientes" UpdateMethod="ActualizarCliente">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" DefaultValue="Buscar" Name="ID" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
        </div>

        <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2" Width="545px" class="tabla" DataKeyNames="CLIID">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="CLIID" HeaderText="CLIID" SortExpression="CLIID" />
                <asp:BoundField DataField="NOMBRECLI" HeaderText="NOMBRECLI" SortExpression="NOMBRECLI" />
                <asp:BoundField DataField="CEDULACLI" HeaderText="CEDULACLI" SortExpression="CEDULACLI" />
                <asp:BoundField DataField="EMAILCLI" HeaderText="EMAILCLI" SortExpression="EMAILCLI" />
            </Columns>
        </asp:GridView>
        <p>
             &nbsp;</p>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource2">
 
           
           
 
           
           
 
            <InsertItemTemplate>
                CLIID:
                <asp:TextBox ID="CLIIDTextBox" runat="server" Text='<%# Bind("CLIID") %>' />
                <br />
                NOMBRECLI:
                <asp:TextBox ID="NOMBRECLITextBox" runat="server" Text='<%# Bind("NOMBRECLI") %>' />
                <br />
                CEDULACLI:
                <asp:TextBox ID="CEDULACLITextBox" runat="server" Text='<%# Bind("CEDULACLI") %>' />
                <br />
                EMAILCLI:
                <asp:TextBox ID="EMAILCLITextBox" runat="server" Text='<%# Bind("EMAILCLI") %>' />
                <br />
 
 
 
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>

      
      
           
    
      
           
      
        </asp:FormView>

        <asp:Button ID="Button2" runat="server" PostBackUrl="~/Index.aspx" Text="Volver" class="botonbusc" />

    </form>
    <p>
             &nbsp;</p>
</body>
</html>
