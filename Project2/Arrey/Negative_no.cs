using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey
{
    internal class Negative_no
    {
        static void Main(string[] args)
        {
            int count = 0;


            int[] number = new int[10];
            for(int i=0; i<number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" Print the all negative number");
            for(int i=0 ; i<number.Length ; i++) 
            {
                
                if(number [i]<0)
                {
                    Console.WriteLine($" number[{i}]= {number[i]}");
                    count++;
                }
               
            }
            Console.WriteLine("  the total negative number" +count);

        }
    }
}
