using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Fibonacci Sequence: ");
            int lim = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<lim;i++)
            {
                Console.Write(Fibonacci(i)+" ");
            }
            Console.WriteLine();
            //Console.WriteLine(Fibonacci(lim));
            Console.ReadKey();
        }

        static int Fibonacci(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num ==1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(num-1)+ Fibonacci(num-2);
            }
        }
    }
}
