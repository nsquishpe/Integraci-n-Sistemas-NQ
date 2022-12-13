using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ford_Front
{
    public partial class Ford_Form : System.Web.UI.Page
    {
        private void cargardatos()
        {
            string url = "https://localhost:44387/api/ford";
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(new Uri(url));
            List<Models.Autos_Ford> Autosobjeto = JsonConvert.DeserializeObject<List<Models.Autos_Ford>>(response);
            GridView1.DataSource = Autosobjeto;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Models.Autos_Ford datos = new Models.Autos_Ford();

            datos.id = int.Parse(TextBox1.Text);
            datos.Marca_Ford = TextBox2.Text;
            datos.Modelo_Ford = TextBox3.Text;
            datos.Cilindraje_Ford = TextBox4.Text;
            datos.Anio_Ford = TextBox5.Text;
            datos.Color_Ford = TextBox6.Text;
            datos.Tipo_Ford = TextBox7.Text;
            datos.Con_Ford = TextBox10.Text;
            datos.Fecha_Ford = TextBox11.Text;

            string url = "https://localhost:44387/api/ford";
            string vervo = "POST";

            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(datos);
            List<Models.Autos_Ford> autos_Fords = new List<Models.Autos_Ford>();
            UTF8Encoding codificacion = new UTF8Encoding();

            Byte[] bytes = codificacion.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("content-type", "application/json");
            serviceRequest.UploadData(url, vervo, bytes);
            GridView1.DataSource = autos_Fords;
            GridView1.DataBind();

            cargardatos();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Models.Autos_Ford datos = new Models.Autos_Ford();
            List<Models.Autos_Ford> autos_Fords = new List<Models.Autos_Ford>();
            GridView1.DataSource = autos_Fords;
            GridView1.DataBind();

            datos.id = int.Parse(TextBox1.Text);
            datos.Marca_Ford = TextBox2.Text;
            datos.Modelo_Ford = TextBox3.Text;
            datos.Cilindraje_Ford = TextBox4.Text;
            datos.Anio_Ford = TextBox5.Text;
            datos.Color_Ford = TextBox6.Text;
            datos.Tipo_Ford = TextBox7.Text;
            datos.Con_Ford = TextBox10.Text;
            datos.Fecha_Ford = TextBox11.Text;

            string url = "https://localhost:44387/api/ford/" + TextBox1.Text;
            string vervo = "PUT";
            WebClient serviceRequest = new WebClient();
            string jsonObjeto = JsonConvert.SerializeObject(datos);
            UTF8Encoding codificacion = new UTF8Encoding();
            Byte[] bytes = codificacion.GetBytes(jsonObjeto);
            serviceRequest.Headers.Add("content-type", "application/json");
            serviceRequest.UploadData(url, vervo, bytes);
            cargardatos();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44387/api/ford/" + TextBox1.Text;
            string vervo = "DELETE";
            WebClient serviceRequest = new WebClient();
            serviceRequest.Headers.Add("content-type", "application/json");
            serviceRequest.UploadString(url, vervo, "");
            cargardatos();
        }
    }
}