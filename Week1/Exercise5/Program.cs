using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = GetInt("Enter your age", 0, 150);
            Console.ReadKey();
        }

        static int GetInt(string msg, int range_start, int range_end)
        {
            int value=0;
            bool valid = false;
            while (!valid)
            {
                Console.Write(msg + ": ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input>range_end)
                {
                    Console.WriteLine("Not a valid answer. Must be no more than "+range_end+".");
                }
                else if (input < range_start)
                {
                    Console.WriteLine("Not a valid answer. Must be no less than " + range_start + ".");
                }
                else
                {
                    value = input;
                    valid=true;
                }
            }
            return value;
        }
    }
}
