using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3] {{7,1,8},{1,2,6},{4,5,2} };
            twoarray c = new twoarray();
            int y=0;
            int k=5;
            c.print(a);
            c.add(a);
            Console.Read();
        }
    }
}
