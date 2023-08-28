using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Stracture
{
    internal struct Book
    {
        private int id;
        private string name;
        private double price;
        public Book(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;

        }
        public override string ToString() 
        {
            return $" Book_id{id} Book_Name={name} Book_Price={price}";
        }



        static void Main(string[] args)
        {
            Book b1 = new Book( 1," xyz",523.00);
            Console.WriteLine(b1.ToString());
        }
    }
}
