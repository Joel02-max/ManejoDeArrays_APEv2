using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class QrDecomposition
    {
        public MatrixEntity A { get; private set; }
        public MatrixEntity Q { get; private set; }
        public MatrixEntity R { get; private set; }

        public QrDecomposition(MatrixEntity matrizA)
        {
            A = matrizA;
            Descomponer();
        }

        private void Descomponer()
        {
            int m = A.Rows;
            int n = A.Columns;
            double[,] qMatrix = new double[m, n];
            double[,] rMatrix = new double[n, n];

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    qMatrix[i, j] = A.Data[i, j];
                }

                for (int k = 0; k < j; k++)
                {
                    double dotProduct = 0;
                    for (int i = 0; i < m; i++)
                    {
                        dotProduct += qMatrix[i, k] * A.Data[i, j];
                    }

                    rMatrix[k, j] = dotProduct;
                    for (int i = 0; i < m; i++)
                    {
                        qMatrix[i, j] -= dotProduct * qMatrix[i, k];
                    }
                }

                double norm = 0;
                for (int i = 0; i < m; i++)
                {
                    norm += qMatrix[i, j] * qMatrix[i, j];
                }
                norm = Math.Sqrt(norm);

                if (norm < 1e-10)
                    throw new ArgumentException("La matriz contiene columnas linealmente dependientes.");

                rMatrix[j, j] = norm;
                for (int i = 0; i < m; i++)
                {
                    qMatrix[i, j] /= norm;
                }
            }

            Q = new MatrixEntity(qMatrix);
            R = new MatrixEntity(rMatrix);
        }
    }
}
