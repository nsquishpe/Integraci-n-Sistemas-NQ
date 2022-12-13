using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracionSI_BD.Operaciones
{
    public class SWOperacionesCliente
    {
        //Instancia base de datos
        ClienteEntities clientesContexto;
        //Constructor - base de datos
        public SWOperacionesCliente()
        {
            clientesContexto = new ClienteEntities();
        }
        //Métodos
        //Selecciona todos los clientes de la base de datos
        public List<Clientes> SeleccionarClientes()
        {
           return clientesContexto.Clientes.ToList();
        }
        //Selecciona clientes por cédula de la base de datos
        public Clientes SeleccionarClientesPorCedula(int cedula)
        {
            return clientesContexto.Clientes.Where(cli => cli.Cedula == cedula).SingleOrDefault(); 
        }
    }
}