using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontRP.LogicaNegocio
{
    public class LogicaPelicula
    {
        Data.Data_Pelicula op = new Data.Data_Pelicula();
        public List<Modelos.Pelicula> CargarDatos()
        {
            return op.CargarDatos();
        }
        public List<Modelos.Pelicula> CargarDatosPorID(string text)
        {
            return op.CargarDatosPorID(text);
        }
        public void Ingresar(string id, string nom, string dir, string gen)
        {
            op.Ingresar(id, nom, dir, gen);
        }
        public void Actualizar(string id, string nom, string dir, string gen)
        {
            op.Actualizar(id, nom, dir, gen);
        }
        public void Borrar(string text)
        {
            op.Borrar(text);
        }
    }
}