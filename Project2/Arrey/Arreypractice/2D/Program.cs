using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey.Arreypractice._2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int [3,4]
            {
                { 14,45,65,45},
                {15,52,26,36 },
                { 14,26,35,82}
            };

            for(int i=0; i<arr.GetLength(0); i++) 
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
