using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of data points:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("[" + i + "]:");
                array[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Statistical Information:");
            Console.WriteLine(".......................................");
            
            Console.Write("Arithmetic mean:");
            Console.WriteLine(array.Average());

            Console.Write("Median:");
            Array.Sort(array);
            double median = (len % 2 != 0) ? (double)array[len / 2] : ((double)array[len / 2] + (double)array[len / 2 - 1]) / 2;
            Console.WriteLine(median);

            Console.Write("Mode:");
            int high = array.OrderByDescending(n => n).First();
            int mode = array.GroupBy(i => i)  //Grouping same items
                .OrderByDescending(g => g.Count()) //now getting frequency of a value
                .Select(g => g.Key) //selecting key of the group
                .FirstOrDefault();
            Console.WriteLine(mode);


            Console.Write("Standard deviation:");
            double sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += Math.Pow((array[i] - array.Average()), 2.0);
            }
            double standardDeviation = Math.Sqrt(sum / (len-1));
            Console.WriteLine(Math.Round(standardDeviation, 5));
            Console.ReadKey();
        }
    }
}
