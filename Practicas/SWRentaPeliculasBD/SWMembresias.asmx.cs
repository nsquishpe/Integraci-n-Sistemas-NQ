using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SWRentaPeliculasBD
{
    /// <summary>
    /// Descripción breve de SWMembresias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWMembresias : System.Web.Services.WebService
    {
        LogicaNegocio.LN_Membresia op = new LogicaNegocio.LN_Membresia();
        [WebMethod]
        public List<MEMBRESIA> SeleccionarMembresias()
        {
            return op.SeleccionarMembresia();
        }
        [WebMethod]
        public MEMBRESIA SeleccionarMembresiaPorID(string ID)
        {
            return op.SeleccionarMembresiaPorID(ID);
        }
        //CRUD
        [WebMethod]
        public void InsertarMembresia(MEMBRESIA cli)
        {
            op.InsertarMembresia(cli);
        }
        [WebMethod]
        public bool ActualizarMembresia(MEMBRESIA cli)
        {
            return op.ActualizarMembresia(cli);
        }
        [WebMethod]
        public bool EliminarMembresia(MEMBRESIA cli)
        {
            return op.EliminarMembresia(cli);
        }
        [WebMethod]
        public List<MEMBRESIA> SeleccionarMembresiasDef(string ID = "Buscar")
        {
            return op.SeleccionarMembresiaDef(ID);
        }
        //PROCEDIMIENTOS ALMACENADOS
        [WebMethod]
        public List<SeleccionarMembresiasSP_Result> SeleccionarMembresiasSP()
        {
            return op.SeleccionarMembresiasSP();
        }
        [WebMethod]
        public void InsertarMembresiasSP(MEMBRESIA mem)
        {
            op.EliminarMembresiasSP(mem);
        }
        [WebMethod]
        public bool ActualizarMembresiasSP(MEMBRESIA mem)
        {
            return op.ActualizarMembresiasSP(mem);
        }
        [WebMethod]
        public void EliminarMembresiasSP(MEMBRESIA mem)
        {
            op.EliminarMembresiasSP(mem);
        }
    }
}
