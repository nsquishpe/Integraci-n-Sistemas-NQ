using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWRentaPeliculasBD.Datos
{
    public class Datos_Membresia
    {
        //Instancia de la BD Membresia
        RentaPeliculasEntities Contexto;

        //Constructor
        public Datos_Membresia()
        {
            Contexto = new RentaPeliculasEntities();
            //Framework acorde a nuestros cambios IMPORTANTE
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
        //Consulta
        private MEMBRESIA MembresiaporID(string ID)
        {
            return Contexto.MEMBRESIA.Where(mem => mem.MEMID == ID).SingleOrDefault();
        }
        //Metodos
        public List<MEMBRESIA> SeleccionarMembresias()
        {
            return Contexto.MEMBRESIA.ToList();
        }
        public void InsertarMembresia(MEMBRESIA mem)
        {
            Contexto.MEMBRESIA.Add(mem);
            Contexto.SaveChanges();
        }
        public bool ActualizarMembresia(MEMBRESIA mem)
        {
            MEMBRESIA memtemp = MembresiaporID(mem.MEMID);
            if (MembresiaporID(mem.MEMID) != null)
            {
                memtemp.FECHAREGMEM = mem.FECHAREGMEM;
                memtemp.FECHAEXOMEM = mem.FECHAEXOMEM;
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarMembresia(MEMBRESIA mem)
        {
            MEMBRESIA memtemp = MembresiaporID(mem.MEMID);
            if (MembresiaporID(mem.MEMID) != null)
            {
                Contexto.MEMBRESIA.Remove(memtemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
        //PROCEDIMIENTOS ALMACENADOS
        public List<SeleccionarMembresiasSP_Result> SeleccionarMembresiasSP()
        {
            return Contexto.SeleccionarMembresiasSP().ToList();
        }
        public void InsertarMembresiasSP(MEMBRESIA mem)
        {
            Contexto.InsertarMembresiaSP(mem.MEMID, mem.CLIID, mem.FECHAREGMEM, mem.FECHAEXOMEM);
            Contexto.SaveChanges();
        }
        public bool ActualizarMembresiasSP(MEMBRESIA mem)
        {
            if (mem != null)
            {
                //Actualizamos Datos
                Contexto.ActualizarMembresiaSP(mem.MEMID, mem.CLIID, mem.FECHAREGMEM, mem.FECHAEXOMEM);
                Contexto.SaveChanges();//Guarda Cambios
                return true;
            }
            return false;
        }
        public void EliminarMembresiasSP(MEMBRESIA mem)
        {
            Contexto.EliminarClienteSP(mem.MEMID);
        }
    }
}
