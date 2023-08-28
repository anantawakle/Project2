using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Property
{
    public class Student
    {
        public int id;
        public string name;
        public double percentage;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Percentage
        {
            set { percentage = value; }
            get { return percentage; }
        }
        public string print()
        {
            return $" {Id} , {Name} , {percentage}";
        }
        static void Main(string[] args)
        {
            // Property initializer syntax
            Student stud = new Student();
            // it calls the set accessor
            stud.Name = "Rohan";
            stud.Percentage = 78.45;

            // it calls the get accessor
            Console.WriteLine($"{stud.Id} {stud.Name} {stud.Percentage}");
            //Console.WriteLine(stud.print());

            // object initiazlier syntax
            Student stud2 = new Student() { Id = 2, Name = "Kishor", Percentage = 89.66 };

            Console.WriteLine($"{stud2.Id} {stud2.Name} {stud2.Percentage}");
        }





    }

}

