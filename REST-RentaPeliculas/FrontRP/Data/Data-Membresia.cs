using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace FrontRP.Data
{
    public class Data_Membresia
    {
        public List<Modelos.Membresia> CargarDatos()
        {
            string url = "https://localhost:44391/api/Membresia";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Membresia> memsObjeto = JsonConvert.DeserializeObject<List<Modelos.Membresia>>(response);
            return memsObjeto;
        }
        //Consulta Global
        public List<Modelos.AuxMembresia> CargarDatosGlobal()
        {
            string url = "https://localhost:44391/api/Membresia";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Membresia> memsObjeto = JsonConvert.DeserializeObject<List<Modelos.Membresia>>(response);
            List<Modelos.AuxMembresia> memtemporal = new List<Modelos.AuxMembresia>();
           

            Data.Data_Cliente op = new Data.Data_Cliente();
            for (int i = 0; i < (memsObjeto.Count()); i++)
            {
                Modelos.AuxMembresia mem = new Modelos.AuxMembresia();
                mem.MEMID = memsObjeto[i].MEMID;
                mem.CLIID = memsObjeto[i].CLIID;
                mem.NOMBRECLI = op.CargarNombreCli(memsObjeto[i].CLIID);
                mem.FECHAREGMEM = memsObjeto[i].FECHAREGMEM;
                mem.FECHAEXOMEM = memsObjeto[i].FECHAEXOMEM;
                memtemporal.Add(mem);
            }
            return memtemporal;
        }
        //Consulta Global por ID
        public List<Modelos.AuxMembresia> CargarDatosGlobalPorID(string text)
        {
            List<Modelos.AuxMembresia> mem = new List<Modelos.AuxMembresia>();
            List<Modelos.AuxMembresia> memtemporal = new List<Modelos.AuxMembresia>();
            Modelos.AuxMembresia mem2 = new Modelos.AuxMembresia();
            memtemporal = CargarDatosGlobal();
            for (int i = 0; i < memtemporal.Count; i++)
            {
                if (memtemporal[i].MEMID == text)
                {
                    mem2 = memtemporal[i];
                    mem.Add(mem2);
                    break;
                }
            }
            return mem;
        }


        public List<Modelos.Membresia> CargarDatosPorID(string text)
        {
            string url = String.Format("https://localhost:44391/api/Membresia/{0}", text);
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            Modelos.Membresia memsObjeto = JsonConvert.DeserializeObject<Modelos.Membresia>(response);
            List<Modelos.Membresia> listaMemTemp = new List<Modelos.Membresia>();
            listaMemTemp.Add(memsObjeto);
            return listaMemTemp;
        }
        public void Ingresar(string idmem, string idcli, string fecha1, string fecha2)
        {
            Modelos.Membresia membresia = new Modelos.Membresia();

            //Enviar los datos en el modelo 
            membresia.MEMID = idmem;
            membresia.CLIID = idcli;
            membresia.FECHAREGMEM = fecha1;
            membresia.FECHAEXOMEM = fecha2;

            //Enviar la peticion del Back end
            string url = "https://localhost:44391/api/Membresia";
            string verbo = "POST";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(membresia);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
            CargarDatos();
        }
        public void Actualizar(string idmem, string idcli, string fecha1, string fecha2)
        {
            Modelos.Membresia membresia = new Modelos.Membresia();

            //Enviar los datos en el modelo 
            membresia.MEMID = idmem;
            membresia.CLIID = idcli;
            membresia.FECHAREGMEM = fecha1;
            membresia.FECHAEXOMEM = fecha2;

            //Enviar la peticion del Back end
            string url = "https://localhost:44391/api/Membresia/";
            string verbo = "PUT";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(membresia);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
            CargarDatos();
        }
        public void Borrar(string text)
        {
            //Enviar la peticion del Back end
            string url = String.Format("https://localhost:44391/api/Membresia/{0}", text);
            string verbo = "DELETE";
            WebClient serviceRequest = new WebClient();
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadString(url, verbo, "");
            CargarDatos();
        }
    }
}