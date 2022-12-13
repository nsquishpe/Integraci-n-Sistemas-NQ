using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClientes.Data_Cliente
{
    public class DatosCli
    {
        //Instancia de la BD Cliente
        RentaPeliculasEntities Contexto;

        //Constructor
        public DatosCli()
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
            if (ClienteporID(cli.CLIID) != null)
            {
                clitemp.NOMBRECLI = cli.NOMBRECLI;
                clitemp.EMAILCLI = cli.EMAILCLI;
                clitemp.CEDULACLI = cli.CEDULACLI;
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarCliente(string id)
        {
            CLIENTE clitemp = ClienteporID(id);
            if (ClienteporID(id) != null)
            {
                Contexto.CLIENTE.Remove(clitemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}