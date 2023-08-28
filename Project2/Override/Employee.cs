using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Override
{
    public  class Employee
    {
        protected int id;
        protected string name;
        protected int age;
        protected string position;
        protected double salary, ta, hra, da, pf, gross;
        public Employee(int id, string name, int age,string position, double salary) 
        { 
            this.id = id;
            this.name = name;
            this.age = age;
            this.position = position;
                
        }
        public virtual void Calculate()
        {
            hra = salary * 0.40;
            da = salary * 0.30;
            ta = salary * 0.20;
            pf = salary * 0.10;
            gross = (salary + da + hra + ta) - pf;
        }
        public virtual string Print()
        {
            return $" Employee id={id}, name={name}, ahe={age},position ={position}, salary={salary}, Gross={gross}";
        }
        public class Maneger:Employee
        {
            protected double comission;
            protected double bonous;
            public Maneger(int id, string name, int age, string position, double salary,double comission, double bonous) : base(id, name, age, position, salary)
            {
                this.comission = comission;
                this.bonous = bonous;


            }
            public override void Calculate()
            {

                hra = salary * 0.40;
                da = salary * 0.30;
                ta = salary * 0.20;
                pf = salary * 0.10;
                gross = (salary + da + hra + ta) - pf;
            }

            public override string Print()
            {
                return $" Maneger id={id}, Maneger name={name}, age={age}, Maneger position={position},salary={salary},Gross={gross}, Cammision={comission}, bonous={bonous}";
            }



            static void Main(string[] args)
            {
                Maneger m1 = new Maneger(101, "Ananta", 23, "Sinious software devloper",89000,5000,10000);
                m1.Calculate();
                Console.WriteLine(m1.Print());
            }

        }

    }
}
