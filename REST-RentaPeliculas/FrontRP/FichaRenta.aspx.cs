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
    public partial class FichaRenta : System.Web.UI.Page
    {
        private void CargarDatos()
        {
            string url = "https://localhost:44393/api/Renta";
            //Permite que el cliente se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Renta> RentaObjeto = JsonConvert.DeserializeObject<List<Modelos.Renta>>(response);
            GridView1.DataSource = RentaObjeto;
            GridView1.DataBind();
        }
        LogicaNegocio.LogicaRenta op = new LogicaNegocio.LogicaRenta();

        private void listarClientes(List<Modelos.Cliente> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                DropDownList1.Items.Add(list[i].NOMBRECLI);
            }
        }
        private string ClientePorNombre(string nombre)
        {
            string id = "";
            LogicaNegocio.LogicaCliente op1 = new LogicaNegocio.LogicaCliente();
            List<Modelos.Cliente> list = new List<Modelos.Cliente>();
            list = op1.CargarDatos();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].NOMBRECLI == nombre)
                {
                    id = list[i].CLIID;
                    break;
                }
            }
            return id;
        }

        private void listarPeliculas(List<Modelos.Pelicula> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                DropDownList2.Items.Add(list[i].NOMBREPELI);
            }
        }
        private string PeliculaPorNombre(string nombre)
        {
            string id = "";
            LogicaNegocio.LogicaPelicula op1 = new LogicaNegocio.LogicaPelicula();
            List<Modelos.Pelicula> list = new List<Modelos.Pelicula>();
            list = op1.CargarDatos();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].NOMBREPELI == nombre)
                {
                    id = list[i].PELIID;
                    break;
                }
            }
            return id;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Modelos.AuxRentas> rentemporal = new List<Modelos.AuxRentas>();
            rentemporal = op.CargarDatosGlobal();
            GridView1.DataSource = rentemporal;
            GridView1.DataBind();

            //LLENAR DATOS SELECT clientes
            LogicaNegocio.LogicaCliente op1 = new LogicaNegocio.LogicaCliente();
            List<Modelos.Cliente> ltemp1 = new List<Modelos.Cliente>();
            ltemp1 = op1.CargarDatos();
            listarClientes(ltemp1);

            //LLENAR DATOS SELECT peliculas
            LogicaNegocio.LogicaPelicula op2 = new LogicaNegocio.LogicaPelicula();
            List<Modelos.Pelicula> ltemp2 = new List<Modelos.Pelicula>();
            ltemp2 = op2.CargarDatos();
            listarPeliculas(ltemp2);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Modelos.AuxRentas> ltemp = new List<Modelos.AuxRentas>();
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                ltemp = op.CargarDatosGlobal();

            }
            else
            {
                ltemp = op.CargarDatosGlobalPorID(TextBox1.Text);
            }
            GridView1.DataSource = ltemp;
            GridView1.DataBind();
        }

        protected void Crear_Click(object sender, EventArgs e)
        {
            string aux = ClientePorNombre(DropDownList1.SelectedItem.Value);
            string aux1 = PeliculaPorNombre(DropDownList2.SelectedItem.Value);

            op.Ingresar(TextBox2.Text, aux1, aux, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            CargarDatos();
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            string aux = ClientePorNombre(DropDownList1.SelectedItem.Value);
            string aux1 = PeliculaPorNombre(DropDownList2.SelectedItem.Value);

            op.Actualizar(TextBox2.Text, aux1, aux, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            CargarDatos();
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            op.Borrar(TextBox2.Text);
            CargarDatos();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}