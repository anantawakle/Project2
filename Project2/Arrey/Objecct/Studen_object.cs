using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey.Objecct
{
    internal class Studen_object
    {
        static void Main(string[] args)
        {
            object[] Studarry=new object[4];
            {
                Studarry[0] = 100;
                Studarry[1] = " Ananta";
                Studarry[2] = 85.00;
                Studarry[3] = 102;
                foreach(object s in Studarry) 
                {
                    Console.WriteLine(s);
                }
                


            };
        }
    }
}
