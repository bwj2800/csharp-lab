using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>()
            {
                "ROME",
                "LONDON",
                "NAIROBI",
                "CALIFORNIA",
                "ZURICH",
                "NEW DELHI",
                "AMSTERDAM",
                "ABU DHABI",
                "PARIS",
            };

            Console.Write("Input starting character for the string : ");
            string starting = Console.ReadLine();
            Console.Write("Input ending character for the string : ");
            string ending = Console.ReadLine();
            IEnumerable<string> citiesQuery =
                from c in cities
                where c.Substring(0, 1).Equals(starting) & c.Substring(c.Length-1,1).Equals(ending)
                select c;

            Console.Write("The city starting with A and ending with M is : ");
            foreach (string city in citiesQuery)
            {
                Console.WriteLine(city);
            }

            Console.ReadKey();
        }
    }
}
