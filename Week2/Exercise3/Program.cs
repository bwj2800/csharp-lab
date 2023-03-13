using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    abstract class Employee
    {
        private int matricule;
        private string first_name;
        private string last_name;
        private string birth;
        public Employee()
        {

        }
        public Employee(int m, string f, string l, string b)
        {
            matricule= m;
            first_name = f;
            last_name = l;
            birth = b;
        }
        public Employee(Employee e)
        {
            matricule = e.Matricule;
            first_name = e.First_name;
            last_name = e.Last_name;
            birth = e.Birth;
        }

        public int Matricule
        {
            get
            {
                return matricule;
            }
            set
            {
                matricule = value;
            }
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
        public void ToString()
        {
            Console.WriteLine("My name is " + first_name + " " + last_name + ".\n" +
                "My date of birth is " + birth + 
                ", and my matricule number is "+ matricule+".");
        }
        public abstract void GetSalary();
    }

    class Worker : Employee
    {
        private string entry;
        private int smig=2500;
        private int salary;
        public Worker() : base()
        {

        }
        public Worker(int m, string f, string l, string b, string e) : base(m, f, l, b)
        {
            entry = e;
        }
        public Worker(Worker e)
        {
            Matricule = e.Matricule;
            First_name = e.First_name;
            Last_name = e.Last_name;
            Birth = e.Birth;
            salary = e.Salary;
            entry = e.Entry;
        }
        public string Entry
        {
            get
            {
                return entry;
            }
            set
            {
                entry = value;
            }
        }
        public int Salary
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
        public void ToString()
        {
            base.ToString();
            Console.WriteLine("My entry date is " + entry +".");
        }
        public override void GetSalary()
        {
            DateTime today = DateTime.Today;
            int years = today.Year-Int32.Parse(entry.Substring(0, 4));
            salary = smig + years * 100;
            if (salary>smig*2)
            {
                salary=smig*2;
            }
            Console.WriteLine("My monthly salary is " + salary + ".");
        }
    }

    class Executive : Employee
    {
        private int index;
        private int salary;
        public Executive() : base()
        {
            
        }
        public Executive(int m, string f, string l, string b, int i) : base(m, f, l, b)
        {
            index = i;
        }
        public Executive(Executive m)
        {
            Matricule = m.Matricule;
            First_name = m.First_name;
            Last_name = m.Last_name;
            Birth = m.Birth;
            salary = m.Salary;
            index = m.index;
        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public int Salary
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
        public void ToString()
        {
            base.ToString();
            Console.WriteLine("My index is " + index + ".");
        }
        public override void GetSalary()
        {
            if (index==1)
            {
                salary = 13000;
            }
            else if (index == 2)
            {
                salary = 15000;
            }
            else if (index == 3)
            {
                salary = 17000;
            }
            else 
            {
                salary = 20000;
            }
            Console.WriteLine("My monthly salary is " + salary + ".");
        }
    }

    class Boss : Employee
    {
        private double turnover;
        private double percentage;
        private double salary;
        public Boss() : base()
        {
            
        }
        public Boss(int m, string f, string l, string b, double t, double p) : base(m, f, l, b)
        {
            turnover = t;
            percentage = p;
        }
        public Boss(Boss b)
        {
            Matricule = b.Matricule;
            First_name = b.First_name;
            Last_name = b.Last_name;
            Birth = b.Birth;
            salary = b.Salary;
            turnover = b.Turnover;
            percentage = b.Percentage;
        }
        public double Turnover
        {
            get
            {
                return turnover;
            }
            set
            {
                turnover = value;
            }
        }
        public double Percentage
        {
            get
            {
                return percentage;
            }
            set
            {
                percentage = value;
            }
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
        public void ToString()
        {
            base.ToString();
            Console.WriteLine("My turnover is " + turnover + ", and percentage is "+percentage+".");
        }
        public override void GetSalary()
        {
            salary = turnover*percentage/100;
            Console.WriteLine("My annual salary is " + salary + ".");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker w1 = new Worker(1111, "worker", "1", "1995/01/01", "2010/02/01");
            Worker w2 = new Worker(2222, "worker", "2", "1995/10/10", "2018/02/01");
            Executive e = new Executive(3333, "executive", "1", "1985/02/02", 2);
            Boss b = new Boss(4444, "boss", "1", "1970/03/01", 100000, 50);

            w1.ToString();
            w1.GetSalary();
            Console.WriteLine();
            w2.ToString();
            w2.GetSalary();
            Console.WriteLine();
            e.ToString();
            e.GetSalary();
            Console.WriteLine();
            b.ToString();
            b.GetSalary();
            Console.ReadKey();
        }
    }
}
