using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey
{
    internal class Evenno
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            for(int i=0; i<number.Length; i++) 
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" Print the even no");
            for(int   i=0; i<number.Length; i++)
            {
                if ( number[i]%2== 0) 
                {
                    Console.WriteLine(number[i]);
                }
            }
        }
    }
}
