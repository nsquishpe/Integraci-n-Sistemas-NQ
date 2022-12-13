using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontRP
{
    public partial class Pelicula : System.Web.UI.Page
    {
        private void CargarDatos()
        {
            string url = "https://localhost:44378/api/Pelicula";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Pelicula> clientesObjeto = JsonConvert.DeserializeObject<List<Modelos.Pelicula>>(response);
            GridView1.DataSource = clientesObjeto;
            GridView1.DataBind();
        }

        LogicaNegocio.LogicaPelicula op = new LogicaNegocio.LogicaPelicula();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Modelos.Pelicula> ltemp = new List<Modelos.Pelicula>();
            ltemp = op.CargarDatos();
            GridView1.DataSource = ltemp;
            GridView1.DataBind();
        }

        protected void Crear_Click(object sender, EventArgs e)
        {
            op.Ingresar(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            CargarDatos();
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            op.Actualizar(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            CargarDatos();
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            op.Borrar(TextBox2.Text);
            CargarDatos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Modelos.Pelicula> ltemp = new List<Modelos.Pelicula>();
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                ltemp = op.CargarDatos();

            }
            else
            {
                ltemp = op.CargarDatosPorID(TextBox1.Text);
            }
            GridView1.DataSource = ltemp;
            GridView1.DataBind();
        }
    }
}