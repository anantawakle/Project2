using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey.Arreypractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* First way to aary decleared*/
            string[] arry1 = new string[4];
            arry1[0] = " ananta";
            arry1[1] = "Akshay";
            arry1[2] = " Ram";
            arry1[3] = " Sham";
            /* Second way*/
            string[] arry2 = new string[] { " Anant", " Ankit", "jay", "viru" };
            /* Third way*/
            string[] arry3 = { "ram ", "dev", "ganesh", "ganpat" };
             
            
            Console.WriteLine(arry3[0]);
            Console.WriteLine(arry3[1]);
            Console.WriteLine(arry3[2]);
            Console.WriteLine(arry3[3]);
            Console.ReadLine();

            

        }
    }
}
