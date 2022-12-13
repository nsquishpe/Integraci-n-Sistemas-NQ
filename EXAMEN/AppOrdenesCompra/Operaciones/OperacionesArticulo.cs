using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppOrdenesCompra.Operaciones
{
    public class OperacionesArticulo
    {
        //Instancia base de datos Arituclo externa
        RefArticulos.SWArticulos articulo = new RefArticulos.SWArticulos();
        //Métodos
        //Selecciona todos los clientes de la base de datos
        public List<RefArticulos.Articulos> SeleccionarArticulos()
        {
            return articulo.SeleccionarAritculos().ToList();
        }
        //Selecciona el cliente por cédula de la base de datos
        public RefArticulos.Articulos SeleccionarArticulosPorID(string ID)
        {
            return articulo.SeleccionarArticuloPorID(ID);
        }
    }
}