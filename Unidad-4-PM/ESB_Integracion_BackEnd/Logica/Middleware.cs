using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Newtonsoft.Json;

namespace Logica
{
    public class Middleware
    {
        public List<Datos.Modelos.Aut_Chev> SeleccionarAutosChevrolt()
        {
            string url = "https://localhost:44333/api/ChevApi";
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));
            List<Datos.Modelos.Aut_Chev> Autosobjeto = JsonConvert.DeserializeObject<List<Datos.Modelos.Aut_Chev>>(response);
            return Autosobjeto;
        }

        //Traer datos del FORD
        SWFord.SOA_Ford opFord = new SWFord.SOA_Ford();
        public List<SWFord.Auto_FORD> SeleccionarAutosFord()
        {
            return opFord.SeleccionarAutosChev().ToList();
        }

        public List<Datos.DTO.DTOAutosEcuador> SeleccionarAutosEC(){

            List<Datos.DTO.DTOAutosEcuador> lstAutosEcuador = new List<Datos.DTO.DTOAutosEcuador> ();
            foreach (var item in SeleccionarAutosChevrolt())
            {
                Datos.DTO.DTOAutosEcuador dato = new Datos.DTO.DTOAutosEcuador();
                dato.Marca_autosEC = item.Marca_Chevrolet;
                dato.Modelo_autosEC = item.Modelo_Chevrolet;
                dato.Color_autosEC = item.Color_Chevrolet;
                dato.Anio_autosEC = item.Anio_Chevrolet;
                dato.Cons_autosEC = item.Con_Chevrolet;
                dato.Tipo_autosEC = item.Tipo_Chevrolet;
                dato.img_autosEC = item.img_Chevrolet;
                lstAutosEcuador.Add(dato);
            }
            foreach (var item in SeleccionarAutosFord())
            {
                Datos.DTO.DTOAutosEcuador dato = new Datos.DTO.DTOAutosEcuador();
                dato.Marca_autosEC = item.Marca_Ford;
                dato.Modelo_autosEC = item.Modelo_Ford;
                dato.Color_autosEC = item.Color_Ford;
                dato.Anio_autosEC = item.Anio_Ford;
                dato.Cons_autosEC = item.Con_Ford;
                dato.Tipo_autosEC = item.Tipo_Ford;
                dato.img_autosEC = item.img_Ford;
                lstAutosEcuador.Add(dato);
            }
            return lstAutosEcuador;
        }
        public List<Datos.DTO.DTOAutosEcuador> SeleccionarAutosEcuadorPorTipo(string Tipo)
        {
            List<Datos.DTO.DTOAutosEcuador> aux = new List<Datos.DTO.DTOAutosEcuador>();
            if (Tipo == "All")
            {
                return SeleccionarAutosEC();
            }
            else
            {
                aux = SeleccionarAutosEC().Where(a => a.Tipo_autosEC.Contains(Tipo)).ToList();
                return aux;
            }
        }
    }
}
