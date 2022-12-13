using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SWRentaPeliculasBD
{
    /// <summary>
    /// Descripción breve de SWRentas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWRentas : System.Web.Services.WebService
    {
        LogicaNegocio.LN_Renta opc = new LogicaNegocio.LN_Renta();
        [WebMethod]
        public List<FICHARENTA> SeleccionarRenta()
        {
            return opc.SeleccionarRenta();
        }
        [WebMethod]
        public FICHARENTA SeleccionarRentaPorID(string ID)
        {
            return opc.SeleccionarRentaPorID(ID);
        }
        //CRUD
        [WebMethod]
        public void InsertarRenta(FICHARENTA ren)
        {
            opc.InsertarRenta(ren);
        }
        [WebMethod]
        public bool ActualizarRenta(FICHARENTA ren)
        {
            return opc.ActualizarRenta(ren);
        }
        [WebMethod]
        public bool EliminarRenta(FICHARENTA ren)
        {
            return opc.EliminarRenta(ren);
        }
        [WebMethod]
        public List<FICHARENTA> SeleccionarRentaDef(string ID = "Buscar")
        {
            return opc.SeleccionarRentaDef(ID);
        }
        //PROCEDIMIENTOS ALMACENADOS
        [WebMethod]
        public List<SeleccionarRentasSP_Result> SeleccionarRentasSP()
        {
            return opc.SeleccionarRentasSP().ToList();
        }
        [WebMethod]
        public void InsertarRentasSP(FICHARENTA ren)
        {
            opc.InsertarRentasSP(ren);
        }
        [WebMethod]
        public bool ActualizarRentasSP(FICHARENTA ren)
        {
            return opc.ActualizarRentasSP(ren);
        }
        [WebMethod]
        public void EliminarRentasSP(FICHARENTA ren)
        {
            opc.EliminarRentasSP(ren);
        }
    }
}
