using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace Demo001RestFrontCliente.Modelos
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }

        public Clientes() { }
        public Clientes(string datosJson)
        {
            JObject datos = JObject.Parse(datosJson);

            id = (int)datos["id"];
            nombre = (string)datos["nombre"];
            email = (string)datos["email"];
        }
    } 
}