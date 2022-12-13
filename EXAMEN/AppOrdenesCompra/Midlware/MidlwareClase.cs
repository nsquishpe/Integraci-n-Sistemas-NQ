using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppOrdenesCompra.Midlware
{
    public class MidlwareClase
    {
        public List<DTO.OrdenCompra_ArtProv> SeleccionarOrdenCompra_ArtProv()
        {
            //Lista temporal de objetos Ordenes de compra
            List<OrdenCompras> ListTemporalord = new List<OrdenCompras>();

            //Instancia del servicio Web Articulo externo (Operaciones)
            RefArticulos.SWArticulos SWArtOperaciones = new RefArticulos.SWArticulos();
            //Instancia operaciones Articulo
            Operaciones.OperacionesArticulo articuloOp = new Operaciones.OperacionesArticulo();
            //Instancia base de datos Cliente externo
            RefArticulos.Articulos TemporalArticulo = new RefArticulos.Articulos();

            //Instancia del servicio Web Proveedor externo (Operaciones)
            RefProovedores.SWProovedores SWProvOperaciones = new RefProovedores.SWProovedores();
            //Instancia operaciones Articulo
            Operaciones.OperacionesProveedor proveedorOp = new Operaciones.OperacionesProveedor();
            //Instancia base de datos Cliente externo
            RefProovedores.Proveedores TemporalProveedor = new RefProovedores.Proveedores();

            //Instancia operaciones ordenes de compra
            Operaciones.OperacionesOrdenesCompra empresaord = new Operaciones.OperacionesOrdenesCompra();
            //Almacena en la lista todas las ordenes de compra
            ListTemporalord = empresaord.SeleccionarOrdenesCompras();


            //Lista temporal  DTO
            List<DTO.OrdenCompra_ArtProv> ltsOrdArtProv = new List<DTO.OrdenCompra_ArtProv>();

            //Itero lista de ordenes de compra
            foreach (var item in ListTemporalord)
            {
                //Instancia de EmpresaCliente DTO
                DTO.OrdenCompra_ArtProv temp = new DTO.OrdenCompra_ArtProv();
                //Atributos del articulo
                temp.OrdArtID = item.OrdArtID;
                //Atributos del proovedor
                temp.OrdProvID = item.OrdProvID;

                //Validación objeto no nulo ID articulo y proovedor de acuerdo al ID de la orden de compra
                if (articuloOp.SeleccionarArticulosPorID(item.OrdArtID) != null && proveedorOp.SeleccionarProveedorPorID(item.OrdProvID) != null)
                {
                    //Busqueda Aticulo ID 
                    TemporalArticulo = articuloOp.SeleccionarArticulosPorID(item.OrdArtID);
                    //Busqueda proveedor ID
                    TemporalProveedor = proveedorOp.SeleccionarProveedorPorID(item.OrdProvID);

                    //Cliente con CI igual a ID Empresa
                    if (item.OrdArtID == TemporalArticulo.ArtID && item.OrdProvID == TemporalProveedor.ProvID)
                    {
                        temp.ArtDescrip = TemporalArticulo.ArtDescrip;
                        temp.ProvNombre = TemporalProveedor.ProvNombre;
                    }
                    //Añade ClienteEmpresa a la lista
                    ltsOrdArtProv.Add(temp);
                }
            }

            //Retorna Lista temporal EmpresaCliente DTO
            return ltsOrdArtProv;
        }
    }
}