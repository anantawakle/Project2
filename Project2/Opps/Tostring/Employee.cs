using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps.Tostring
{
    public  class Employee
    {
        public int id;
        public string name;
        public double salary;
        public string position;
        public Employee( int id,string name, double salary, string position)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.position = position;
        }


        public override string ToString() 
        {
            return $" Employeedetails: {id} {name} {salary} {position}";
        }

        static void Main(string[] args)
        {
            Employee em = new Employee(101, "Ananta Wakle", 56000.00, "Softwaredevloper");
            Console.WriteLine(em.ToString());
        }
    }
}
