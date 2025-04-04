using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JacobyEntity
    {
        public double[,] Data { get; set; }
        public int Size => Data.GetLength(0);

        public JacobyEntity(int size)
        {
            Data = new double[size, size];
        }

        public JacobyEntity(double[,] data)
        {
            Data = data;
        }
    }
}
