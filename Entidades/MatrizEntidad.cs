using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MatrizEntidad
    {
        public int N { get; set; }
        public int[,] Valores { get; set; }
        public MatrizEntidad()
        {
            
        }

        public MatrizEntidad(int n)
        {
            N = n;
            Valores = new int[n,n];
        }
    }
}
