using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Operaciones
{
    public class Coperaciones
    {
        public decimal suma (decimal n1, decimal n2){
            return n1 + n2;
        }
        public decimal resta(decimal n1, decimal n2)
        {
            return n1 - n2;
        }
        public decimal multiplicacion(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
        public decimal division(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
    }
}