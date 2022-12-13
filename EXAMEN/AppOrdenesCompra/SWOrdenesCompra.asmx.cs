using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AppOrdenesCompra
{
    /// <summary>
    /// Descripción breve de SWOrdenesCompra
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWOrdenesCompra : System.Web.Services.WebService
    {
        Operaciones.OperacionesOrdenesCompra op = new Operaciones.OperacionesOrdenesCompra();
        [WebMethod]
        public List<OrdenCompras> SeleccionarOrdenesCompra()
        {
            return op.SeleccionarOrdenesCompras();
        }
        [WebMethod]
        public OrdenCompras SeleccionarOrdenesCompraPorID(string ID)
        {
            return op.SeleccionarOrdenesCompraPorID(ID);
        }
    }
}
