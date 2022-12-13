using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AppArticulos
{
    /// <summary>
    /// Descripción breve de SWArticulos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWArticulos : System.Web.Services.WebService
    {
        Operaciones.OperacionesArticulo op = new Operaciones.OperacionesArticulo();
        [WebMethod]
        public List<Articulos> SeleccionarAritculos()
        {
            return op.SeleccionarArticulos();
        }
        [WebMethod]
        public Articulos SeleccionarArticuloPorID(string ID)
        {
            return op.SeleccionarArticulosPorID(ID);
        }
    }
}
