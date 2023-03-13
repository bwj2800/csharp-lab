using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Item
    {
        public Item(int id, string n)
        {
            this.ID = id;
            this.Name = n;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Purchase
    {
        public Purchase(int id, int n, int i)
        {
            this.ItemID = id;
            this.Quantity = n;
            this.InvNo = i;
        }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int InvNo { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>()
            {
                new Item(1, "Biscuit"),
                new Item(2, "Chocolate"),
                new Item(3, "Butter"),
                new Item(4, "Brade"),
                new Item(5, "Honey"),
            };
            List<Purchase> purchases = new List<Purchase>()
            {
                new Purchase(1,458,1),
                new Purchase(2,650,2),
                new Purchase(3,800,3),
                new Purchase(3,900,4),
                new Purchase(3,900,5),
                new Purchase(4,700,6),
                new Purchase(4,650,7),
            };


            var Query =
                from purchase in purchases
                join item in items on purchase.ItemID equals item.ID
                select new
                {
                    ItemID = item.ID,
                    ItemName = item.Name,
                    PurchaseQuantity = purchase.Quantity
                };

            Console.WriteLine($"{"Item ID", -15}{"Item Name",-15}{"Purchase Quantity",-15}");
            Console.WriteLine("---------------------------------------------------");
            foreach (var q in Query)
            {
                Console.WriteLine($"{q.ItemID,-15}{q.ItemName,-15}{q.PurchaseQuantity,-15}");
            }

            Console.ReadKey();
        }
    }
}
