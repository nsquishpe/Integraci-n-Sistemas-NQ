using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Balance
{
    /// <summary>
    /// Descripción breve de SWBalance
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWBalance : System.Web.Services.WebService
    {
        ConsultaBalance.CBalance balance = new ConsultaBalance.CBalance();
        [WebMethod]
        public double Balance(double n1)
        {
            return balance.ConsultarBalance(n1);
        }
    }
}
