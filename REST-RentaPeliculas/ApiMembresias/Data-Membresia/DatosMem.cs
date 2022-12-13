using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMembresias.Data_Membresia
{
    public class DatosMem
    {
        //Instancia de la BD Membresia
        RentaPeliculasEntities Contexto;

        //Constructor
        public DatosMem()
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
        public bool EliminarMembresia(string ID)
        {
            MEMBRESIA memtemp = MembresiaporID(ID);
            if (MembresiaporID(ID) != null)
            {
                Contexto.MEMBRESIA.Remove(memtemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}