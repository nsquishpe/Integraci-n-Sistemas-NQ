using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracionSI_BD_Empresa.Midlware
{
    public class midlwareClase
    {
        public List<DTO.EmpresaCliente> SeleccionarEmpresaCliente()
        {
            //Instancia del servicio Web Cliente externo (Operaciones)
            SWcliente.SWclientes SWclientesOperaciones = new SWcliente.SWclientes();
            //Lista temporal de objetos Empresa
            List<Empresas> ListTemporalEmpresa = new List<Empresas>();
            //Instancia operaciones Empresa
            Operaciones.Empresa opempresa = new Operaciones.Empresa();
            //Almacena en la lista todas las empresas
            ListTemporalEmpresa = opempresa.SeleccionarEmpresa();
            //Instancia base de datos Cliente externo
            SWcliente.Clientes TemporalCliente = new SWcliente.Clientes();

            //Lista temporal EmpresaCliente DTO
            List<DTO.EmpresaCliente> ltsEmpresaCliente = new List<DTO.EmpresaCliente>();

            //Itero lista de empresas
            foreach (var item in ListTemporalEmpresa)
            {
                //Instancia de EmpresaCliente DTO
                DTO.EmpresaCliente temp = new DTO.EmpresaCliente();
                //Atributos de la empresa
                temp.Ruc = item.Ruc;
                temp.RazonSocial = item.RazonSocial;
                temp.EmpresaID =   item.EmpresaID;
                temp.Cedula = item.EmpresaID;

                //Validación objeto no nulo ID empresa de acuerdo a la CI del Cliente
                if(SWclientesOperaciones.SeleccionarClientesPorCedula(item.EmpresaID) != null)
                {
                    //Busqueda cliente CI por ID empresa
                    TemporalCliente = SWclientesOperaciones.SeleccionarClientesPorCedula(item.EmpresaID);
                    //Cliente con CI igual a ID Empresa
                    if (item.EmpresaID == TemporalCliente.Cedula)
                    {
                        temp.Nombre = TemporalCliente.Nombre;
                    }
                    //Añade ClienteEmpresa a la lista
                    ltsEmpresaCliente.Add(temp);
                }
            }

            //Retorna Lista temporal EmpresaCliente DTO
            return ltsEmpresaCliente;
        }
    }
}