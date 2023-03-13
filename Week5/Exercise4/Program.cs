using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                5,
                7,
                13,
                24,
                6,
                9,
                8,
                7,
            };

            Console.Write("The members of the list are : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.Write("How many records you want to display ? : ");
            int num = Convert.ToInt32(Console.ReadLine());

            IEnumerable<int> Query =
                (from rec in list
                orderby rec descending
                select rec).Take(num);

            Console.WriteLine("The top "+num+" records from the list are : ");
            foreach (int record in Query)
            {
                Console.WriteLine(record);
            }

            Console.ReadKey();
        }
    }
}
