using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps
{
    public  class Food
    {
        private int id;
        private string name;
        private double price;
        private double discount;
        private double percentagediscount;
        public Food(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public string Print()
        {
            return $" Food id={id}, Food name={name}, Price={price}";
        }


        static void Main(string[] args)
        {
            Food f1 = new Food(101, "Apple", 89.00);
            Console.WriteLine(f1.Print());
        }
    }
}
