using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = " Hello to all";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());
            message = message + " Good morning";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());
            message = message + " Good day";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());
        }
    }
}
