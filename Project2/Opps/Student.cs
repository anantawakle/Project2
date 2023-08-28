using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project2.Opps
{
    public  class Student
    {
        private int id;
        private string name;
        private double percentage;
        public Student(int id, string name, double percentage)
        {
            this.id = id;
            this.name = name;
            this.percentage = percentage;

        }
        public string Print()
        {
            return $" Student id={id}, Name={name}, Percentage ={percentage}";
        }


        static void Main(string[] args)
        {
            Student s1 = new Student(101, "Ananta", 85.00);
            Console.WriteLine(s1.Print());
        }
    }
    


   
}
