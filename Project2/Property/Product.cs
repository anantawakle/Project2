using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Property
{
    public  class Product
    {
        public int id;
        public string name;
        public double price;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public string print()
        {
            return $"  {Id} , {Name}, { Price}";
        }

        static void Main(string[] args)
        {

            // Property initilization
            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Test";
            p1.Price = 1.0;
            
            Console.WriteLine($" {p1.Id} , {p1.name} , {p1.Price}");

            // object initilization 
            Product p2 = new Product() { Id = 2, Name = "xyz", Price = 56.00 };
            Console.WriteLine($"{p2.Id} ,{p2.Name} , {p2.Price}");
        }
    }
}
