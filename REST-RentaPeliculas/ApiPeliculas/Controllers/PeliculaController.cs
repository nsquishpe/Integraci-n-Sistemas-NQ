using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiPeliculas.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PeliculaController : ApiController
    {
        Logica_Pelicula.LogicaPeli op = new Logica_Pelicula.LogicaPeli();
        // GET: api/Pelicula
        public List<PELICULA> Get()
        {
            return op.SeleccionarPelicula();
        }

        // GET: api/Pelicula/5
        public PELICULA Get(string id)
        {
            return op.SeleccionarPeliculaPorID(id);
        }

        // POST: api/Pelicula
        public void Post(PELICULA pel)
        {
            op.InsertarPelicula(pel);
        }

        // PUT: api/Pelicula/5
        public bool Put(PELICULA pel)
        {
            return op.ActualizarPelicula(pel);
        }

        // DELETE: api/Pelicula/5
        public bool Delete(string id)
        {
            return op.EliminarPelicula(id);
        }
    }
}
