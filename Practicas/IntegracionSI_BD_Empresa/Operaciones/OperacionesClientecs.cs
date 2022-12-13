using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracionSI_BD_Empresa.Operaciones
{
    public class OperacionesClientecs
    {
        //Instancia base de datos Cliente externa
        SWcliente.SWclientes cliente = new SWcliente.SWclientes();
        //Métodos
        //Selecciona todos los clientes de la base de datos
        public List<SWcliente.Clientes> SeleccionarClientes()
        {
            return cliente.SeleccionarClientes().ToList();
        }
        //Selecciona el cliente por cédula de la base de datos
        public SWcliente.Clientes SeleccionarClientesPorCedula(int cedula)
        {
            return cliente.SeleccionarClientesPorCedula(cedula);
        }

    }
}