using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiMembresias.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MembresiaController : ApiController
    {
        Logica_Membresia.LogicaMem op = new Logica_Membresia.LogicaMem();
        // GET: api/Membresia
        public List<MEMBRESIA> Get()
        {
            return op.SeleccionarMembresia();
        }

        // GET: api/Membresia/5
        public MEMBRESIA Get(string id)
        {
            return op.SeleccionarMembresiaPorID(id);
        }

        // POST: api/Membresia
        public void Post(MEMBRESIA mem)
        {
            op.InsertarMembresia(mem);
        }

        // PUT: api/Membresia/5
        public bool Put(MEMBRESIA mem)
        {
            return op.ActualizarMembresia(mem);
        }

        // DELETE: api/Membresia/5
        public bool Delete(string id)
        {
            return op.EliminarMembresia(id);
        }
    }
}
