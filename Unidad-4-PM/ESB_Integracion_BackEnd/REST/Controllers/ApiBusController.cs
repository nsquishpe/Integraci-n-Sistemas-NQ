using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Datos;
using Logica;

namespace REST.Controllers
{
    public class ApiBusController : ApiController
    {
        Logica.Middleware op = new Logica.Middleware();
        // GET: api/ApiBus
        public List<Datos.DTO.DTOAutosEcuador> Get()
        {
            return op.SeleccionarAutosEC();
        }
    }
}
