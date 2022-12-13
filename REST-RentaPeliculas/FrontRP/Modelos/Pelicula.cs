using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontRP.Modelos
{
    public class Pelicula
    {
        public string PELIID { get; set; }
        public string NOMBREPELI { get; set; }
        public string DIRECTORPELI { get; set; }
        public string GENEROPELI { get; set; }

        public Pelicula() { }
        public Pelicula(string datosJson)
        {
            JObject datos = JObject.Parse(datosJson);

            PELIID = (string)datos["CLIID"];
            NOMBREPELI = (string)datos["NOMBRECLI"];
            DIRECTORPELI = (string)datos["CEDULACLI"];
            GENEROPELI = (string)datos["EMAILCLI"];
        }
    }
}