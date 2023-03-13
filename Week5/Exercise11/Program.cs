using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>()
            {
                "ROME",
                "ZURICH",
                "LONDON",
                "NAIROBI",
                "PARIS",
            };

            List<string> sorted = cities.OrderBy(x => x.Length)
                                    .ThenBy(x => x)
                                    .ToList();

            Console.WriteLine("Here is the arranged list : ");
            foreach (string city in sorted)
            {
                Console.WriteLine(city);
            }

            Console.ReadKey();
        }
    }
}
