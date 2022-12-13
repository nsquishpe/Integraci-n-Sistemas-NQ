using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AppOrdenesCompra
{
    /// <summary>
    /// Descripción breve de SWProovedores
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWProovedores : System.Web.Services.WebService
    {
        Operaciones.OperacionesProveedor op = new Operaciones.OperacionesProveedor();
        [WebMethod]
        public List<RefProovedores.Proveedores> SeleccionarProovedores()
        {
            return op.SeleccionarProovedores();
        }
        [WebMethod]
        public RefProovedores.Proveedores SeleccionarProovedoresPorID(string ID)
        {
            return op.SeleccionarProveedorPorID(ID);
        }
    }
}
