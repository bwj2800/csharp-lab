using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Student
    {
        public Student(int id,string n, int g)
        {
            this.ID = id;
            this.Name = n; 
            this.Grade = g; 
        }
        public int ID { get; set; }
        public string Name { get; set; } 
        public int Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "John", 500),
                new Student(2, "Mike", 700),
                new Student(3, "Jack", 900),
                new Student(4, "Sally", 800),
                new Student(5, "David", 750),
                new Student(6, "Jenny", 750),
            };
            Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find : ");
            int input = Convert.ToInt32(Console.ReadLine());

            IEnumerable<Student> Query =
                from student in students
                where student.Grade == 
                    (from s in students
                     orderby s.Grade descending
                     select s.Grade).ElementAt(2)
                select student;

            foreach (Student s in Query)
            {
                Console.WriteLine("Id: "+s.ID+", Name: "+s.Name+", achieved Grade Point: "+s.Grade);
            }

            Console.ReadKey();
        }
    }
}
