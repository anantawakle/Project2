using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Foreach
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double  salary { get; set; }
    }


    public class Program 
    {
        static void Main(string[] args)
        {
            Employee[] list = new Employee[3]
            {
                new Employee { Id = 1,Name=" Ananta", salary=56000.00},
                new Employee { Id = 2,Name="Akshay", salary=56500.00},
                new Employee { Id = 3,Name=" Kunal",salary=58000.00}
            };
            foreach (Employee e in list) 
            {
                Console.WriteLine($"{e.Id},{e.Name},{e.salary}");
            }
        }
    }
        


}
