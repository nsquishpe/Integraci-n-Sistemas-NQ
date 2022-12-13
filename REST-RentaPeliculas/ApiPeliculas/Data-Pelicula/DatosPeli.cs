using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPeliculas.Data_Pelicula
{
    public class DatosPeli
    {
        //Instancia de la BD Pelicula
        RentaPeliculasEntities Contexto;

        //Constructor
        public DatosPeli()
        {
            Contexto = new RentaPeliculasEntities();
            //Framework acorde a nuestros cambios IMPORTANTE
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
        //Consulta
        private PELICULA PeliculaporID(string ID)
        {
            return Contexto.PELICULA.Where(pel => pel.PELIID == ID).SingleOrDefault();
        }
        //Metodos
        public List<PELICULA> SeleccionarPeliculas()
        {
            return Contexto.PELICULA.ToList();
        }
        public void InsertarPelicula(PELICULA pel)
        {
            Contexto.PELICULA.Add(pel);
            Contexto.SaveChanges();
        }
        public bool ActualizarPelicula(PELICULA pel)
        {
            PELICULA peltemp = PeliculaporID(pel.PELIID);
            if (PeliculaporID(pel.PELIID) != null)
            {
                peltemp.NOMBREPELI = pel.NOMBREPELI;
                peltemp.DIRECTORPELI = pel.DIRECTORPELI;
                peltemp.GENEROPELI = pel.GENEROPELI;
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarPelicula(string id)
        {
            PELICULA peltemp = PeliculaporID(id);
            if (PeliculaporID(id) != null)
            {
                Contexto.PELICULA.Remove(peltemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}