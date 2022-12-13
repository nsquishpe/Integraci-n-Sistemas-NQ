using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppOrdenesCompra.Operaciones
{
    public class OperacionesProveedor
    {
        //Instancia base de datos Arituclo externa
        RefProovedores.SWProovedores proovedor = new RefProovedores.SWProovedores();
        //Métodos
        //Selecciona todos los clientes de la base de datos
        public List<RefProovedores.Proveedores> SeleccionarProovedores()
        {
            return proovedor.SeleccionarProovedores().ToList();
        }
        //Selecciona el cliente por cédula de la base de datos
        public RefProovedores.Proveedores SeleccionarProveedorPorID(string ID)
        {
            return proovedor.SeleccionarProovedoresPorID(ID);
        }
    }
}