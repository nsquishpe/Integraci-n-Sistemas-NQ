using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiRentas.Logica_Renta
{
    public class LogicaRen
    {
        //Instancia de datos
        Data_Renta.DatosRen crud_ren = new Data_Renta.DatosRen();
        //Metodo - almacena en lista todos las rentas
        public List<FICHARENTA> SeleccionarRenta()
        {
            return crud_ren.SeleccionarRentas();
        }
        //Metodo - almacena membresias por cedula
        public FICHARENTA SeleccionarRentaPorID(string ID)
        {
            if (ID == null)
            {
                return null;
            }
            else
            {
                return SeleccionarRenta().SingleOrDefault(ren => ren.RENTID == ID);
            }
        }
        //CRUD
        public void InsertarRenta(FICHARENTA ren)
        {
            crud_ren.InsertarRenta(ren);
        }
        public bool ActualizarRenta(FICHARENTA ren)
        {
            return crud_ren.ActualizarRenta(ren);
        }
        public bool EliminarRenta(string ID)
        {
            return crud_ren.EliminarRenta(ID);
        }
    }
}