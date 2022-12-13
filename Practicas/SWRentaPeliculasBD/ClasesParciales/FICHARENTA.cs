using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD
{
    public partial class FICHARENTA
    {
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual PELICULA PELICULA { get; set; }
    }
}