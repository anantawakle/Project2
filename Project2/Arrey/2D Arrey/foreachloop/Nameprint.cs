using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey._2D_Arrey.foreachloop
{
    internal class Nameprint
    {
        static void Main(string[] args)
        {
            string[] arry = new string[5];

            for (int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine("Enter the name");
                arry[i] = Console.ReadLine();
            }
            foreach(var a in arry) 
            {
                Console.WriteLine(a);
            }
        }
    }
}
