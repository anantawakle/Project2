using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey.Arreypractice._2D
{
    internal class Print_Name
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[3,4]
            {
                {" Ananta", " Jay","Sham", "Durgesh" },
                { " Ankita", " Tanmay", " Jay"," Jaya" },
                {" Durga", "Kapil", " Tukaram", " Suraj" }
            };
            for( int i=0; i<arr.GetLength(0); i++ ) 
            {
                for(int j=0; j<arr.GetLength(1); j++ ) 
                {
                    Console.Write(arr[i,j] +"  ");
                }
                Console.WriteLine();
            }
        }
    }
}
