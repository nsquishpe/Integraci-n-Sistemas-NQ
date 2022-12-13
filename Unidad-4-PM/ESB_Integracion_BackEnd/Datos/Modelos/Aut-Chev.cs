using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelos
{
    public class Aut_Chev
    {
        public int id { get; set; }
        public string Marca_Chevrolet { get; set; }
        public string Modelo_Chevrolet { get; set; }
        public string Cilindraje_Chevrolet { get; set; }
        public string Anio_Chevrolet { get; set; }
        public string Color_Chevrolet { get; set; }
        public string Tipo_Chevrolet { get; set; }
        public string Con_Chevrolet { get; set; }
        public string Fecha_Chevrolet { get; set; }
        public string img_Chevrolet { get; set; }

        public Aut_Chev() { }
        public Aut_Chev(string tx)
        {
            JObject obj = JObject.Parse(tx);
            id = (int)obj["id"];
            Marca_Chevrolet = (string)obj["Marca_Chevrolet"];
            Modelo_Chevrolet = (string)obj["Modelo_Chevrolet"];
            Cilindraje_Chevrolet = (string)obj["Cilindraje_Chevrolet"];
            Anio_Chevrolet = (string)obj["Anio_Chevrolet"];
            Color_Chevrolet = (string)obj["Color_Chevrolet"];
            Tipo_Chevrolet = (string)obj["Tipo_Chevrolet"];
            Con_Chevrolet = (string)obj["Con_Chevrolet"];
            Fecha_Chevrolet = (string)obj["Fecha_Chevrolet"];
            img_Chevrolet = (string)obj["img_Chevrolet"];
        }
    }

}
