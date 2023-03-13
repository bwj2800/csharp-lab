using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise6
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

            list.Remove('o');

            Console.WriteLine("Here is the list after removing the item 'o' from the list : ");

            foreach (char c in list)
            {
                Console.WriteLine("Char: " + c);
            }

            Console.ReadKey();

        }
    }
}
