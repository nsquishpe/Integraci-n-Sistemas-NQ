using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontRP.Modelos
{
    public class Cliente
    {
        public string CLIID { get; set; }
        public string NOMBRECLI { get; set; }
        public string CEDULACLI { get; set; }
        public string EMAILCLI { get; set; }

        public Cliente() { }
        public Cliente(string datosJson)
        {
            JObject datos = JObject.Parse(datosJson);

            CLIID = (string)datos["CLIID"];
            NOMBRECLI = (string)datos["NOMBRECLI"];
            CEDULACLI = (string)datos["CEDULACLI"];
            EMAILCLI = (string)datos["EMAILCLI"];
        }
    }
}