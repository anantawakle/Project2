using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps.Tostring
{
    public  class Productdetails
    {
        public int id;
        public string name;
        public double price;
        public Productdetails( int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;

        }
        public override string ToString()
        {
            return $" Product Details:{id} {name} {price}";
        }

        static void Main(string[] args)
        {
            Productdetails p1 = new Productdetails(101, " Mango", 580);
            Console.WriteLine(p1.ToString());
        }
    }
}
