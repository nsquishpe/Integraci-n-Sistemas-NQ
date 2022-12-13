using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SWRentaPeliculasBD
{
    /// <summary>
    /// Descripción breve de SWClientes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWClientes : System.Web.Services.WebService
    {
        LogicaNegocio.LN_Clientes op = new LogicaNegocio.LN_Clientes();
        [WebMethod]
        public List<CLIENTE> SeleccionarCliente()
        {
            return op.SeleccionarCliente();
        }
        [WebMethod]
        public CLIENTE SeleccionarClientePorID(string ID)
        {
            return op.SeleccionarClientePorID(ID);
        }
        //CRUD
        [WebMethod]
        public void InsertarCliente(CLIENTE cli)
        {
            op.InsertarCliente(cli);
        }
        [WebMethod]
        public bool ActualizarCliente(CLIENTE cli)
        {
            return op.ActualizarCliente(cli);
        }
        [WebMethod]
        public bool EliminarCliente(CLIENTE cli)
        {
            return op.EliminarCliente(cli);
        }
        [WebMethod]
        public List<CLIENTE> SeleccionarClientesDef(string ID = "Buscar")
        {
            return op.SeleccionarClientesDef(ID);
        }
        [WebMethod]
        public List<CLIENTE> SeleccionarClientesSPorNombreDef(string Nombre = "Buscar")
        {
            return op.SeleccionarClientesPorNombreDef(Nombre);
        }
        //PROCEDIMIENTOS ALMACENADOS

        [WebMethod]
        public List<SeleccionarClientes_Result> SeleccionarClientesSP()
        {
            return op.SeleccionarClientesSP().ToList();
        }
        [WebMethod]
        public void InsertarClientesSP(CLIENTE cli)
        {
            op.InsertarClientesSP(cli);
        }
        [WebMethod]
        public bool ActualizarClientesSP(CLIENTE cli)
        {
            return op.ActualizarClientesSP(cli);
        }
        [WebMethod]
        public void EliminarClientesSP(CLIENTE cli)
        {
            op.EliminarClientesSP(cli);
        }
    }
}
