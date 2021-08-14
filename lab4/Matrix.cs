using System;

namespace lab4
{
    public class Matrix
    {
        /// <summary>
        /// field for source matrix, result of operation №1  and №3
        /// </summary>
        public int[,] mas, res1, res3;
        /// <summary>
        /// filed for matrix range, matrix size, result of operation №2
        /// </summary>
        public int a, b, n, res2;
        /// <summary>
        /// constructor with parameters for the range and size of the matrix
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Matrix(int n, int a, int b)
        {
            this.n = n;
            this.a = a;
            this.b = b;
        }
    }
}
