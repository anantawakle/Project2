using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.String
{
    internal class String__Builder
    {
        static void Main(string[] args)
        {
            string str1 = " Hello to all";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());
            str1=str1 + "  Good Morning";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            Console.WriteLine(" ---------- StringBuilder Class------");
            StringBuilder strsb = new StringBuilder(" Hello to all");
            Console.WriteLine(strsb );
            Console.WriteLine(strsb.GetHashCode());// adress
            strsb.Append("Good Morning");
            Console.WriteLine(strsb);
            Console.WriteLine(strsb.GetHashCode());

        }
    }
}
