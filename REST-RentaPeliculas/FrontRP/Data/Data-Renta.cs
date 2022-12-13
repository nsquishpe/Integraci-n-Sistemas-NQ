using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace FrontRP.Data
{
    public class Data_Renta
    {
        public List<Modelos.Renta> CargarDatos()
        {
            string url = "https://localhost:44393/api/Renta";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Renta> pelisObjeto = JsonConvert.DeserializeObject<List<Modelos.Renta>>(response);
            return pelisObjeto;
        }

        //Consulta Global
        public List<Modelos.AuxRentas> CargarDatosGlobal()
        {
            string url = "https://localhost:44393/api/Renta";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Renta> pelisObjeto = JsonConvert.DeserializeObject<List<Modelos.Renta>>(response);
            List<Modelos.AuxRentas> rentemporal = new List<Modelos.AuxRentas>();


            Data.Data_Cliente op = new Data.Data_Cliente();
            Data.Data_Pelicula op1 = new Data.Data_Pelicula();


            for (int i = 0; i < (pelisObjeto.Count()); i++)
            {
                Modelos.AuxRentas ren = new Modelos.AuxRentas();
                ren.RENTID = pelisObjeto[i].RENTID;
                ren.CLIID = pelisObjeto[i].CLIID;
                ren.NOMBRECLI = op.CargarNombreCli(pelisObjeto[i].CLIID);
                ren.PELIID = pelisObjeto[i].PELIID;
                ren.NOMBREPELI = op1.CargarNombrePel(pelisObjeto[i].PELIID);
                ren.FECHADEVRENT = pelisObjeto[i].FECHADEVRENT;
                ren.FECHAREGRENT = pelisObjeto[i].FECHAREGRENT;
                ren.FECHAENTRENT = pelisObjeto[i].FECHAENTRENT;
                rentemporal.Add(ren);
            }
            return rentemporal;
        }

        //Consulta Global por ID
        public List<Modelos.AuxRentas> CargarDatosGlobalPorID(string text)
        {
            List<Modelos.AuxRentas> ren = new List<Modelos.AuxRentas>();
            List<Modelos.AuxRentas> rentemporal = new List<Modelos.AuxRentas>();
            Modelos.AuxRentas ren2 = new Modelos.AuxRentas();
            rentemporal = CargarDatosGlobal();
            for (int i = 0; i < rentemporal.Count; i++)
            {
                if (rentemporal[i].RENTID == text)
                {
                    ren2 = rentemporal[i];
                    ren.Add(ren2);
                    break;
                }
            }
            return ren;
        }

        public List<Modelos.Renta> CargarDatosPorID(string text)
        {
            string url = String.Format("https://localhost:44393/api/Renta/{0}", text);
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            Modelos.Renta pelisObjeto = JsonConvert.DeserializeObject<Modelos.Renta>(response);
            List<Modelos.Renta> listaPelTemp = new List<Modelos.Renta>();
            listaPelTemp.Add(pelisObjeto);
            return listaPelTemp;
        }
        public void Ingresar(string id, string pelid, string clid, string fecha1, string fecha2, string fecha3)
        {
            Modelos.Renta renta = new Modelos.Renta();

            //Enviar los datos en el modelo 
            renta.RENTID = id;
            renta.PELIID = pelid;
            renta.CLIID = clid;
            renta.FECHAREGRENT = fecha1;
            renta.FECHADEVRENT = fecha2;
            renta.FECHAENTRENT = fecha3;

            //Enviar la peticion del Back end
            string url = "https://localhost:44393/api/Renta";
            string verbo = "POST";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(renta);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
        }
        public void Actualizar(string id, string pelid, string clid, string fecha1, string fecha2, string fecha3)
        {
            Modelos.Renta renta = new Modelos.Renta();

            //Enviar los datos en el modelo 
            renta.RENTID = id;
            renta.PELIID = pelid;
            renta.CLIID = clid;
            renta.FECHAREGRENT = fecha1;
            renta.FECHADEVRENT = fecha2;
            renta.FECHAENTRENT = fecha3;

            //Enviar la peticion del Back end
            string url = "https://localhost:44393/api/Renta/";
            string verbo = "PUT";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(renta);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
        }
        public void Borrar(string text)
        {
            //Enviar la peticion del Back end
            string url = String.Format("https://localhost:44393/api/Renta/{0}", text);
            string verbo = "DELETE";
            WebClient serviceRequest = new WebClient();
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadString(url, verbo, "");
        }
    }
}