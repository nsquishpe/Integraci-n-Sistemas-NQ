using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMembresias.Logica_Membresia
{
    public class LogicaMem
    {
        //Instancia de datos
        Data_Membresia.DatosMem crud_mem = new Data_Membresia.DatosMem();
        //Metodo - almacena en lista todos las membresias
        public List<MEMBRESIA> SeleccionarMembresia()
        {
            return crud_mem.SeleccionarMembresias();
        }
        //Metodo - almacena membresias por cedula
        public MEMBRESIA SeleccionarMembresiaPorID(string ID)
        {
            if (ID == null)
            {
                return null;
            }
            else
            {
                return SeleccionarMembresia().SingleOrDefault(mem => mem.MEMID == ID);
            }
        }
        //CRUD
        public void InsertarMembresia(MEMBRESIA mem)
        {
            crud_mem.InsertarMembresia(mem);
        }
        public bool ActualizarMembresia(MEMBRESIA mem)
        {
            return crud_mem.ActualizarMembresia(mem);
        }
        public bool EliminarMembresia(string ID)
        {
            return crud_mem.EliminarMembresia(ID);
        }
    }
}