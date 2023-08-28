using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Arrey
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }
    }
    public class Emp2
    {
        static void Main(string[] args)
        {
            Employee[] list = new Employee[3]
            {


                new Employee { Id = 1,Name="Ananta", salary=85000.03},
                new Employee { Id = 2,Name=" Akshay", salary=98000.03},
                new Employee { Id = 3,Name=" Kunal", salary=96000.03}
            };
            foreach (Employee e in list) 
            {
                Console.WriteLine($"{e.Id} {e.Name} {e.salary}");
            }
            
        }
    }





}
