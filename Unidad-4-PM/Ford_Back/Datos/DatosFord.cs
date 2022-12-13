using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class DatosFord
    {
        FordEntities1 context;
        public DatosFord()
        {
            context = new FordEntities1();
            context.Configuration.ProxyCreationEnabled = false;
        }

        #region metodos consulta
        public List<Auto_FORD> SeleccionarAutosChev()
        {
            return context.Auto_FORD.ToList();
        }
        #endregion

        #region metodos accion
        public void InsertarAutoChev(Auto_FORD chev)
        {
            context.Auto_FORD.Add(chev);
            context.SaveChanges();
        }
        public bool EliminarPelicula(int id)
        {
            Auto_FORD chev_temp = ChevporID(id);
            if (ChevporID(id) != null)
            {
                context.Auto_FORD.Remove(chev_temp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool ActualizarAutoChev(Auto_FORD chev)
        {
            Auto_FORD chev_temp = ChevporID(chev.id);
            if (ChevporID(chev.id) != null)
            {
                chev_temp.Marca_Ford = chev.Marca_Ford;
                chev_temp.Modelo_Ford = chev.Modelo_Ford;
                chev_temp.Cilindraje_Ford = chev.Cilindraje_Ford;
                chev_temp.Anio_Ford = chev.Anio_Ford;
                chev_temp.Color_Ford = chev.Color_Ford;
                chev_temp.Tipo_Ford = chev.Tipo_Ford;
                chev_temp.Con_Ford = chev.Con_Ford;
                chev_temp.Fecha_Ford = chev.Fecha_Ford;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Auto_FORD ChevporID(int ID)
        {
            return context.Auto_FORD.Where(chev => chev.id == ID).SingleOrDefault();
        }
        #endregion

    }
}
