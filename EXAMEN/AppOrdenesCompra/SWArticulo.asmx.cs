using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AppOrdenesCompra
{
    /// <summary>
    /// Descripción breve de SWArticulo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWArticulo : System.Web.Services.WebService
    {
        Operaciones.OperacionesArticulo op = new Operaciones.OperacionesArticulo();
        [WebMethod]
        public List<RefArticulos.Articulos> SeleccionarArticulos()
        {
            return op.SeleccionarArticulos();
        }
        [WebMethod]
        public RefArticulos.Articulos SeleccionarArticulosPorID(string ID)
        {
            return op.SeleccionarArticulosPorID(ID);
        }
    }
}
