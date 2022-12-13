using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD.Datos
{
    public class Datos_Pelicula
    {
        //Instancia de la BD Pelicula
        RentaPeliculasEntities Contexto;

        //Constructor
        public Datos_Pelicula()
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
        public bool EliminarPelicula(PELICULA pel)
        {
            PELICULA peltemp = PeliculaporID(pel.PELIID);
            if (PeliculaporID(pel.PELIID) != null)
            {
                Contexto.PELICULA.Remove(peltemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
        //PROCEDIMIENTOS ALMACENADOS
        public List<SeleccionarPeliculasSP_Result> SeleccionarPeliculasSP()
        {
            return Contexto.SeleccionarPeliculasSP().ToList();
        }
        public void InsertarPeliculasSP(PELICULA pel)
        {
            Contexto.InsertarPeliculaSP(pel.PELIID, pel.NOMBREPELI, pel.DIRECTORPELI, pel.GENEROPELI);
            Contexto.SaveChanges();
        }
        public bool ActualizarPeliculasSP(PELICULA pel)
        {
            if (pel != null)
            {
                //Actualizamos Datos
                Contexto.ActualizarPeliculaSP(pel.PELIID, pel.NOMBREPELI, pel.DIRECTORPELI, pel.GENEROPELI);
                Contexto.SaveChanges();//Guarda Cambios
                return true;
            }
            return false;
        }
        public void EliminarPeliculasSP(PELICULA pel)
        {
            Contexto.EliminarPeliculaSP(pel.PELIID);
        }
    }
}