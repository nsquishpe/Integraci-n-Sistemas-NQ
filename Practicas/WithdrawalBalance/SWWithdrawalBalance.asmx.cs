using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WithdrawalBalance
{
    /// <summary>
    /// Descripción breve de SWWithdrawalBalance
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWWithdrawalBalance : System.Web.Services.WebService
    {
        OperacionRetiro.ORetiro withdrawalBalance = new OperacionRetiro.ORetiro();
        [WebMethod]
        public double WithdrawalBalance(double n1)
        {
            return withdrawalBalance.withdrawalBalance(n1);
        }
    }
}
