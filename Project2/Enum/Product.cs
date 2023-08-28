using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Enum
{
    public  class Product
    {
        private int id, price;
        private string name;
        private Categories category;
        public Product(int id, int price, string name,  categories category)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.category = category;
        }

        public override string ToString() 
        {
            return $" {id} {name} {price} {category}";
        }



        static void Main(string[] args)
        {
            Product p1=new Product(1,20,"Pen",Categories.HomeNeeds):
                Console.WriteLine(p1);
        }
    }
}
