using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MatrixEntity
    {
        public double[,] Data { get; set; }

        public int Rows => Data.GetLength(0);
        public int Columns => Data.GetLength(1);

        public MatrixEntity(int rows, int columns)
        {
            Data = new double[rows, columns];
        }

        public MatrixEntity(double[,] data)
        {
            Data = data;
        }
    }
}
