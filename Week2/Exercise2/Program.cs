using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Person
    {
        private string first_name;
        private string last_name;
        private string birth;
        public Person()
        {
            first_name = "";
            last_name = "";
            birth = "";
        }
        public Person(string f, string l, string b)
        {
            first_name = f;
            last_name = l;
            birth = b;
        }
        public Person(Person p)
        {
            first_name = p.First_name;
            last_name = p.Last_name;
            birth = p.Birth;
        }
        public string First_name
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }
        public string Last_name
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }
        public string Birth
        {
            get
            {
                return birth;
            }
            set
            {
                birth = value;
            }
        }
        public void Display()
        {
            Console.WriteLine( "My name is " + first_name + " " + last_name+".\n" +
                "My date of birth is "+birth+".");
        }
    }

    class Employee : Person
    {
        private double salary;
        public Employee() : base()
        {
            salary = 0;
        }
        public Employee(string f, string l, string b, double s) : base(f,l,b)
        {
            salary = s;
        }
        public Employee(Employee e)
        {
            First_name = e.First_name;
            Last_name = e.Last_name;
            Birth = e.Birth;
            salary = e.Salary;
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("My salary is " + salary + ".");
        }
    }

    class Manager : Employee
    {
        private string department;
        public Manager() : base()
        {
            department = "";
        }
        public Manager(string f, string l, string b, double s, string d ) : base(f, l, b, s)
        {
            department = d;
        }
        public Manager(Manager m)
        {
            First_name = m.First_name;
            Last_name = m.Last_name;
            Birth = m.Birth;
            Salary = m.Salary;
            department = m.Department;
        }
        public string Department
            {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("My department is "+department+".");
        }
    }

    class Director : Manager
    {
        private string company;
        public Director() : base()
        {
            company = "";
        }
        public Director(string f, string l, string b, double s, string d, string c) : base(f, l, b, s, d)
        {
            company = c;
        }
        public Director(Director d)
        {
            First_name = d.First_name;
            Last_name = d.Last_name;
            Birth = d.Birth;
            Salary = d.Salary;
            Department = d.Department;
            company = d.Company;
        }
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("My company is " + company + ".");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("employee", "1", "2001/01/01", 2000);
            Employee e2 = new Employee("employee", "2", "2001/01/02", 2500);
            Employee e3 = new Employee("employee", "3", "2001/01/03", 3000);
            Employee e4 = new Employee("employee", "4", "2001/01/04", 3500);
            Employee e5 = new Employee("employee", "5", "2001/01/05", 4000);

            Manager m1 = new Manager("manager", "1", "2001/02/01", 4500, "d1");
            Manager m2 = new Manager("manager", "2", "2001/02/02", 5000, "d2");

            Director d1 = new Director("director", "1", "2001/03/01", 5500, "d1", "c1");

            e1.Display();
            Console.WriteLine();
            e2.Display();
            Console.WriteLine();
            e3.Display();
            Console.WriteLine();
            e4.Display();
            Console.WriteLine();
            e5.Display();
            Console.WriteLine();
            m1.Display();
            Console.WriteLine();
            m2.Display();
            Console.WriteLine();
            d1.Display();
            Console.ReadKey();
        }
    }
}
