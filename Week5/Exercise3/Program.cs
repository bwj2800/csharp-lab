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

            Console.Write("Input the number of members on the List : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Member " + i + " : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the value above you want to display the members of the List : ");
            int value = Convert.ToInt32(Console.ReadLine());

            IEnumerable<int> Query =
                from member in array
                where member>value
                select member;

            Console.WriteLine("The numbers greater than "+value+" are : ");
            foreach (int mem in Query)
            {
                Console.WriteLine(mem);
            }

            Console.ReadKey();
        }
    }
}
