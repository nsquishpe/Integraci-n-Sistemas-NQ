using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppOrdenesCompra.DTO
{
    public class OrdenCompra_ArtProv
    {
        //Orden de Compra
        public string OrdID { get; set; }
        public string OrdArtID { get; set; }
        public string OrdProvID { get; set; }

        //Articulo
        public string ArtDescrip { get; set; }

        //Proveedor
        public string ProvNombre { get; set; }
    }
}