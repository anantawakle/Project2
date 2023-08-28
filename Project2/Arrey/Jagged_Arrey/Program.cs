using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey.Jagged_Arrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jarry = new int[5][];
           jarry[0] = new int []{ 12,5,3,2};
            jarry[1] = new int[] {20,5,6};
            jarry[2]=new int[] {7,0,3,9};
            jarry[3]=new int[] {85,5,69,8,0,3};
            jarry[4]=new int[] {85,62,23,8,2,0};
            for(int row=0;row<jarry.Length;row++) 
            {
                for(int col=0; col< jarry[row].Length;col++)
                {
                    Console.Write(jarry[row][col]+" " );
                    //jarry[row][col] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
        }
    }
}
