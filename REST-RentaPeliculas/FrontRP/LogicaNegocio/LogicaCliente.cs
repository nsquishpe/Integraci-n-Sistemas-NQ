using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace FrontRP.LogicaNegocio
{
    public class LogicaCliente
    {
        Data.Data_Cliente op = new Data.Data_Cliente();
        public List<Modelos.Cliente> CargarDatos()
        {
            return op.CargarDatos();
        }
        public List<Modelos.Cliente> CargarDatosPorID(string text)
        {
            return op.CargarDatosPorID(text);
        }
        public void Ingresar(string id, string nom, string ced, string email)
        {
           op.Ingresar(id, nom, ced, email);    
        }
        public void Actualizar(string id, string nom, string ced, string email)
        {
            op.Actualizar(id, nom, ced, email);
        }
        public void Borrar(string text)
        {
            op.Borrar(text);
        }
    }
}