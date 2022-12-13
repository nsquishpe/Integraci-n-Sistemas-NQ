using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IntegracionSI_BD_Empresa
{
    /// <summary>
    /// Descripción breve de SWEmpresas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWEmpresas : System.Web.Services.WebService
    {
        Operaciones.Empresa empresa = new Operaciones.Empresa();
        [WebMethod]
        public List<Empresas> SeleccionarEmpres1()
        {
            return empresa.SeleccionarEmpresa();
        }
        [WebMethod]
        public Empresas SeleccionarEmpresasporID1(int cedula)
        {
            return empresa.SeleccionarEmpresasporID(cedula);
        }
    }
}
