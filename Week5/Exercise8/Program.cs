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
            List<char> List1 = new List<char>()
            {
                'X',
                'Y',
                'Z',
            };
            List<int> List2 = new List<int>()
            {
                1,
                2,
                3,
                4,
            };
            

            var cartesianProduct = 
                from letterList in List1
                from numberList in List2
                select new { letterList, numberList };

            Console.WriteLine("The Cartesian Product are : ");
            foreach (var ProductList in cartesianProduct)
            {
                Console.WriteLine(ProductList);
            }
            Console.ReadKey();
        }
    }
}
