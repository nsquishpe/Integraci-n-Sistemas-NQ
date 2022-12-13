using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD.LogicaNegocio
{
    public class LN_Pelicula
    {
        //Instancia de datos
        Datos.Datos_Pelicula crud_pel = new Datos.Datos_Pelicula();
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
        public bool EliminarPelicula(PELICULA pel)
        {
            return crud_pel.EliminarPelicula(pel);
        }
        public List<PELICULA> SeleccionarPeliculaDef(string ID = "Buscar")
        {
            PELICULA peltemp = new PELICULA();
            peltemp = SeleccionarPeliculaPorID(ID);
            List<PELICULA> peliculas = new List<PELICULA>();
            if (ID == "Buscar")
            {
                return SeleccionarPelicula().ToList();
            }
            else
            {
                peliculas.Add(peltemp);
                return peliculas;
            }
        }
        //PROCEDIMIENTOS ALMACENADOS
        public List<SeleccionarPeliculasSP_Result> SeleccionarPeliculasSP()
        {
            return crud_pel.SeleccionarPeliculasSP();
        }
        public void InsertarPeliculasSP(PELICULA pel)
        {
            crud_pel.InsertarPeliculasSP(pel);
        }
        public bool ActualizarPeliculasSP(PELICULA pel)
        {
            return crud_pel.ActualizarPeliculasSP(pel);
        }
        public void EliminarPeliculasSP(PELICULA pel)
        {
            crud_pel.EliminarPeliculasSP(pel);
        }
    }
}