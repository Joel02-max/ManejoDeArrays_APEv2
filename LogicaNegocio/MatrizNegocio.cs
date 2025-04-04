using Entidades;
using System;
using System.Threading.Tasks; // Necesario para el paralelismo

namespace LogicaNegocio
{
    public class MatrizNegocio
    {
        public Random rand = new Random();

        public MatrizEntidad GenerarMatriz(int n)
        {
            //Random rand = new Random();
            var matriz = new MatrizEntidad(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz.Valores[i, j] = rand.Next(1, 10);
                }
            }
            return matriz;
        }

        public MatrizEntidad MultiplicarMatrices(MatrizEntidad a, MatrizEntidad b)
        {
            int n = a.N;
            MatrizEntidad resultado = new MatrizEntidad(n);

            Parallel.For(0, n, i =>
            {
                Parallel.For(0, n, j =>
                {
                    int suma = 0;
                    for (int k = 0; k < n; k++)
                    {
                        suma += a.Valores[i, k] * b.Valores[k, j];
                    }
                    resultado.Valores[i, j] = suma;
                });
            });

            return resultado;
        }
    }
}
