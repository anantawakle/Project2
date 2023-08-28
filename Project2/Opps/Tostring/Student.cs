using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps.Tostring
{
    public class Student
    {
        public int id;
        public string name; 
        public int age;
        public double percentage;
        public Student(int id, string name, int age, double percentage)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.percentage = percentage;
        }  
        
        public override string ToString() 
        {
            return $" Student_Details:{id} {name} {age} {percentage}";
        }

        static void Main(string[] args)
        {
            Student s1 = new Student(101, "Ananta Wakle", 23, 85.00);
            Console.WriteLine(s1.ToString());
        }
    }
}
