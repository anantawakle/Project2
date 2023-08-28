using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps.Static
{
     static  class Product
    {
         static int id;
        static string name;
        static double price;
        static Product() 
        {
             id= 0;
            name = "drt";
            price= 0;

        }
        public static void Print()
        {
             Console.WriteLine(" Product Id{0}: ", id);
             Console.WriteLine(" Product Name{0} :", name);
             Console.WriteLine(" Product Price {0}:", price);
            /*return $" {id}, {name}, {price}";*/

        }


        static void Main(string[] args)
        {
            Product .Print ();
        }

            

            


    }
}
