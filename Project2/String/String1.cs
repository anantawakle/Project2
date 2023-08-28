using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.String
{
    internal class String1
    {
        static void Main(string[] args)
        {
            
            
                string myName = "Ananta Wakle";
                Console.WriteLine(" My_Name=" + myName);
                Console.WriteLine(myName[0]);//A
                Console.WriteLine(myName[1]);//n
                Console.WriteLine(myName[2]);//a
                Console.WriteLine(myName.Length);//10
                Console.WriteLine(myName.ToLower());// ananta wakle
                Console.WriteLine(myName.ToUpper());// Ananta Wakle
                Console.WriteLine(" My name index of a=" + myName.IndexOf('a'));//2
                Console.WriteLine(" My name index of W=" + myName.IndexOf('W'));//7
                Console.WriteLine(" Last index of a= " + myName.LastIndexOf('a'));//8
                Console.WriteLine(" Check the starts " + myName.StartsWith("Ananta"));// true
                Console.WriteLine(" Check the ending " + myName.EndsWith("Wakle"));//true
                Console.WriteLine(" Check equal or not=" + myName.Equals("Ananta Wakle"));
                Console.WriteLine(" Check equal or not=" + myName.Equals("C#"));//false

            
        }
    }
}
