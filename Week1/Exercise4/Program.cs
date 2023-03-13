using System;
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
            while (true)
            {
                Console.Write("Enter the x-coordinate of a center of a circle: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the y-coordinate of a center of a circle: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the radius of a circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the x-coordinate of a point you want to check: ");
                double point_x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the y-coordinate of a point you want to check: ");
                double point_y = Convert.ToDouble(Console.ReadLine());

                double dist = (x - point_x) * (x - point_x) + (y - point_y) * (y - point_y);

                if (dist < radius * radius)
                {
                    Console.WriteLine("The point is inside the circle.");
                }
                else if (dist == radius * radius)
                {
                    Console.WriteLine("The point is on the circle.");
                }
                else
                {
                    Console.WriteLine("The point is outside the circle.");
                }
            }
        }
    }
}
