using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiClientes.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClienteController : ApiController
    {
        Logica_Cliente.LogicaCli op = new Logica_Cliente.LogicaCli();
        // GET: api/Cliente
        public List<CLIENTE> Get()
        {
            return op.SeleccionarCliente();
        }

        // GET: api/Cliente/5
        public CLIENTE Get(string id)
        {
            return op.SeleccionarClientePorID(id);
        }

        // POST: api/Cliente
        public void Post(CLIENTE cli)
        {
            op.InsertarCliente(cli);
        }

        // PUT: api/Cliente/5
        public bool Put(CLIENTE cli)
        {
            return op.ActualizarCliente(cli);
        }

        // DELETE: api/Cliente/5
        public bool Delete(string id)
        {
            return op.EliminarCliente(id);
        }
    }
}
