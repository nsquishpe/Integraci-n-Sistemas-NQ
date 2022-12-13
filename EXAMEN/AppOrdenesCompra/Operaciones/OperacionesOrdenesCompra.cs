using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppOrdenesCompra.Operaciones
{
    public class OperacionesOrdenesCompra
    {
        //Instancia base de datos
        OrdenCompraEntities OrdenesCompraContexto;
        //Constructor - base de datos
        public OperacionesOrdenesCompra()
        {
            OrdenesCompraContexto = new OrdenCompraEntities();
        }
        //Métodos
        //Selecciona todos los articulos de la base de datos
        public List<OrdenCompras> SeleccionarOrdenesCompras()
        {
            return OrdenesCompraContexto.OrdenCompras.ToList();
        }
        //Selecciona articulos por cédula de la base de datos
        public OrdenCompras SeleccionarOrdenesCompraPorID(string ID)
        {
            return OrdenesCompraContexto.OrdenCompras.Where(ord => ord.OrdID == ID).SingleOrDefault();
        }
    }
}