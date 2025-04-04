using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class JacobiSolver
    {
        public JacobyEntity A { get; private set; }
        public double[] Eigenvalues { get; private set; }

        public JacobiSolver(JacobyEntity matrizA)
        {
            A = matrizA;
            Eigenvalues = CalcularAutovalores(1e-10, 100);
        }

        private double[] CalcularAutovalores(double tolerancia, int maxIteraciones)
        {
            int n = A.Size;
            double[,] matriz = (double[,])A.Data.Clone();
            double[] autovalores = new double[n];

            for (int iteracion = 0; iteracion < maxIteraciones; iteracion++)
            {
                // Encontrar el mayor elemento fuera de la diagonal
                int p = 0, q = 1;
                double maxValor = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (Math.Abs(matriz[i, j]) > Math.Abs(maxValor))
                        {
                            maxValor = matriz[i, j];
                            p = i;
                            q = j;
                        }
                    }
                }

                // Verificar si la matriz ya es diagonal
                if (Math.Abs(maxValor) < tolerancia)
                {
                    for (int i = 0; i < n; i++)
                        autovalores[i] = matriz[i, i];
                    return autovalores;
                }

                // Calcular el ángulo de rotación de Jacobi
                double theta = 0.5 * Math.Atan2(2 * matriz[p, q], matriz[p, p] - matriz[q, q]);
                double cos = Math.Cos(theta);
                double sin = Math.Sin(theta);

                // Aplicar la rotación de Jacobi
                double[,] nuevaMatriz = (double[,])matriz.Clone();
                for (int i = 0; i < n; i++)
                {
                    if (i != p && i != q)
                    {
                        nuevaMatriz[i, p] = cos * matriz[i, p] - sin * matriz[i, q];
                        nuevaMatriz[p, i] = nuevaMatriz[i, p];

                        nuevaMatriz[i, q] = sin * matriz[i, p] + cos * matriz[i, q];
                        nuevaMatriz[q, i] = nuevaMatriz[i, q];
                    }
                }

                nuevaMatriz[p, p] = cos * cos * matriz[p, p] - 2 * sin * cos * matriz[p, q] + sin * sin * matriz[q, q];
                nuevaMatriz[q, q] = sin * sin * matriz[p, p] + 2 * sin * cos * matriz[p, q] + cos * cos * matriz[q, q];
                nuevaMatriz[p, q] = nuevaMatriz[q, p] = 0;

                matriz = nuevaMatriz;
            }

            throw new Exception("El método de Jacobi no convergió.");
        }
    }
}
