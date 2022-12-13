using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppProveedor.Operaciones
{
    public class OperacionesProveedor
    {
        //Instancia base de datos
        ProveedorEntities proveedoresContexto;
        //Constructor - base de datos
        public OperacionesProveedor()
        {
            proveedoresContexto = new ProveedorEntities();
        }
        //Métodos
        //Selecciona todos los articulos de la base de datos
        public List<Proveedores> SeleccionarProovedores()
        {
            return proveedoresContexto.Proveedores.ToList();
        }
        //Selecciona articulos por cédula de la base de datos
        public Proveedores SeleccionarProovedoresPorID(string ID)
        {
            return proveedoresContexto.Proveedores.Where(prov => prov.ProvID == ID).SingleOrDefault();
        }
    }
}