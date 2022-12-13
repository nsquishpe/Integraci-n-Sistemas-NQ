using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD.Datos
{
    public class Datos_Cliente
    {
        //Instancia de la BD Cliente
        RentaPeliculasEntities Contexto;

        //Constructor
        public Datos_Cliente()
        {
            Contexto = new RentaPeliculasEntities();
            //Framework acorde a nuestros cambios IMPORTANTE
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
        //Consulta
        private CLIENTE ClienteporID(string ID)
        {
            return Contexto.CLIENTE.Where(cli => cli.CLIID == ID).SingleOrDefault();
        }
        public List<CLIENTE> ClienteporNombre(string nombre)
        {
            return Contexto.CLIENTE.Where(cli => cli.NOMBRECLI == nombre).ToList();
        }
        //Metodos
        public List<CLIENTE> SeleccionarClientes()
        {
            return Contexto.CLIENTE.ToList();
        }
        public void InsertarCliente(CLIENTE cli)
        {
            Contexto.CLIENTE.Add(cli);
            Contexto.SaveChanges();
        }
        public bool ActualizarCliente(CLIENTE cli)
        {
            CLIENTE clitemp = ClienteporID(cli.CLIID);
            if(ClienteporID(cli.CLIID) != null)
            {
                clitemp.NOMBRECLI = cli.NOMBRECLI;
                clitemp.EMAILCLI = cli.EMAILCLI;
                clitemp.CEDULACLI = cli.CEDULACLI;
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarCliente(CLIENTE cli)
        {
            CLIENTE clitemp = ClienteporID(cli.CLIID);
            if (ClienteporID(cli.CLIID) != null)
            {
                Contexto.CLIENTE.Remove(clitemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }

        //PROCEDIMIENTOS ALMACENADOS
        public List<SeleccionarClientes_Result> SeleccionarClientesSP()
        {
            return Contexto.SeleccionarClientes().ToList();
        }
        public void InsertarClientesSP(CLIENTE cli)
        {
            Contexto.InsertarClienteSP(cli.CLIID, cli.NOMBRECLI, cli.CEDULACLI, cli.EMAILCLI, cli.MEMID);
            Contexto.SaveChanges();
        }
        public bool ActualizarClientesSP(CLIENTE cli)
        {
            if (cli != null)
            {
                //Actualizamos Datos
                Contexto.ActualizarClienteSP(cli.CLIID, cli.NOMBRECLI, cli.CEDULACLI, cli.EMAILCLI);
                Contexto.SaveChanges();//Guarda Cambios
                return true;
            }
            return false;
        }
        public void EliminarClientesSP(CLIENTE cli)
        {
            Contexto.EliminarClienteSP(cli.CLIID);
        }

    }
}