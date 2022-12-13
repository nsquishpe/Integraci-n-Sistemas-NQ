using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontRP.Modelos
{
    public class Membresia
    {
        public string MEMID { get; set; }
        public string CLIID { get; set; }
        public string FECHAREGMEM { get; set; }
        public string FECHAEXOMEM { get; set; }

        public Membresia() { }
        public Membresia(string datosJson)
        {
            JObject datos = JObject.Parse(datosJson);

            MEMID = (string)datos["MEMID"];
            CLIID = (string)datos["CLIID"];
            FECHAREGMEM = (string)datos["FECHAREGMEM"];
            FECHAEXOMEM = (string)datos["FECHAEXOMEM"];
        }
    }
}