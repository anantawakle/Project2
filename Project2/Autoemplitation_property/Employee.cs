using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Autoemplitation_property
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary  { get; set; }
        public string print()
        {
            return $" Employeee id={Id} , Employee name={Name} , Empoyee position ={Position}, Employee salary={Salary}";
        }
        static void Main(string[] args)
        {
            // Property initilization 
            Employee e1= new Employee();
            e1.Id = 1;
            e1.Name = "Ananta";
            e1.Position = "Software devloper";
            e1.Salary = 56000.00;
            Console.WriteLine($" { e1.Id} ,{e1.Name} ,{e1.Position} ,{e1.Salary}");
            // object initilization 
            Employee e2= new Employee() {  Id=1  , Name="Ananta wakle", Position="Software devloper", Salary=89000.02};
            Console.WriteLine($" {e2.Id} , {e2.Name} , {e2.Position} , {e2.Salary}");
        }

    }
}
