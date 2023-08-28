using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey._2D_Arrey
{
    internal class Samplecode
    {
        static void Main(string[] args)
        {
            // Syntax //
            int[,] arr = new int[3,4]
            {
                {10,20,30,40 },
                {50,60,70,80 },
                {90,100,110,120 }
            };
            // nested for loop*/
            for(int row=0; row<arr.GetLength(0);row++) 
            {
                for(int col=0; col<arr.GetLength(1);col++) 
                {
                    Console.WriteLine($"arr[{row},{col}]={arr[row,col]}");
                }
                Console.WriteLine("\n");
            }
                
        }
    }
}
