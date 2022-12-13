using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntegracionSI_BD_Empresa.Operaciones
{
    public class Empresa
    {
        //Instancia base de datos
        EmpresaEntities empresaContexto;
        //Constructor - base de datos
        public Empresa()
        {
            empresaContexto = new EmpresaEntities();
        }
        //Métodos
        //Selecciona todos las empresas de la base de datos
        public List<Empresas> SeleccionarEmpresa()
        {
            return empresaContexto.Empresas.ToList();
        }
        //Selecciona la empresa por ID de la base de datos
        public Empresas SeleccionarEmpresasporID(int cedula)
        {
            return empresaContexto.Empresas.Where(cli => cli.EmpresaID == cedula).SingleOrDefault();
        }
    }
}