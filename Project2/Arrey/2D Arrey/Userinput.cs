using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey._2D_Arrey
{
    internal class Userinput
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
                // accept 2D from user*/
                for(int row=0;row<arr.GetLength(0);row++) 
                {
                 
                    for(int col=0;col<arr.GetLength(1);col++) 
                    {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                    }
                }


            for (int row = 0; row < arr.GetLength(0); row++)
            {

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.WriteLine($" arr[{row},{col}]= {arr[row,col]}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
