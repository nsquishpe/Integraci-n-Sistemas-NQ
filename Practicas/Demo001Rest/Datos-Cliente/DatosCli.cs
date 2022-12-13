using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo001Rest.Datos_Cliente
{
    public class DatosCli
    {
        ClienteNQEntities contextoClientes;
        public DatosCli()
        {
            contextoClientes = new ClienteNQEntities();
        }
        public List<Clientes> SeleccionarClientes()
        {
            return contextoClientes.Clientes.ToList();
        }
        public Clientes SeleccionarClientesPorID(int id)
        {
            return contextoClientes.Clientes.Where(cli => cli.id == id).SingleOrDefault();
        }
        public int InsertarCliente(Clientes cli)
        {
            contextoClientes.Clientes.Add(cli);
            contextoClientes.SaveChanges();
            return cli.id;
        }
        private Clientes ClienteporID(int ID)
        {
            return contextoClientes.Clientes.Where(cli => cli.id == ID).SingleOrDefault();
        }
        public bool ActualizarCliente(Clientes cli)
        {
            Clientes clitemp = ClienteporID(cli.id);
            if (ClienteporID(cli.id) != null)
            {
                clitemp.nombre = cli.nombre;
                clitemp.email = cli.email;
                contextoClientes.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarCliente(int id)
        {
            Clientes clitemp = ClienteporID(id);
            if (ClienteporID(id) != null)
            {
                contextoClientes.Clientes.Remove(clitemp);
                contextoClientes.SaveChanges();
                return true;
            }
            return false;
        }
    }
}