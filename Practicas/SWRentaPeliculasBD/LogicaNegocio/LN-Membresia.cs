using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD.LogicaNegocio
{
    public class LN_Membresia
    {
        //Instancia de datos
        Datos.Datos_Membresia crud_mem= new Datos.Datos_Membresia();
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
        public bool EliminarMembresia(MEMBRESIA mem)
        {
            return crud_mem.EliminarMembresia(mem);
        }
        public List<MEMBRESIA> SeleccionarMembresiaDef(string ID = "Buscar")
        {
            MEMBRESIA memtemp = new MEMBRESIA();
            memtemp = SeleccionarMembresiaPorID(ID);
            List<MEMBRESIA> membresias = new List<MEMBRESIA>();
            if (ID == "Buscar")
            {
                return SeleccionarMembresia().ToList();
            }
            else
            {
                membresias.Add(memtemp);
                return membresias;
            }
        }
        //PROCEDIMIENTOS ALMACENADOS
        public List<SeleccionarMembresiasSP_Result> SeleccionarMembresiasSP()
        {
            return crud_mem.SeleccionarMembresiasSP();
        }
        public void InsertarMembresiasSP(MEMBRESIA mem)
        {
            crud_mem.EliminarMembresiasSP(mem);
        }
        public bool ActualizarMembresiasSP(MEMBRESIA mem)
        {
            return crud_mem.ActualizarMembresiasSP(mem);
        }
        public void EliminarMembresiasSP(MEMBRESIA mem)
        {
            crud_mem.EliminarMembresiasSP(mem);
        }
    }
}