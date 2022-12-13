using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiClientes.Logica_Cliente
{
    public class LogicaCli
    {
        //Instancia de datos
        Data_Cliente.DatosCli crud_cli = new Data_Cliente.DatosCli();
        //Metodo - almacena en lista todos los clientes
        public List<CLIENTE> SeleccionarCliente()
        {
            return crud_cli.SeleccionarClientes();
        }
        //Metodo - almacena cliente por cedula
        public CLIENTE SeleccionarClientePorID(string ID)
        {
            if (ID == null)
            {
                return null;
            }
            else
            {
                return SeleccionarCliente().SingleOrDefault(cli => cli.CLIID == ID);
            }
        }
        //CRUD
        public void InsertarCliente(CLIENTE cli)
        {
            crud_cli.InsertarCliente(cli);
        }
        public bool ActualizarCliente(CLIENTE cli)
        {
            return crud_cli.ActualizarCliente(cli);
        }
        public bool EliminarCliente(string id)
        {
            return crud_cli.EliminarCliente(id);
        }
    }
}