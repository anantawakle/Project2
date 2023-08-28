using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Lab
{
    internal class Polindrom
    {
        static void Main(string[] args)
        {
            int num = 121;
            int tem;
            tem = num;
            int rem;
            int rev = 0;
            while(num > 0) 
            {
                rem = num % 10;
                rev=rev*10+rem;
                num= num / 10;
            }
            if(tem==rev)
            {
                Console.WriteLine(" Poly");
            }
            else 
            {
                Console.WriteLine("Not");
            }
        }
    }
}
