using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppArticulos.Operaciones
{
    public class OperacionesArticulo
    {
        //Instancia base de datos
        ArticuloEntities articulosContexto;
        //Constructor - base de datos
        public OperacionesArticulo()
        {
            articulosContexto = new ArticuloEntities();
        }
        //Métodos
        //Selecciona todos los articulos de la base de datos
        public List<Articulos> SeleccionarArticulos()
        {
            return articulosContexto.Articulos.ToList();
        }
        //Selecciona articulos por cédula de la base de datos
        public Articulos SeleccionarArticulosPorID(string ID)
        {
            return articulosContexto.Articulos.Where(art => art.ArtID == ID).SingleOrDefault();
        }
    }
}