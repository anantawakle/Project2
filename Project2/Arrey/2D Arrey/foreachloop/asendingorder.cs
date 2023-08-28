using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey._2D_Arrey.foreachloop
{
    internal class asendingorder
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 67, 12, 89, 5 };
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0;j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("asc order");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            int[] arr2 = { 45, 67, 12, 89, 5 };
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j > arr2.Length; j++)
                {
                    if (arr2[i] > arr[j])
                    {
                        int temp;
                        temp = arr2[i];
                        arr[i] = arr2[j];
                        arr2[j] = temp;
                    }
                }
                Console.WriteLine(" decending order");
                foreach (int a in arr2)
                {
                    Console.WriteLine(a);
                }
            }



        }
    }
}
