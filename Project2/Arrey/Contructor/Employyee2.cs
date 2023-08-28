using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey.Contructor
{
    public class Employyee2
    {
        public int id;
        public string name;
        public double salary;
        public Employyee2(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }


    public class Emp
    {
        static void Main(string[] args)
        {
            Employyee2[] list = new Employyee2[3]
            {
                new Employyee2(101," Ananta", 2500.00),
                new Employyee2(101," Ananta", 2500.00),
                new Employyee2(101," Ananta", 2500.00),





            }; 

            foreach (Employyee2 e in list) 
            {
                Console.WriteLine($" {e.id} { e.name} {e.salary}" );
            }


        }
    }
}
