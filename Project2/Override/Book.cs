using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Override
{
    public  class Book
    {
        protected int id;
        protected string name;
        protected string author;
        public Book(int id, string name, string author)
        {
            this.id = id;
            this.name = name;
            this.author = author;

        }
        public virtual string print()
        {
            return $" {id} , {name} , {author}";
        }
        
    }

    public class Nowel:Book
    {
        protected double price;
        public Nowel( int id, string name, string author, double price):base(id, name,author) 
        { 
            this.price = price;
        }
        public override string print() 
        {
            return $" Nowel id={id} , N name={name} N author={author} , N price={price}";
        }


        static void Main(string[] args)
        {
            Nowel n1 = new Nowel(101, "zxr", "yut", 260.30);
            Console.WriteLine(n1.print());
            Nowel n2 = new Nowel(102, "oyt", "yui", 267.00);
            Console.WriteLine(n2.print());
            Nowel n3 = new Nowel(103, "opy", "rtui",563.00);
            Console.WriteLine(n3.print());
        }
        
    }
}
