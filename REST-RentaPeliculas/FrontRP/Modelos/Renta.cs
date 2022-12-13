using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontRP.Modelos
{
    public class Renta
    {
        public string RENTID { get; set; }
        public string PELIID { get; set; }
        public string CLIID { get; set; }
        public string FECHAREGRENT { get; set; }
        public string FECHADEVRENT { get; set; }
        public string FECHAENTRENT { get; set; }

        public Renta() { }
        public Renta(string datosJson)
        {
            JObject datos = JObject.Parse(datosJson);

            RENTID = (string)datos["RENTID"];
            PELIID = (string)datos["PELIID"];
            CLIID = (string)datos["CLIID"];
            FECHAREGRENT = (string)datos["FECHAREGRENT"];
            FECHADEVRENT = (string)datos["FECHADEVRENT"];
            FECHAENTRENT = (string)datos["FECHAENTRENT"];
        }
    }
}