using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace FrontRP.Data
{
    public class Data_Pelicula
    {
        public List<Modelos.Pelicula> CargarDatos()
        {
            string url = "https://localhost:44378/api/Pelicula";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Pelicula> pelisObjeto = JsonConvert.DeserializeObject<List<Modelos.Pelicula>>(response);
            return pelisObjeto;
        }
        public List<Modelos.Pelicula> CargarDatosPorID(string text)
        {
            string url = String.Format("https://localhost:44378/api/Pelicula/{0}", text);
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            Modelos.Pelicula pelisObjeto = JsonConvert.DeserializeObject<Modelos.Pelicula>(response);
            List<Modelos.Pelicula> listaPelTemp = new List<Modelos.Pelicula>();
            listaPelTemp.Add(pelisObjeto);
            return listaPelTemp;
        }

        //Cargar Nombre de la peli por el ID
        public string CargarNombrePel(string text)
        {
            string nombre = "";
              string url = String.Format("https://localhost:44378/api/Pelicula/{0}", text);
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            Modelos.Pelicula pelisObjeto = JsonConvert.DeserializeObject<Modelos.Pelicula>(response);
            nombre = pelisObjeto.NOMBREPELI;
            return nombre;
        }
        public void Ingresar(string id, string nom, string dir, string gen)
        {
            Modelos.Pelicula pelicula = new Modelos.Pelicula();

            //Enviar los datos en el modelo 
            pelicula.PELIID = id;
            pelicula.NOMBREPELI = nom;
            pelicula.DIRECTORPELI = dir;
            pelicula.GENEROPELI = gen;

            //Enviar la peticion del Back end
            string url = "https://localhost:44378/api/Pelicula";
            string verbo = "POST";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(pelicula);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
        }
        public void Actualizar(string id, string nom, string dir, string gen)
        {
            Modelos.Pelicula pelicula = new Modelos.Pelicula();

            //Enviar los datos en el modelo 
            pelicula.PELIID = id;
            pelicula.NOMBREPELI = nom;
            pelicula.DIRECTORPELI = dir;
            pelicula.GENEROPELI = gen;

            //Enviar la peticion del Back end
            string url = "https://localhost:44378/api/Pelicula/";
            string verbo = "PUT";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(pelicula);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
        }
        public void Borrar(string text)
        {
            //Enviar la peticion del Back end
            string url = String.Format("https://localhost:44378/api/Pelicula/{0}", text);
            string verbo = "DELETE";
            WebClient serviceRequest = new WebClient();
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadString(url, verbo, "");
        }
    }
}