using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using Logica;

namespace RestChev.Controllers
{
    public class ChevApiController : ApiController
    {
        Logica.Logica_Chev op = new Logica.Logica_Chev();
        // GET: api/ChevApi
        public List<Auto_CHEV> Get()
        {
            return op.SeleccionarAutosChev();
        }

        // GET: api/ChevApi/5
        public Auto_CHEV Get(int id)
        {
            return op.ChevporID(id);
        }

        // POST: api/ChevApi
        public void Post(Auto_CHEV chev)
        {
            op.InsertarAutoChev(chev);
        }

        // PUT: api/ChevApi/5
        public bool Put(Auto_CHEV chev)
        {
            return op.ActualizarAutoChev(chev);
        }

        // DELETE: api/ChevApi/5
        public bool Delete(Auto_CHEV chev)
        {
            return op.EliminarPelicula(chev);
        }
    }
}
