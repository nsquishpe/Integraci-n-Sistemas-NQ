using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class LogicaFord
    {
        FordEntities1 context;
        Datos.DatosFord op = new Datos.DatosFord();
        public LogicaFord()
        {
            context = new FordEntities1();
        }

        #region metodos consulta
        public List<Auto_FORD> SeleccionarAutosChev()
        {
            return op.SeleccionarAutosChev();
        }
        #endregion

        #region metodos accion
        public void InsertarAutoChev(Auto_FORD chev)
        {
            op.InsertarAutoChev(chev);
        }
        public bool EliminarPelicula(int id)
        {
            return op.EliminarPelicula(id);
        }
        public bool ActualizarAutoChev(Auto_FORD chev)
        {
            return op.ActualizarAutoChev(chev);
        }
        public Auto_FORD ChevporID(int ID)
        {
            return op.ChevporID(ID);
        }
        #endregion
    }
}
