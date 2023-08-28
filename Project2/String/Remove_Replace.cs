using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.String
{
    internal class Remove_Replace
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(" Hello to all");
            Console.WriteLine(sb);
            sb.AppendLine(" Good Morning");
            Console.WriteLine(sb);
            sb.Remove(4, 5);
            Console.WriteLine(sb);
            sb.Replace('i', 'L');
            Console.WriteLine(sb);

        }
    }
}
