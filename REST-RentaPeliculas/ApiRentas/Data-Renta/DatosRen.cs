using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiRentas.Data_Renta
{
    public class DatosRen
    {
        //Instancia de la BD Renta
        RentaPeliculasEntities Contexto;

        //Constructor
        public DatosRen()
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
        public bool EliminarRenta(string ID)
        {
            FICHARENTA rentemp = RentaporID(ID);
            if (RentaporID(ID) != null)
            {
                Contexto.FICHARENTA.Remove(rentemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}