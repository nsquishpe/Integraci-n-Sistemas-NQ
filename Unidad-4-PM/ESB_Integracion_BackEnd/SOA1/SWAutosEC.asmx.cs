using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Datos;
using Logica;

namespace SOA1
{
    /// <summary>
    /// Descripción breve de SWAutosEC
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWAutosEC : System.Web.Services.WebService
    {
        Logica.Middleware op = new Logica.Middleware();
        [WebMethod]
        public List<Datos.DTO.DTOAutosEcuador> SeleccionarAutosChev()
        {
            return op.SeleccionarAutosEC();
        }
        [WebMethod]
        public List<Datos.DTO.DTOAutosEcuador> SeleccionarAutosEcuadorPorTipo(string Tipo)
        {
            return op.SeleccionarAutosEcuadorPorTipo(Tipo);
        }
    }
}
