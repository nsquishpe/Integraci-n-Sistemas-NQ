using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using Logica;

namespace restFord.Controllers
{
    public class fordController : ApiController
    {
        Logica.LogicaFord op = new Logica.LogicaFord();
        // GET: api/ford
        public List<Auto_FORD> Get()
        {
            return op.SeleccionarAutosChev();
        }

        // GET: api/ford/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ford
        public void Post(Auto_FORD chev)
        {
            op.InsertarAutoChev(chev);
        }

        // PUT: api/ford/5
        public bool Put(Auto_FORD chev)
        {
            return op.ActualizarAutoChev(chev);
        }

        // DELETE: api/ford/5
        public bool Delete(int id)
        {
            return op.EliminarPelicula(id);
        }
    }
}
