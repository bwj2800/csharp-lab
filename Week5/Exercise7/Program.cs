using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>()
            {
                'm',
                'n',
                'o',
                'p',
                'q',
            };

            Console.WriteLine("Here is the list of items : ");
            foreach (char c in list)
            {
                Console.WriteLine("Char: " + c);
            }

            list.RemoveRange(1, 3);

            Console.WriteLine("Here is the list after removing the three items starting from the item index 1 from the list : ");

            foreach (char c in list)
            {
                Console.WriteLine("Char: " + c);
            }

            Console.ReadKey();

        }
    }
}
