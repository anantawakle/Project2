using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Override
{
    public  class Employee1
    {
        protected int id;
        protected string name;
        protected string position;
        protected double salary, hra, da, pf, ta, gross;
        public Employee1(int id, string name, string position, double salary)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.salary = salary;
        }
        public  virtual void Calculate()
        {
            hra = salary * 0.40;
            da = salary * 0.30;
            ta = salary * 0.12;
            pf = salary * 0.20;
            gross = (salary + da + ta + hra) - pf;
        }
        public  virtual string print()
        {
            return $" Emp id={id}, Emp name={name}, Emp salary={salary}, Gross={gross}";

        }


    }

    public class SalesEmployee : Employee1
    {
        double comission;
        double bonous;
        public SalesEmployee( int id, string name, string position, double salary ,double comission, double bonous):base(id,name, position, salary) 
        {
            this .comission = comission;
            this .bonous = bonous;
                

        }
        public override void Calculate()
        {
            hra = salary * 0.40;
            da = salary * 0.30;
            ta = salary * 0.12;
            pf = salary * 0.20;
            gross = (salary + da + ta + hra+comission+bonous) - pf;
        }
        public override string print() 
        {
            return $" selsemployee id={id}, Name={name}, Position={position}, salary={salary}, gross={gross}, Comission={comission}, Bonous={bonous}";
        }




        static void Main(string[] args)
        {
            SalesEmployee s1 = new SalesEmployee(101, "xyz", "Sr.software devloper", 89000.00, 5000, 20000);
            s1.Calculate();
            Console.WriteLine(s1 .print());
        }






    }
}
