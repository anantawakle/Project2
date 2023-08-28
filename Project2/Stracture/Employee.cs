using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Stracture
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;
        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $" Employee id={id} Emp_Name={name}, Emp_Salary={salary}"; 
        }



        static void Main(string[] args)
        {
            Employee emp = new Employee(1," Ananta",58000.00);
            Console.WriteLine(emp);

        }
    }
}
