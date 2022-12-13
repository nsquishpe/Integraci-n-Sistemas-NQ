using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_Chev
    {
        ChevroletEntities context;
        public Datos_Chev()
        {
            context = new ChevroletEntities();
            context.Configuration.ProxyCreationEnabled = false;
        }

        #region metodos consulta
        public List<Auto_CHEV> SeleccionarAutosChev()
        {
            return context.Auto_CHEV.ToList();
        }
        #endregion

        #region metodos accion
        public void InsertarAutoChev(Auto_CHEV chev)
        {
            context.Auto_CHEV.Add(chev);
            context.SaveChanges();
        }
        public bool EliminarPelicula(Auto_CHEV chev)
        {
            Auto_CHEV chev_temp = ChevporID(chev.id);
            if (ChevporID(chev.id) != null)
            {
                context.Auto_CHEV.Remove(chev_temp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool ActualizarAutoChev(Auto_CHEV chev)
        {
            Auto_CHEV chev_temp = ChevporID(chev.id);
            if (ChevporID(chev.id) != null)
            {
                chev_temp.Marca_Chevrolet = chev.Marca_Chevrolet;
                chev_temp.Modelo_Chevrolet = chev.Modelo_Chevrolet;
                chev_temp.Cilindraje_Chevrolet = chev.Cilindraje_Chevrolet;
                chev_temp.Anio_Chevrolet = chev.Anio_Chevrolet;
                chev_temp.Color_Chevrolet = chev.Color_Chevrolet;
                chev_temp.Tipo_Chevrolet = chev.Tipo_Chevrolet;
                chev_temp.Con_Chevrolet = chev.Con_Chevrolet;
                chev_temp.Fecha_Chevrolet = chev.Fecha_Chevrolet;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Auto_CHEV ChevporID(int ID)
        {
            return context.Auto_CHEV.Where(chev => chev.id == ID).SingleOrDefault();
        }
        #endregion

    }
}
