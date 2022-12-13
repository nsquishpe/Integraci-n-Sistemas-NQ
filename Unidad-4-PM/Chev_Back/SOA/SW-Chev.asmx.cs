using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;
using AccesoDatos;

namespace SOA
{
    /// <summary>
    /// Descripción breve de SW_Chev
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SW_Chev : System.Web.Services.WebService
    {
        ChevroletEntities context = new ChevroletEntities();
        Logica.Logica_Chev op = new Logica.Logica_Chev();

        [WebMethod]
        public List<Auto_CHEV> SeleccionarAutosChev()
        {
            return op.SeleccionarAutosChev();
        }
        [WebMethod]
        public void InsertarAutoChev(Auto_CHEV chev)
        {
            op.InsertarAutoChev(chev);
        }
        [WebMethod]
        public bool EliminarAutoChev(Auto_CHEV chev)
        {
            return op.EliminarPelicula(chev);
        }
        [WebMethod]
        public bool ActualizarAutoChev(Auto_CHEV chev)
        {
            return op.ActualizarAutoChev(chev);
        }
        [WebMethod]
        private Auto_CHEV ChevporID(int ID)
        {
            return op.ChevporID(ID);
        }
    }
}
