using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace FrontRP.LogicaNegocio
{
    public class LogicaMembresia
    {
        Data.Data_Membresia op = new Data.Data_Membresia();
        public List<Modelos.Membresia> CargarDatos()
        {
            return op.CargarDatos();
        }
        public List<Modelos.Membresia> CargarDatosPorID(string text)
        {
            return op.CargarDatosPorID(text);
        }
        public void Ingresar(string idmem, string idcli, string fecha1, string fecha2)
        {
            op.Ingresar(idmem, idcli, fecha1, fecha2);
        }
        public void Actualizar(string idmem, string idcli, string fecha1, string fecha2)
        {
            op.Actualizar(idmem, idcli, fecha1, fecha2);
        }
        public void Borrar(string text)
        {
            op.Borrar(text);
        }
        //Consulta Global
        public List<Modelos.AuxMembresia> CargarDatosGlobal()
        {
            return op.CargarDatosGlobal();
        }
        //Consulta Global por ID
        public List<Modelos.AuxMembresia> CargarDatosGlobalPorID(string text)
        {
            return op.CargarDatosGlobalPorID(text);
        }

    }
}