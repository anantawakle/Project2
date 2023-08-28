using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey.Arreypractice.fore_achloop
{
    internal class Num
    {
        static void Main(string[] args)
        {

            int[,] numb = new int[3, 4]
            {
                { 41,12,25,20 },
                {14,52,20,35 },
                { 25,12,85,62 }

            };
            foreach (int i in numb)
            {
                Console.WriteLine(i+" ");
            }
            
        }
    }
}
