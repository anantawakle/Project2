using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Stracture
{
    internal struct Student
    {
        private int roll_no;
        private string name;    
        private int age;
        private double percentage;
        public Student(int roll_no, string name, int age, double percentage)
        {
                  this.roll_no = roll_no;
                 this.name = name;
                  this.age = age;
            this.percentage = percentage;
        }
        public override string ToString()
        {
            return $" Student_rollno{roll_no} Student Name={name} age={age} Percentage={percentage}";
        }



        static void Main(string[] args)
        {
            Student s1=new Student( 101," Ananta", 23,85.00);
            Console.WriteLine(s1.ToString());
        }
    }
}
