using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IntegracionSI_BD_Empresa
{
    /// <summary>
    /// Descripción breve de EmpresaCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class EmpresaCliente : System.Web.Services.WebService
    {
        //Creo instancia Midlware -> Empresa Cliente
        Midlware.midlwareClase m = new Midlware.midlwareClase();
        [WebMethod]
        public List<DTO.EmpresaCliente> SeleccionarEmpresaCliente()
        {
            return m.SeleccionarEmpresaCliente();
        }
    }
}
