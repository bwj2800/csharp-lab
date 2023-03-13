using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomObj = new Random();
            int randomValue = randomObj.Next(6)+1;
            Console.WriteLine(randomValue);
            Console.WriteLine("Guess the number from 1 to 6!");
            Guess(randomValue);
            Console.WriteLine("Correct!");
            Console.ReadKey();
        }

        static void Guess(int num)
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input==num)
                {
                    break;
                }
                Console.WriteLine("Wrong!");
            }
        }
    }
}
