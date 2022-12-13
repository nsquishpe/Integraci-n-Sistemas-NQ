using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class Logica_Chev
    {
        ChevroletEntities context;
        Datos.Datos_Chev op = new Datos.Datos_Chev();
        public Logica_Chev()
        {
            context = new ChevroletEntities();
        }

        //Operaciones 

        #region metodos consulta
        public List<Auto_CHEV> SeleccionarAutosChev()
        {
            return op.SeleccionarAutosChev() ;
        }
        #endregion

        #region metodos accion
        public void InsertarAutoChev(Auto_CHEV chev)
        {
            op.InsertarAutoChev(chev);
        }
        public bool EliminarPelicula(Auto_CHEV chev)
        {
            return op.EliminarPelicula(chev);
        }
        public bool ActualizarAutoChev(Auto_CHEV chev)
        {
            return op.ActualizarAutoChev(chev);
        }
        public Auto_CHEV ChevporID(int ID)
        {
            return op.ChevporID(ID);
        }
        #endregion

    }
}
