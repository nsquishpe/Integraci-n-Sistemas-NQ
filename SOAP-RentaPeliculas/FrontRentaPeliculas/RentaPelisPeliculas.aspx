<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentaPelisPeliculas.aspx.cs" Inherits="FrontRentaPeliculas.RentaPelisPeliculas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="FrontApi/HojasEstilo/Estilos.css" rel="stylesheet" />
</head>
<body>
    <h1 class="titulos_pagCliente">Gestión de Peliculas</h1>
    <p class="titulos_pagCliente">&nbsp;</p>
    
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Crear Nuevo" class="botones" OnClick="Button1_Click" />
        <div>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="FrontRentaPeliculas.SWPeliculas.PELICULA" DeleteMethod="EliminarPelicula" InsertMethod="InsertarPelicula" SelectMethod="SeleccionarPeliculasDef" TypeName="FrontRentaPeliculas.SWPeliculas.SWPeliculas" UpdateMethod="ActualizarPelicula">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="Buscar" Name="ID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="PELIID" DataValueField="PELIID" AppendDataBoundItems="True" AutoPostBack="True" EnableViewState="False">
                        <asp:ListItem Value="Buscar">All</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<asp:Button ID="Button2" runat="server" Text="Buscar" class="botonbusc" OnClick="Button2_Click" />
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="SeleccionarPeliculasDef" TypeName="FrontRentaPeliculas.SWPeliculas.SWPeliculas">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Buscar" Name="ID" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
&nbsp;<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" class="tabla" DataKeyNames="PELIID">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="PELIID" HeaderText="PELIID" SortExpression="PELIID" />
                <asp:BoundField DataField="NOMBREPELI" HeaderText="NOMBREPELI" SortExpression="NOMBREPELI" />
                <asp:BoundField DataField="DIRECTORPELI" HeaderText="DIRECTORPELI" SortExpression="DIRECTORPELI" />
                <asp:BoundField DataField="GENEROPELI" HeaderText="GENEROPELI" SortExpression="GENEROPELI" />
            </Columns>
        </asp:GridView>
        </div>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1">
   
          
          
            <InsertItemTemplate>
                PELIID:
                <asp:TextBox ID="PELIIDTextBox" runat="server" Text='<%# Bind("PELIID") %>' />
                <br />
                NOMBREPELI:
                <asp:TextBox ID="NOMBREPELITextBox" runat="server" Text='<%# Bind("NOMBREPELI") %>' />
                <br />
                DIRECTORPELI:
                <asp:TextBox ID="DIRECTORPELITextBox" runat="server" Text='<%# Bind("DIRECTORPELI") %>' />
                <br />
                GENEROPELI:
                <asp:TextBox ID="GENEROPELITextBox" runat="server" Text='<%# Bind("GENEROPELI") %>' />
                <br />
              
               
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
  
          
  
  
        </asp:FormView>
        <asp:Button ID="Button3" runat="server" PostBackUrl="~/Index.aspx" Text="Volver" class="botonbusc" />
    </form>
</body>
</html>
