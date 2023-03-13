using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise4
{
    public delegate void AvgChanged(double average, string name);
    class Student
    {
        private string name;
        private double avg_grade;
        private int num_of_courses;
        public Student()
        {
            name = "";
            avg_grade = 0;
            num_of_courses = 0;
        }
        public Student(string n, double g, int c) 
        {
            name = n;
            avg_grade = g;
            num_of_courses = c;
        }
        public Student(Student s)
        {
            name = s.Name;
            avg_grade = s.Avg_grade;
            num_of_courses = s.Num_of_courses;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Avg_grade
        {
            get
            {
                return avg_grade;
            }
            set
            {
                avg_grade = value;
            }
        }
        public int Num_of_courses
        {
            get
            {
                return num_of_courses;
            }
            set
            {
                num_of_courses = value;
            }
        }
        public void RecordGrade(double grade, string name)
        {
            avg_grade = (avg_grade * num_of_courses + grade) / (num_of_courses + 1);
            Console.WriteLine("The new average grade of "+name+" is " + avg_grade + ".");
        }
    }
    class Registrar
    {
        string name;

        public Registrar(string n)
        {
            name = n;
        }
        public void report(double average, string student)
        {
            Console.WriteLine("My name is "+name+" as a registrar, I received the new average of Student named "+
                student+" successfully.");
        }
    }
    class Prof
    {
        string name;
        public Prof(string n)
        {
            name = n;
        }
        public void report(double average, string student)
        {
            Console.WriteLine("My name is " + name + " as a prof, I received the new average of Student named " +
                student + " successfully.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Woojeong BAEK", 3.9, 5);
            Registrar r = new Registrar("reg");
            Prof p = new Prof("prof");

            AvgChanged avgChanged = new AvgChanged(s.RecordGrade);
            avgChanged +=r.report;
            avgChanged += p.report;

            Console.Write("Enter your grade: ");
            double grade=Double.Parse(Console.ReadLine());
            avgChanged(grade, s.Name);

            avgChanged -= p.report;

            Console.Write("\nEnter your grade: ");
            grade = Double.Parse(Console.ReadLine());
            avgChanged(grade, s.Name);

            avgChanged = s.RecordGrade;

            Console.Write("\nEnter your grade: ");
            grade = Double.Parse(Console.ReadLine());
            avgChanged(grade, s.Name);
            Console.ReadKey();

        }
    }
}
