using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace LogicaNegocio
{
    public class SistemaEcuacionesNegocio
    {
        public void EliminacionGauss(SistemaEcuacionesEntidad sistema)
        {
            int n = sistema.NumeroEcuaciones;
            double[,] matriz = sistema.Matriz;

            for (int i = 0; i < n; i++)
            {
                // Paso 1: Pivoteo
                if (matriz[i, i] == 0)
                {
                    bool intercambiado = false;
                    for (int k = i + 1; k < n; k++)
                    {
                        if (matriz[k, i] != 0)
                        {
                            IntercambiarFilas(matriz, i, k);
                            intercambiado = true;
                            break;
                        }
                    }
                    if (!intercambiado)
                    {
                        throw new InvalidOperationException("El sistema no tiene solución única.");
                    }
                }

                // Paso 2: Escalonar la matriz
                for (int j = i + 1; j < n; j++)
                {
                    double factor = matriz[j, i] / matriz[i, i];
                    for (int k = 0; k <= n; k++)
                    {
                        matriz[j, k] -= factor * matriz[i, k];
                    }
                }
            }
        }

        public double[] ResolverSistema(SistemaEcuacionesEntidad sistema)
        {
            int n = sistema.NumeroEcuaciones;
            double[,] matriz = sistema.Matriz;
            double[] soluciones = new double[n];

            for (int i = n - 1; i >= 0; i--)
            {
                double suma = 0;
                for (int j = i + 1; j < n; j++)
                {
                    suma += matriz[i, j] * soluciones[j];
                }
                if (matriz[i, i] == 0)
                {
                    throw new InvalidOperationException("El sistema no tiene solución única.");
                }
                soluciones[i] = (matriz[i, n] - suma) / matriz[i, i];
            }
            return soluciones;
        }

        private void IntercambiarFilas(double[,] matriz, int fila1, int fila2)
        {
            int columnas = matriz.GetLength(1);
            for (int i = 0; i < columnas; i++)
            {
                double temp = matriz[fila1, i];
                matriz[fila1, i] = matriz[fila2, i];
                matriz[fila2, i] = temp;
            }
        }
    }
}
