using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey
{
    internal class Rainfall
    {
        static void Main(string[] args)
        {
            double [] day = new double [7];
                for(int i=0;i<day.Length;i++) 
            {
                day [i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine(" Rain fall in weak");
            for(int i=0 ;i<day .Length ;i++) 
            {
                Console.WriteLine($" day [{i}]={day[i]}");
            }
        }
    }
}
