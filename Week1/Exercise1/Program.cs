using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Price? ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Paid? ");
                int paid = Convert.ToInt32(Console.ReadLine());

                int change = paid - price;
                List<int> changes = new List<int>();

                while (change > 0)
                {
                    if (change >= 100)
                    {
                        change = change - 100;
                        changes.Add(100);
                    }
                    else if (change >= 50)
                    {
                        change = change - 50;
                        changes.Add(50);
                    }
                    else if (change >= 20)
                    {
                        change = change - 20;
                        changes.Add(20);
                    }
                    else if (change >= 10)
                    {
                        change = change - 10;
                        changes.Add(10);
                    }
                    else if (change >= 5)
                    {
                        change = change - 5;
                        changes.Add(5);
                    }
                    else if (change >= 2)
                    {
                        change = change - 2;
                        changes.Add(2);
                    }
                    else if (change >= 1)
                    {
                        change = change - 1;
                        changes.Add(1);
                    }
                }

                Console.Write("Your change is " + (paid - price) + ": ");
                for (int i = 0; i < changes.Count; i++)
                {
                    Console.Write(changes[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}