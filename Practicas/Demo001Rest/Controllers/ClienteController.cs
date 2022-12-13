using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Demo001Rest.Controllers
{
    [EnableCors(origins: "*", headers:"*", methods:"*")]
    public class ClienteController : ApiController
    {
        Logica_Cliente.LogicaCli op = new Logica_Cliente.LogicaCli();
        // GET: api/Cliente
        public List<Clientes> Get()
        {
            return op.SeleccionarClientes();
        }

        // GET: api/Cliente/5
        public Clientes Get(int id)
        {
            return op.SeleccionarClientesPorID(id);
        }

        // POST: api/Cliente
        public int Post(Clientes cli)
        {
            return op.InsertarCliente(cli);
        }

        // PUT: api/Cliente/5
        public bool Put(Clientes cli)
        {
            return op.ActualizarCliente(cli);
        }

        // DELETE: api/Cliente/5
        public bool Delete(int id)
        {
            return op.EliminarCliente(id);
        }
    }
}
