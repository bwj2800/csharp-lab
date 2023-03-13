using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exception_occured=true;
            while (exception_occured)
            {
                try
                {
                    Console.Write("Enter an integer: ");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    exception_occured = false;
                }
                catch (Exception)
                {
                    exception_occured = true;
                    Console.WriteLine("Enter an correct integer value.");
                }
            }

            exception_occured = true;
            DateTime nowDate = DateTime.Today;            
            while (exception_occured)
            {
                try
                {
                    Console.Write("Enter the date of birth (ex. 2001/01/25): ");
                    string input2 = Console.ReadLine();
                    if (!Regex.IsMatch(input2, @"^(19|20)\d{2}/(0[1-9]|1[012])/(0[1-9]|[12][0-9]|3[0-1])$"))
                    {
                        throw new Exception("wrong date format");
                    }
                    string[] birth = input2.Split('/');
                    DateTime birthday = new DateTime(Convert.ToInt32(birth[0]), Convert.ToInt32(birth[1]), Convert.ToInt32(birth[2]));
                    if (DateTime.Compare(nowDate, birthday)<0)
                    {
                        throw new Exception("birthday must be before today");
                    }
                    exception_occured = false;
                }
                catch (Exception)
                {
                    exception_occured = true;
                    Console.WriteLine("Enter an correct date of birth.");
                }
            }

            exception_occured = true;
            while (exception_occured)
            {
                try
                {
                    Console.Write("Enter a departure date and an arrival date (ex. 2023/01/02 2023/01/08): ");
                    string input3 = Console.ReadLine();
                    string[] dates = input3.Split(' ');
                    if (!Regex.IsMatch(dates[0], @"^(19|20)\d{2}/(0[1-9]|1[012])/(0[1-9]|[12][0-9]|3[0-1])$")
                        || !Regex.IsMatch(dates[1], @"^(19|20)\d{2}/(0[1-9]|1[012])/(0[1-9]|[12][0-9]|3[0-1])$")
                        || dates.Length!=2)
                    {
                        throw new Exception("wrong date format");
                    }
                    string[] departure_date = dates[0].Split('/');
                    string[] arrival_date = dates[1].Split('/');
                    DateTime d_date = new DateTime(Convert.ToInt32(departure_date[0]), Convert.ToInt32(departure_date[1]), Convert.ToInt32(departure_date[2]));
                    DateTime a_date = new DateTime(Convert.ToInt32(arrival_date[0]), Convert.ToInt32(arrival_date[1]), Convert.ToInt32(arrival_date[2]));
                    if (DateTime.Compare(d_date, a_date) > 0)
                    {
                        throw new Exception("arrival date must be before the departure date");
                    }
                    exception_occured = false;
                }
                catch (Exception)
                {
                    exception_occured = true;
                    Console.WriteLine("Enter an correct departure date and an arrival date.");
                }
            }
            Console.ReadKey();
        }
    }
}
