using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AppOrdenesCompra
{
    /// <summary>
    /// Descripción breve de OrdenCompra_ProvArt
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class OrdenCompra_ProvArt : System.Web.Services.WebService
    {
        //Creo instancia Midlware
        Midlware.MidlwareClase m = new Midlware.MidlwareClase();
        [WebMethod]
        public List<DTO.OrdenCompra_ArtProv> SeleccionarEmpresaCliente()
        {
            return m.SeleccionarOrdenCompra_ArtProv();
        }
    }
}
