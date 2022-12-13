using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontRP.Modelos
{
    public class AuxRentas
    {
        public string RENTID { get; set; }
        public string PELIID { get; set; }
        public string NOMBREPELI { get; set; }
        public string CLIID { get; set; }
        public string NOMBRECLI { get; set; }
        public string FECHAREGRENT { get; set; }
        public string FECHADEVRENT { get; set; }
        public string FECHAENTRENT { get; set; }

        public AuxRentas() { }
        public AuxRentas(string datosJson)
        {
            JObject datos = JObject.Parse(datosJson);

            RENTID = (string)datos["RENTID"];
            PELIID = (string)datos["PELIID"];
            NOMBREPELI = (string)datos["NOMBREPELI"];
            CLIID = (string)datos["CLIID"];
            NOMBRECLI = (string)datos["NOMBRECLI"];
            FECHAREGRENT = (string)datos["FECHAREGRENT"];
            FECHADEVRENT = (string)datos["FECHADEVRENT"];
            FECHAENTRENT = (string)datos["FECHAENTRENT"];
        }
    }
}