using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array= new int[5,5] { {1,2,3,4,5},{6,7,8,9,10 },{11,12,13,14,15 },{ 16,17,18,19,20},{21,22,23,24,25 } };
            for (int i=0;i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
