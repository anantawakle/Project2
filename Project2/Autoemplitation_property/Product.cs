using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Autoemplitation_property
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double  Price  { get; set; }
        public string Print()
        {
            return $"{ Id} , {Name} , {Price} ";
        }
        static void Main(string[] args)
        {
            // property initilization 
            Product p1= new Product();
            p1.Id = 1;
            p1.Name = "xyz";
            p1.Price = 100;
            Console.WriteLine($"  { p1.Id} ,{p1.Name} , {p1.Price}");
        }
    }
}
