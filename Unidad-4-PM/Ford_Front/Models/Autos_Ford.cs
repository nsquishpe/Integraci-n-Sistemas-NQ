using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace Ford_Front.Models
{
    public class Autos_Ford
    {
        public int id { get; set; }
        public string Marca_Ford { get; set; }
        public string Modelo_Ford { get; set; }
        public string Cilindraje_Ford { get; set; }
        public string Anio_Ford { get; set; }
        public string Color_Ford { get; set; }
        public string Tipo_Ford { get; set; }
        public string Con_Ford { get; set; }
        public string Fecha_Ford { get; set; }

        public Autos_Ford() { }
        public Autos_Ford(string tx)
        {
            JObject obj = JObject.Parse(tx);
            id = (int)obj["id"];
            Marca_Ford = (string)obj["Marca_Ford"];
            Modelo_Ford = (string)obj["Modelo_Ford"];
            Cilindraje_Ford = (string)obj["Cilindraje_Ford"];
            Anio_Ford = (string)obj["Anio_Ford"];
            Color_Ford = (string)obj["Color_Ford"];
            Tipo_Ford = (string)obj["Tipo_Ford"];
            Con_Ford = (string)obj["Con_Ford"];
            Fecha_Ford = (string)obj["Fecha_Ford"];
        }
    }
}