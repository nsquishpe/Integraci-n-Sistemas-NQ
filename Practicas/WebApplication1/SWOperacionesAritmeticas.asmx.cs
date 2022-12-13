using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de SWOperacionesAritmeticas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    //Capacidad de enviar y recibir datos
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWOperacionesAritmeticas : System.Web.Services.WebService
    {
        Operaciones.Coperaciones op = new Operaciones.Coperaciones();
        [WebMethod]
        public decimal suma(decimal n1, decimal n2)
        {
            return op.suma(n1, n2);
        }
        [WebMethod]
        public decimal resta(decimal n1, decimal n2)
        {
            return op.resta(n1, n2);
        }
        [WebMethod]
        public decimal multiplicacion(decimal n1, decimal n2)
        {
            return op.multiplicacion(n1, n2);
        }
        [WebMethod]
        public decimal division(decimal n1, decimal n2)
        {
            return op.division(n1, n2);
        }
    }
}
