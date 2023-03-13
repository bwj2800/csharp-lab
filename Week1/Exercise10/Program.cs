using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of a Pascal triangle: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[size, size];
            
            for (int i = 0; i <size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        array[i,j] = 1;
                    }
                    else
                    {
                        array[i,j] = array[i - 1,j - 1] + array[i - 1, j];
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j]!=0)
                    {
                        Console.Write(array[i, j] + "\t");
                    }                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
