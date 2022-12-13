using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace FrontRP.Data
{
    public class Data_Cliente
    {
        public List<Modelos.Cliente> CargarDatos()
        {
            string url = "https://localhost:44392/api/Cliente";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Cliente> clientesObjeto = JsonConvert.DeserializeObject<List<Modelos.Cliente>>(response);
            return clientesObjeto;
        }
        //Cargar Nombre de Cliente por el ID
        public string CargarNombreCli(string text)
        {
            string nombre ="";
            string url = String.Format("https://localhost:44392/api/Cliente/{0}", text);
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            Modelos.Cliente clientesObjeto = JsonConvert.DeserializeObject<Modelos.Cliente>(response);
            nombre = clientesObjeto.NOMBRECLI;
            return nombre;
        }
        public List<Modelos.Cliente> CargarDatosPorID(string text)
        {
            string url = String.Format("https://localhost:44392/api/Cliente/{0}", text);
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            Modelos.Cliente clientesObjeto = JsonConvert.DeserializeObject<Modelos.Cliente>(response);
            List<Modelos.Cliente> listaCliTemp = new List<Modelos.Cliente>();
            listaCliTemp.Add(clientesObjeto);
            return listaCliTemp;
        }
        public void Ingresar(string id, string nom, string ced, string email)
        {
            Modelos.Cliente cliente = new Modelos.Cliente();

            //Enviar los datos en el modelo 
            cliente.CLIID = id;
            cliente.NOMBRECLI = nom;
            cliente.CEDULACLI = ced;
            cliente.EMAILCLI = email;

            //Enviar la peticion del Back end
            string url = "https://localhost:44392/api/Cliente";
            string verbo = "POST";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(cliente);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
            CargarDatos();
        }
        public void Actualizar(string id, string nom, string ced, string email)
        {
            Modelos.Cliente cliente = new Modelos.Cliente();

            //Enviar los datos en el modelo 
            cliente.CLIID = id;
            cliente.NOMBRECLI = nom;
            cliente.CEDULACLI = ced;
            cliente.EMAILCLI = email;

            //Enviar la peticion del Back end
            string url = "https://localhost:44392/api/Cliente/";
            string verbo = "PUT";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(cliente);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
            CargarDatos();
        }
        public void Borrar(string text)
        {
            //Enviar la peticion del Back end
            string url = String.Format("https://localhost:44392/api/Cliente/{0}", text);
            string verbo = "DELETE";
            WebClient serviceRequest = new WebClient();
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadString(url, verbo, "");
            CargarDatos();
        }
    }
}