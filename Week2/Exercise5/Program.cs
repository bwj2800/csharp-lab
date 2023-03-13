using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise5
{
    class Article
    {
        private int reference_number;
        private string name;
        private double selling_price;
        private int quantity;
        public Article()
        {

        }
        public Article(int r, string n, double s, int q)
        {
            reference_number= r;
            name = n;
            selling_price = s;
            quantity = q;
        }
        public Article(Article a)
        {
            reference_number = a.Reference_number;
            name = a.Name;
            selling_price = a.Selling_price;
            quantity = a.Quantity;
        }
        public int Reference_number
        {
            get
            {
                return reference_number;
            }
            set
            {
                reference_number = value;
            }
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
        public double Selling_price
        {
            get
            {
                return selling_price;
            }
            set
            {
                selling_price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string ToString()
        {
            string desc = "reference_number: " + reference_number + ", name: " + name
                + ", selling_price: " + selling_price + ", quantity: "+quantity;
            return desc;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Article a1 = new Article(1, "article1", 100, 1);
            Article a2 = new Article(2, "article2", 200, 1);
            Article a3 = new Article(3, "article3", 300, 1);
            Article a4 = new Article(4, "article4", 400, 1);
            Article a5 = new Article(5, "article5", 500, 1);
            Article a6 = new Article(6, "article6", 600, 1);

            List<Article> articles = new List<Article> { a1, a2, a3, a4, a5, a6 };

            List<Article> myStock = new List<Article>();

            while (true)
            {
                Console.WriteLine("\n<Menu>");
                Console.WriteLine("1.Search for an article by reference.\n2.Add an item to the stock by checking the uniqueness of the reference.\n3.Delete an article by reference.\n4.Modify an article by reference.\n5.Search for an article by name.\n6.Search for an item by sale price range.\n7.View all articles.\n8.Quit");
                Console.Write("Enter the number: ");
                int mode=Int32.Parse(Console.ReadLine());
                if (mode==1)
                {
                    //search by reference
                    Console.Write("Enter the reference number: ");
                    int reference = Int32.Parse(Console.ReadLine());

                    var item = articles.Find(x=>x.Reference_number==reference);

                    if (item==null)
                    {
                        Console.WriteLine("No article found");
                    }
                    else
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                else if (mode==2)
                {
                    Console.Write("Enter the reference number: ");
                    int reference = Int32.Parse(Console.ReadLine());

                    var item = articles.Find(x => x.Reference_number == reference);
                    var item2 = myStock.Find(x => x.Reference_number == reference);

                    if (item != null && item2==null)
                    {
                        myStock.Add(item);
                    }
                    else
                    {
                        Console.WriteLine("Article already exist in stock or not existing reference number");
                    }
                }
                else if (mode == 3)
                {
                    Console.Write("Enter the reference number: ");
                    int reference = Int32.Parse(Console.ReadLine());

                    var item = articles.Find(x => x.Reference_number == reference);

                    if (item == null)
                    {
                        Console.WriteLine("No article found");
                    }
                    else
                    {
                        articles.Remove(item);
                    }
                }
                else if (mode == 4)
                {
                    //modify
                    Console.Write("Enter the reference number: ");
                    int reference = Int32.Parse(Console.ReadLine());

                    var item = articles.Find(x => x.Reference_number == reference);

                    if (item == null)
                    {
                        Console.WriteLine("No article found");
                    }
                    else
                    {
                        Console.Write("Enter the new reference number: ");
                        int new_reference = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter the new name: ");
                        string new_name = Console.ReadLine();
                        Console.Write("Enter the new selling price: ");
                        int new_price = Int32.Parse(Console.ReadLine());
                        Console.Write("Enter the new quantity: ");
                        int new_quantity = Int32.Parse(Console.ReadLine());

                        articles.Remove(item);
                        articles.Add(new Article(new_reference, new_name, new_price, new_quantity));
                    }
                }
                else if (mode == 5)
                {
                    Console.Write("Enter the name: ");
                    string name = Console.ReadLine();

                    List<Article> item = articles.FindAll(x => name.Equals(x.Name));

                    if (item == null)
                    {
                        Console.WriteLine("No article found");
                    }
                    else
                    {
                        for (int i = 0; i < item.Count; i++)
                        {
                            Console.WriteLine(item[i].ToString());
                        }
                    }
                }
                else if (mode == 6)
                {
                    //search by sale price range
                    Console.Write("Enter the sale price range (ex. 100-300): ");
                    string range = Console.ReadLine();

                    int range_start= Int32.Parse(range.Substring(0,range.IndexOf('-')));
                    int range_end= Int32.Parse(range.Substring(range.IndexOf('-')+1));
                    Console.Write(range_start+" "+range_end);

                    List<Article> item = articles.FindAll(x => x.Selling_price<=range_end && x.Selling_price >= range_start);

                    if (item == null)
                    {
                        Console.WriteLine("No article found");
                    }
                    else
                    {
                        for (int i = 0; i < item.Count; i++)
                        {
                            Console.WriteLine(item[i].ToString());
                        }
                    }
                }
                else if (mode == 7)
                {
                    for (int i=0;i<articles.Count;i++)
                    {
                        Console.WriteLine(articles[i].ToString());
                    }
                }
                else if (mode == 8)
                {
                    break;
                }
            }
        }
    }
}
