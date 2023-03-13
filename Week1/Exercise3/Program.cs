using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the type of conversion (I/G/M/P): ");
                string type = Console.ReadLine();
                switch (type)
                {
                    case "I":
                        Console.Write("Enter inches: ");
                        double inches = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("-> "+ inches*2.54 +" centimeters");
                        break;
                    case "G":
                        Console.Write("Enter gallons: ");
                        double gallons = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("-> " + gallons*3.78541 + " liters");
                        break;
                    case "M":
                        Console.Write("Enter mile: ");
                        double mile = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("-> " + mile*1.60934 + " kilometer");
                        break;
                    case "P":
                        Console.Write("Enter pound: ");
                        double pound = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("-> " + pound*0.453592 + " kilogram");
                        break;
                    default:
                        Console.WriteLine("Please enter the correct type of conversion.");
                        break;
                }

            }
        }
    }
}
