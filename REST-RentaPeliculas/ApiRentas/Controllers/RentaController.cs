using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiRentas.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RentaController : ApiController
    {
        Logica_Renta.LogicaRen op = new Logica_Renta.LogicaRen();
        // GET: api/Renta
        public List<FICHARENTA> Get()
        {
            return op.SeleccionarRenta();
        }

        // GET: api/Renta/5
        public FICHARENTA Get(string id)
        {
            return op.SeleccionarRentaPorID(id);
        }

        // POST: api/Renta
        public void Post(FICHARENTA ren)
        {
            op.InsertarRenta(ren);
        }

        // PUT: api/Renta/5
        public bool Put(FICHARENTA ren)
        {
            return op.ActualizarRenta(ren);
        }

        // DELETE: api/Renta/5
        public bool Delete(string id)
        {
            return op.EliminarRenta(id);
        }
    }
}
