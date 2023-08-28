using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Autoemplitation_property
{
    public  class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percentage  { get; set; }
        public string print()
        {
            return $"   Id={Id} , Name=  {Name} ,{Percentage} ";
        }
        static void Main(string[] args)
        {
                // Property initilization
                Student s1 = new Student();
                s1.Id = 1;
                 s1.Name = "Test";
                 s1.Percentage = 100;
            Console.WriteLine($"{ s1.Id} , { s1.Name} , {s1.Percentage}");

            // object initiization 
            Student s2 = new Student() { Id = 2 , Name="Akshay", Percentage=89.23};
            Console.WriteLine($"{s2.Id} ,{s2.Name} ,{s2.Percentage}");

        }
    }
}
