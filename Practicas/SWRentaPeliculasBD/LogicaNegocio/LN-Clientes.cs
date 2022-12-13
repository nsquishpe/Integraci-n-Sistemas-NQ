using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD.LogicaNegocio
{
    public class LN_Clientes
    {
        //Instancia de datos
        Datos.Datos_Cliente crud_cli = new Datos.Datos_Cliente();
        //Metodo - almacena en lista todos los clientes
        public List<CLIENTE> SeleccionarCliente()
        {
            return crud_cli.SeleccionarClientes();
        }
        //Metodo - almacena cliente por cedula
        public CLIENTE SeleccionarClientePorID(string ID)
        {
            if(ID == null)
            {
                return null;
            }
            else
            {
                return SeleccionarCliente().SingleOrDefault(cli => cli.CLIID == ID);
            }
        }
        public List<CLIENTE> SeleccionarClientePorNombre(string nombre)
        {
            if (nombre == null)
            {
                return null;
            }
            else
            {
                return crud_cli.ClienteporNombre(nombre);
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
        public bool EliminarCliente(CLIENTE cli)
        {
            return crud_cli.EliminarCliente(cli);
        }
        public List<CLIENTE> SeleccionarClientesDef(string ID = "Buscar")
        {
            CLIENTE clitemp =   new CLIENTE();
            clitemp= SeleccionarClientePorID(ID);
            List<CLIENTE> clientes = new List<CLIENTE>();
            if(ID == "Buscar")
            {
                return SeleccionarCliente().ToList();
            }
            else
            {
                clientes.Add(clitemp);
                return clientes;
            }
        }
        //PROCEDIMIENTOS ALMACENADOS
        public List<SeleccionarClientes_Result> SeleccionarClientesSP()
        {
            return crud_cli.SeleccionarClientesSP().ToList();
        }
        public void InsertarClientesSP(CLIENTE cli)
        {
            crud_cli.InsertarClientesSP(cli);
        }
        public bool ActualizarClientesSP(CLIENTE cli)
        {
            return crud_cli.ActualizarClientesSP(cli);
        }
        public void EliminarClientesSP(CLIENTE cli)
        {
            crud_cli.EliminarClientesSP(cli);
        }

        //METODO PRUEBA

        public List<CLIENTE> SeleccionarClientesPorNombreDef(string nombre = "Buscar")
        {
            List<CLIENTE> clitemp = new List<CLIENTE>();
            clitemp = SeleccionarClientePorNombre(nombre);
            if (nombre == "Buscar")
            {
                return SeleccionarCliente().ToList();
            }
            else
            {
                return clitemp;
            }
        }
    } 
}