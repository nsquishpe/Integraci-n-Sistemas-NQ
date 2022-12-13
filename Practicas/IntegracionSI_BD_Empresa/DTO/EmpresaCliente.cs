using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracionSI_BD_Empresa.DTO
{
    public class EmpresaCliente
    {
        //Empresa
        public int EmpresaID { get; set; }
        public string RazonSocial { get; set; }
        public int Ruc { get; set; }

        //Cliente
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

    }
}