using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Demo001RestFrontCliente.Vistas.Cliente
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();

        }
        private void CargarDatos()
        {
            string url = "https://localhost:44342/api/Cliente";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Clientes> clientesObjeto = JsonConvert.DeserializeObject<List<Modelos.Clientes>>(response);
            GridView1.DataSource = clientesObjeto;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                CargarDatos();
            }
            else
            {
                string url = String.Format("https://localhost:44342/api/Cliente/{0}", TextBox1.Text);
                //Permite que el cliente se conecte con la API para tener los datos
                WebClient serviceRequest = new WebClient();
                string response = serviceRequest.DownloadString(url);
                Modelos.Clientes clientesObjeto = JsonConvert.DeserializeObject<Modelos.Clientes>(response);
                List<Modelos.Clientes> listaCliTemp = new List<Modelos.Clientes>();
                listaCliTemp.Add(clientesObjeto);
                GridView1.DataSource = listaCliTemp;
                GridView1.DataBind();
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Modelos.Clientes cliente = new Modelos.Clientes();

            //Enviar los datos en el modelo estudiante
            cliente.id = int.Parse(txtid.Text);
            cliente.nombre = txtnombre.Text;
            cliente.email = txtemail.Text;

            //Enviar la peticion del Back end
            string url = "https://localhost:44342/api/Cliente/";
            string verbo = "POST";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(cliente);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
            CargarDatos();

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Modelos.Clientes cliente = new Modelos.Clientes();

            //Enviar los datos en el modelo estudiante
            cliente.id = int.Parse(txtid.Text);
            cliente.nombre = txtnombre.Text;
            cliente.email = txtemail.Text;

            //Enviar la peticion del Back end
            string url = "https://localhost:44342/api/Cliente/";
            string verbo = "PUT";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(cliente);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] bytes = encoding.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadData(url, verbo, bytes);
            CargarDatos();

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            //Enviar la peticion del Back end
            string url = String.Format("https://localhost:44342/api/Cliente/{0}", txtid.Text);
            string verbo = "DELETE";
            WebClient serviceRequest = new WebClient();
            serviceRequest.Headers.Add("Content-Type", "application/json");
            serviceRequest.UploadString(url, verbo, "");
            CargarDatos();

        }
    }
}