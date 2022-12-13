<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FrontRentaPeliculas.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="FrontApi/HojasEstilo/Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" titulos ="orm1" runat="server">

                 <div class="divaux">
                     <h1 class="titIndex" style="text-align:center; font-family: 'Mongolian Baiti'; font-size: xx-large; font-weight: bold; font-style: normal; line-height: normal; white-space: normal;">&nbsp;</h1>
                     <h1 class="titIndex" style="text-align:center; font-family: 'Mongolian Baiti'; font-size: xx-large; font-weight: bold; font-style: normal; line-height: normal; white-space: normal;">&nbsp;</h1>
                     <h1 class="titIndex" style="text-align:center; font-family: 'Mongolian Baiti'; font-size: xx-large; font-weight: bold; font-style: normal; line-height: normal; white-space: normal;">&nbsp;</h1>
                     <h1 class="titIndex" style="text-align:center; font-family: 'Mongolian Baiti'; font-size: xx-large; font-weight: bold; font-style: normal; line-height: normal; white-space: normal;">&nbsp;</h1>
                     <h1 class="titIndex" style="text-align:center; font-family: 'Mongolian Baiti'; font-size: xx-large; font-weight: bold; font-style: normal; line-height: normal; white-space: normal;">&nbsp;</h1>
                     <h1 class="titIndex" style="text-align:center; font-family: 'Mongolian Baiti'; font-size: xx-large; font-weight: bold; font-style: normal; line-height: normal; white-space: normal;">Renta de Películas </h1>
                        <asp:Menu ID="Menu1" runat="server" ForeColor="White" Orientation="Horizontal" CssClass="Menu" BorderColor="#003366" BorderWidth="3px">
                            <Items>
                                <asp:MenuItem NavigateUrl="RentaPelisFront.aspx" Text="1. Gestión Clientes" Value="Gestión Clientes"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="RentaPelisMembresia.aspx" Text="2. Gestión Membresías" Value="Gestión Membresías"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="RentaPelisPeliculas.aspx" Text="3. Gestión Peliculas" Value="Gestión Peliculas"></asp:MenuItem>
                                <asp:MenuItem NavigateUrl="RentaPelisRenta.aspx" Text="4. Gestión Fichas Renta" Value="Gestión Fichas Renta"></asp:MenuItem>
                            </Items>
                            <StaticHoverStyle Font-Bold="True" Font-Italic="True" BorderWidth="3px" />
                            <StaticMenuItemStyle Font-Bold="True" />
                            <StaticMenuStyle BorderColor="#000066" />
                        </asp:Menu>
                     <div style="text-align:center">
                          <br />
                          <img src="https://i0.wp.com/www.mellimama.com/wp-content/uploads/2016/08/los-ni%C3%B1os_y_el_cine.png?fit=600%2C342&ssl=1" style="text-align:center"/>
                     </div>
                </div>

    </form>
</body>
</html>
