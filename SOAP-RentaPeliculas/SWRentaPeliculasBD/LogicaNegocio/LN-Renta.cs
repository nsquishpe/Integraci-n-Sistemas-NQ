using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD.LogicaNegocio
{
    public class LN_Renta
    {
        //Instancia de datos
        Datos.Datos_Renta crud_ren = new Datos.Datos_Renta();
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
        public bool EliminarRenta(FICHARENTA ren)
        {
            return crud_ren.EliminarRenta(ren);
        }
        public List<FICHARENTA> SeleccionarRentaDef(string ID = "Buscar")
        {
            FICHARENTA rentemp = new FICHARENTA();
            rentemp = SeleccionarRentaPorID(ID);
            List<FICHARENTA> rentas = new List<FICHARENTA>();
            if (ID == "Buscar")
            {
                return SeleccionarRenta().ToList();
            }
            else
            {
                rentas.Add(rentemp);
                return rentas;
            }
        }
        //PROCEDIMIENTOS ALMACENADOS
        public List<SeleccionarRentasSP_Result> SeleccionarRentasSP()
        {
            return crud_ren.SeleccionarRentasSP().ToList();
        }
        public void InsertarRentasSP(FICHARENTA ren)
        {
            crud_ren.InsertarRentasSP(ren);
        }
        public bool ActualizarRentasSP(FICHARENTA ren)
        {
            return crud_ren.ActualizarRentasSP(ren);
        }
        public void EliminarRentasSP(FICHARENTA ren)
        {
            crud_ren.EliminarRentasSP(ren);
        }
    }
}