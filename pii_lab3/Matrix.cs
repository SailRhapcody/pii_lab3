using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pii_lab3
{
    class Matrix
    {
        private int [,] product;
        public void start(int[,] a, int [,] b)
        {
            product = new int[2, 2];
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    for (int inner = 0; inner < 2; inner++)
                    {
                        product[row,col] += a[row,inner] * b[inner,col];
                    }
                }
            }
            show(a);
            show(b);
            show(product);

        }

        private void show(int [,] arr)
        {
            for(int i = 0;i< 2; i++)
            {
                Console.WriteLine();
                for(int j = 0;j < 2; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
