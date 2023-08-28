using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey._2D_Arrey.foreachloop
{
    public class Product
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public double Price { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product[] list = new Product[3]
            {
            new Product{Id=1, Name = "Mouse", Price = 230 },
            new Product{Id=2,Name=" Keyboard", Price=720},
            new Product {Id=3, Name=" Printer", Price=25000}

            };
            foreach (Product p in list)
            {
                Console.WriteLine($"{p.Id},{p.Name},{p.Price}");
            }
        }
    }
    
}
