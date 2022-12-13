using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD.Datos
{
    public class Datos_Renta
    {
        //Instancia de la BD Renta
        RentaPeliculasEntities Contexto;

        //Constructor
        public Datos_Renta()
        {
            Contexto = new RentaPeliculasEntities();
            //Framework acorde a nuestros cambios IMPORTANTE
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
        //Consulta
        private FICHARENTA RentaporID(string ID)
        {
            return Contexto.FICHARENTA.Where(ren => ren.RENTID == ID).SingleOrDefault();
        }
        //Metodos
        public List<FICHARENTA> SeleccionarRentas()
        {
            return Contexto.FICHARENTA.ToList();
        }
        public void InsertarRenta(FICHARENTA ren)
        {
            Contexto.FICHARENTA.Add(ren);
            Contexto.SaveChanges();
        }
        public bool ActualizarRenta(FICHARENTA ren)
        {
           FICHARENTA rentemp = RentaporID(ren.RENTID);
            if (RentaporID(ren.RENTID) != null)
            {
                rentemp.FECHADEVRENT = ren.FECHADEVRENT;
                rentemp.FECHAENTRENT = ren.FECHAENTRENT;
                rentemp.FECHAREGRENT = ren.FECHAREGRENT;
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarRenta(FICHARENTA ren)
        {
            FICHARENTA rentemp = RentaporID(ren.RENTID);
            if (RentaporID(ren.RENTID) != null)
            {
                Contexto.FICHARENTA.Remove(rentemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
        //PROCEDIMIENTOS ALMACENADOS
        public List<SeleccionarRentasSP_Result> SeleccionarRentasSP()
        {
            return Contexto.SeleccionarRentasSP().ToList();
        }
        public void InsertarRentasSP(FICHARENTA ren)
        {
            Contexto.InsertarRentaSP(ren.RENTID, ren.PELIID, ren.CLIID, ren.FECHAREGRENT, ren.FECHADEVRENT, ren.FECHAENTRENT);
            Contexto.SaveChanges();
        }
        public bool ActualizarRentasSP(FICHARENTA ren)
        {
            if (ren != null)
            {
                //Actualizamos Datos
                Contexto.ActualizarRentaSP(ren.RENTID, ren.PELIID, ren.CLIID, ren.FECHAREGRENT, ren.FECHADEVRENT, ren.FECHAENTRENT);
                Contexto.SaveChanges();//Guarda Cambios
                return true;
            }
            return false;
        }
        public void EliminarRentasSP(FICHARENTA ren)
        {
            Contexto.EliminarPeliculaSP(ren.RENTID);
        }
    }
}