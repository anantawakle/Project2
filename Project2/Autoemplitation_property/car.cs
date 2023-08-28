using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Autoemplitation_property
{
    public  class car
    {
        public int Modelid  { set; get; }
        public string Name { set; get; }
        public string Color { set; get; }
        public string Company { set; get; }
        public double Cost { set; get; }
        public string Print()
        {
            return $"{Modelid}, {Name}, {Color} , {Company} , {Cost}";
        }
        static void Main(string[] args)
        {

            // Property initilization
            car c1= new car();  
            c1.Modelid = 1;
            c1.Name = "Audi";
            c1.Color = "Black";
            c1.Cost = 120000000052.00;
            Console.WriteLine(c1.Print());
            // object initilization 
            car c2 = new car() { Modelid = 2, Name = "Audi", Color = "White", Cost = 56000000.00 };
            Console.WriteLine(c2.Print());
        }
    }
}
