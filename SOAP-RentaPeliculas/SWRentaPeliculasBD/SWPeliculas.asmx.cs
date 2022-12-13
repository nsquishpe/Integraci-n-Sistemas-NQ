using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SWRentaPeliculasBD
{
    /// <summary>
    /// Descripción breve de SWPeliculas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWPeliculas : System.Web.Services.WebService
    {
        LogicaNegocio.LN_Pelicula opc = new LogicaNegocio.LN_Pelicula();
        [WebMethod]
        public List<PELICULA> SeleccionarPeliculas()
        {
            return opc.SeleccionarPelicula();
        }
        [WebMethod]
        public PELICULA SeleccionarPeliculaPorID(string ID)
        {
            return opc.SeleccionarPeliculaPorID(ID);
        }
        //CRUD
        [WebMethod]
        public void InsertarPelicula(PELICULA pel)
        {
            opc.InsertarPelicula(pel);
        }
        [WebMethod]
        public bool ActualizarPelicula(PELICULA pel)
        {
            return opc.ActualizarPelicula(pel);
        }
        [WebMethod]
        public bool EliminarPelicula(PELICULA pel)
        {
            return opc.EliminarPelicula(pel);
        }
        [WebMethod]
        public List<PELICULA> SeleccionarPeliculasDef(string ID = "Buscar")
        {
            return opc.SeleccionarPeliculaDef(ID);
        }
        //PROCEDIMIENTOS ALMACENADOS
        [WebMethod]
        public List<SeleccionarPeliculasSP_Result> SeleccionarPeliculasSP()
        {
            return opc.SeleccionarPeliculasSP();
        }
        [WebMethod]
        public void InsertarPeliculasSP(PELICULA pel)
        {
            opc.InsertarPeliculasSP(pel);
        }
        [WebMethod]
        public bool ActualizarPeliculasSP(PELICULA pel)
        {
            return opc.ActualizarPeliculasSP(pel);
        }
        [WebMethod]
        public void EliminarPeliculasSP(PELICULA pel)
        {
            opc.EliminarPeliculasSP(pel);
        }
    }
}
