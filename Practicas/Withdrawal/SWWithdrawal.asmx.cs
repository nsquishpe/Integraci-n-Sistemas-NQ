using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Withdrawal
{
    /// <summary>
    /// Descripción breve de SWWithdrawal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWWithdrawal : System.Web.Services.WebService
    {
        IngresoRetiro.IRetiro retiro =  new IngresoRetiro.IRetiro();
        [WebMethod]
        public double Retiro(double n1,double n2)
        {
            return retiro.IngresarRetiro(n1,n2);
        }
    }
}
