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
    public partial class Membresia : System.Web.UI.Page
    {
        private void CargarDatos()
        {
            string url = "https://localhost:44391/api/Membresia";
            //Permite que la membresia se conecte con la API para tener los datos
            WebClient serviceRequest = new WebClient();
            string response = serviceRequest.DownloadString(url);
            List<Modelos.Membresia> clientesObjeto = JsonConvert.DeserializeObject<List<Modelos.Membresia>>(response);
            GridView1.DataSource = clientesObjeto;
            GridView1.DataBind();
        }
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
                if(list[i].NOMBRECLI == nombre)
                {
                    id = list[i].CLIID;
                    break;
                }
            }
            return id;
        }

        LogicaNegocio.LogicaMembresia op = new LogicaNegocio.LogicaMembresia();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Modelos.AuxMembresia> ltemp = new List<Modelos.AuxMembresia>();
            ltemp = op.CargarDatosGlobal();
            GridView1.DataSource = ltemp;
            GridView1.DataBind();

            //LLENAR DATOS SELECT
            LogicaNegocio.LogicaCliente op1 = new LogicaNegocio.LogicaCliente();
            List<Modelos.Cliente> ltemp1 = new List<Modelos.Cliente>();
            ltemp1 = op1.CargarDatos();
            listarClientes(ltemp1);


        }

        protected void Crear_Click(object sender, EventArgs e)
        {
            string aux = ClientePorNombre(DropDownList1.SelectedItem.Value);
            op.Ingresar(TextBox2.Text, aux, TextBox4.Text, TextBox5.Text);
            CargarDatos();
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            string aux = ClientePorNombre(DropDownList1.SelectedItem.Value);
            op.Actualizar(TextBox2.Text, aux, TextBox4.Text, TextBox5.Text);
            CargarDatos();
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            op.Borrar(TextBox2.Text);
            CargarDatos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Modelos.AuxMembresia> ltemp = new List<Modelos.AuxMembresia>();
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                ltemp = op.CargarDatosGlobal();

            }
            else
            {
                string temp = TextBox1.Text;
                ltemp = op.CargarDatosGlobalPorID(temp);
            }
            GridView1.DataSource = ltemp;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged()
        {

        }
    }
}