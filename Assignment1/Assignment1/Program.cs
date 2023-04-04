using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Item
    {

    }
    class Purchase
    {
        private Item purchased_item;
        private int quantity;
        private int code;
        public Purchase()
        {
            purchased_item =new Item();
            quantity = 0;
            code = -1;
        }
        public Purchase(Item i, int q, int c)
        {
            purchased_item = i;
            quantity = q;
            code = c;
        }
        public Purchase(Purchase p)
        {
            purchased_item = p.Purchased_item;
            quantity = p.Quantity;
            code = p.code;
        }
        public Item Purchased_item
        {
            get
            {
                return purchased_item;
            }
            set
            {
                purchased_item = value;
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
        public int Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public bool CompareTo(Purchase p)
        {
            if((quantity == p.Quantity) && (purchased_item == p.purchased_item)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Invoice
    {
        private int invoice_number;
        private DateTime invoice_date;
        private List<Purchase> collection;
        public Invoice()
        {
            invoice_number = -1;
            invoice_date = new DateTime();
            collection = new List<Purchase>();
        }
        public Invoice(int n, DateTime d, List<Purchase> c)
        {
            invoice_number = n;
            invoice_date = d;
            collection = c;
        }
        public Invoice(Invoice i)
        {
            invoice_number = i.invoice_number;
            invoice_date = i.invoice_date;
            collection = i.collection;
        }
        public int Invoice_number
        {
            get
            {
                return invoice_number;
            }
            set
            {
                invoice_number = value;
            }
        }
        public DateTime Invoice_date
        {
            get
            {
                return invoice_date;
            }
            set
            {
                invoice_date = value;
            }
        }
        public List<Purchase> Collection
        {
            get
            {
                return collection;
            }
            set
            {
                collection = value;
            }
        }
        public void Add(Purchase a)
        {
            if (!collection.Contains(a)) //CompareTo 사용?
            {
                collection.Add(a);
            }
            else
            {
                Console.WriteLine("The purchase is already added.")
            }
        }

        public double InvoiceAmount()
        {
            double total=0;
            for (int i=0;i<collection.Count; i++)
            {
                total += collection[i].Purchased_item.Price; //item price 타입 확인
            }
            return total;
        }
        public void Save_Purchases(string filename)
        {
            
        }
        public void ToString(string filename)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
