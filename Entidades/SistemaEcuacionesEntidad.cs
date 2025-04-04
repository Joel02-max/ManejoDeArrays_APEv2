using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaEcuacionesEntidad
    {
        public double[,] Matriz { get; set; }
        public int NumeroEcuaciones { get; set; }

        public SistemaEcuacionesEntidad(int n)
        {
            NumeroEcuaciones = n;
            Matriz = new double[n, n + 1]; // Incluye los términos independientes
        }
    }
}
