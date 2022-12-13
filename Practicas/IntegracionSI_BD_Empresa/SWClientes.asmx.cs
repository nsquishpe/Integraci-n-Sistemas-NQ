using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IntegracionSI_BD_Empresa
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
        Operaciones.OperacionesClientecs op = new Operaciones.OperacionesClientecs();
        [WebMethod]
        public List<SWcliente.Clientes> SeleccionarClientes()
        {
            return op.SeleccionarClientes();
        }
        [WebMethod]
        public SWcliente.Clientes SeleccionarClientesPorCedula(int cedula)
        {
            return op.SeleccionarClientesPorCedula(cedula);
        }
    }
}
