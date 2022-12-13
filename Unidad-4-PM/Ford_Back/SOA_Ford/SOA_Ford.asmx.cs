using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using Logica;

namespace SOA_Ford
{
    /// <summary>
    /// Descripción breve de SOA_Ford
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SOA_Ford : System.Web.Services.WebService
    {
        FordEntities1 context = new FordEntities1();
        Logica.LogicaFord op = new Logica.LogicaFord();
        [WebMethod]
        public List<Auto_FORD> SeleccionarAutosChev()
        {
            return op.SeleccionarAutosChev();
        }
        [WebMethod]
        public void InsertarAutoChev(Auto_FORD chev)
        {
            op.InsertarAutoChev(chev);
        }
        [WebMethod]
        public bool EliminarAutoChev(int ID)
        {
            return op.EliminarPelicula(ID);
        }
        [WebMethod]
        public bool ActualizarAutoChev(Auto_FORD chev)
        {
            return op.ActualizarAutoChev(chev);
        }
        [WebMethod]
        private Auto_FORD ChevporID(int ID)
        {
            return op.ChevporID(ID);
        }
    }
}
