using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontRP.Modelos
{
    public class AuxMembresia
    {
        public string MEMID { get; set; }
        public string CLIID { get; set; }
        public string NOMBRECLI { get; set; }
        public string FECHAREGMEM { get; set; }
        public string FECHAEXOMEM { get; set; }

        public AuxMembresia() { }
        public AuxMembresia(string datosJson)
        {
            JObject datos = JObject.Parse(datosJson);

            MEMID = (string)datos["MEMID"];
            CLIID = (string)datos["CLIID"];
            NOMBRECLI = (string)datos["NOMBRECLI"];
            FECHAREGMEM = (string)datos["FECHAREGMEM"];
            FECHAEXOMEM = (string)datos["FECHAEXOMEM"];
        }
    }
}