using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontRP.LogicaNegocio
{
    public class LogicaRenta
    {
        Data.Data_Renta op = new Data.Data_Renta();
        public List<Modelos.Renta> CargarDatos()
        {
            return op.CargarDatos();
        }
        public List<Modelos.Renta> CargarDatosPorID(string text)
        {
            return op.CargarDatosPorID(text);
        }
        public void Ingresar(string id, string pelid, string clid, string fecha1, string fecha2, string fecha3)
        {
            op.Ingresar(id, pelid, clid, fecha1, fecha2, fecha3);
        }
        public void Actualizar(string id, string pelid, string clid, string fecha1, string fecha2, string fecha3)
        {
            op.Actualizar(id, pelid, clid, fecha1, fecha2, fecha3);
        }
        public void Borrar(string text)
        {
            op.Borrar(text);
        }
        //Consulta Global
        public List<Modelos.AuxRentas> CargarDatosGlobal()
        {
            return op.CargarDatosGlobal();
        }
        //Consulta Global por ID
        public List<Modelos.AuxRentas> CargarDatosGlobalPorID(string text)
        {
            return op.CargarDatosGlobalPorID(text);
        }
    }
}