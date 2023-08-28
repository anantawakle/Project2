using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey._2D_Arrey.foreachloop
{
    internal class Nyumprint
    {
        static void Main(string[] args)
        {
            int[,] arry2 = new int[3, 4]
            {
                {10,20,30,40 },
                {50,60,70,80 },
                { 90,100,110,120}
            };
            foreach (int i in arry2) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
