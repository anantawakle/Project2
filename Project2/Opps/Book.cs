using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps
{
    public class Book
    {


        private int id;
        public string name;
        public string author;
        public Book(int id, string name, string author)
        {
            this.id = id;
            this.name = name;
            this.author = author;
        }
        public string Print()
        {
            return $" Id={id}  , Name={name} , Author={author}";
        }

        static void Main(string[] args)
        {
            Book b1 = new Book(101, "scw", "qwe");
            Console.WriteLine(b1.Print());
        }

    }
}
