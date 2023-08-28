using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps
{
    public class Studentdata
    {
        private  int id;
        private string name;
        private int age;
        private int  physics;
        private int chemistry;
        private int math;
        private int  english;
        private int marathi;
        private double totalmark;
        private double obtainmark;
        private double percentage;
        public Studentdata(int id, string name,int age, int physics, int chemistry, int math, int marathi, int english)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.physics = physics;
            this.chemistry = chemistry;
            this.math = math;
            this.marathi = marathi;
            this.english = english;
        }
        

        



        
        
        
        public void Mark()
        {
            totalmark = 500;
                obtainmark= physics + chemistry + math + english + marathi;
            percentage =(obtainmark/totalmark)*100;


        }
        public void   Grade()
        {
            if (percentage>75)
            {
                Console.WriteLine( "A+");
            }
            else if(percentage<75)
            {
                Console.WriteLine( "A");
            }
            else if(percentage >65)
            {
                Console.WriteLine( "B+");
            }
            else if(percentage <65)
            {
                Console.WriteLine( "C+");
            }
            else if(percentage>40)
            {
                Console.WriteLine("c");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            
        }
        public string Print()
        {
            return $" Student data  id={id}, Student name={name}, age={age}, physicsmark={physics}, chemistry mark={chemistry}, math mark={math}, marathi mark={marathi}, Englishmark ={english}, Totalmark={totalmark}, obtainmark={obtainmark},Percentage={percentage}";
        }



        static void Main(string[] args)
        {
            Studentdata sd = new Studentdata(101, "Ananta wakle", 23,85,56,89,65,98);
            sd.Mark();
            sd.Grade();
            Console.WriteLine(sd.Print());


        }
    }

}
