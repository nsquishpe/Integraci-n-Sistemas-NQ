using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo001Rest.Logica_Cliente
{
    public class LogicaCli
    {
        Datos_Cliente.DatosCli op = new Datos_Cliente.DatosCli();
        public List<Clientes> SeleccionarClientes()
        {
            return op.SeleccionarClientes();
        }
        public Clientes SeleccionarClientesPorID(int id)
        {
            return op.SeleccionarClientesPorID(id);
        }
        public int InsertarCliente(Clientes cli)
        {
            return op.InsertarCliente(cli);
        }
        public bool ActualizarCliente(Clientes cli)
        {
            return op.ActualizarCliente(cli);
        }
        public bool EliminarCliente(int id)
        {
            return op.EliminarCliente(id);
        }
    }
}