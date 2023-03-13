using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num+"! = "+Factorial(num));
            }
        }
        static int Factorial(int num)
        {
            if (num==0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}
