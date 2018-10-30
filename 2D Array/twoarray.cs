using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class twoarray
    {
        public int x;
 
        public void print(int[,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j <a.GetLength(1); j++)
                {
                    Console.Write(" " + a[i,j]);
                }
                Console.WriteLine("");
            }
        }

        public void add(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    x = x + a[i, j];
                 }
            }
            Console.WriteLine("sum: " + x);
        }
    }
}
