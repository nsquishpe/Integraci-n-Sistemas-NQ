using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiPeliculas.Logica_Pelicula
{
    public class LogicaPeli
    {
        //Instancia de datos
        Data_Pelicula.DatosPeli crud_pel = new Data_Pelicula.DatosPeli();
        //Metodo - almacena en lista todos las peliculas
        public List<PELICULA> SeleccionarPelicula()
        {
            return crud_pel.SeleccionarPeliculas();
        }
        //Metodo - almacena membresias por cedula
        public PELICULA SeleccionarPeliculaPorID(string ID)
        {
            if (ID == null)
            {
                return null;
            }
            else
            {
                return SeleccionarPelicula().SingleOrDefault(pel => pel.PELIID == ID);
            }
        }
        //CRUD
        public void InsertarPelicula(PELICULA pel)
        {
            crud_pel.InsertarPelicula(pel);
        }
        public bool ActualizarPelicula(PELICULA pel)
        {
            return crud_pel.ActualizarPelicula(pel);
        }
        public bool EliminarPelicula(string id)
        {
            return crud_pel.EliminarPelicula(id);
        }
    }
}