using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps
{
    public  class Employee
    {
        private int id;
        private string name;
        private double salary, hra, da, pf, ta, gross;
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void Calculate()
        {
            hra = salary * 0.40;
            da = salary * 0.30;
            ta= salary * 0.50;
            pf = salary * 0.12;
            gross = (salary + da + ta + hra) - pf;
        }
        public string Print()
        {
            return $" Employee id={id}, Name={name}, salary={salary} Gross={gross}";
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Ananta", 56000);
             e1.Calculate();
            Console.WriteLine(e1.Print());
        }
    }
}
