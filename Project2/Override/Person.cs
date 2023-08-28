using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Override
{
    public class Person
    {
        protected double aadharno;
        protected string name;
        protected string address;
        public Person(double aadharno, string name, string address)
        {
            this.aadharno = aadharno;
            this.name = name;
            this.address = address;
        }
        public virtual string Print()
        {
            return $" Person aadharno={aadharno}, person nname={name}, person address={address}";

        }
    }

    public class Patient :Person
    {
        protected int age;
        protected string bloodgroup;
        protected double  fees;
        public Patient( int aadharno, string name , string address, int age, string bloodgroup, double  fees):base(aadharno, name,address) 
        { 
            this.age = age;
            this.bloodgroup = bloodgroup;
            this.fees = fees;
        }
        public override string Print() 
        {
            return $" Patient aadharno={aadharno}, Patient name={name}, Patient address={address}, Bloodgp={bloodgroup},Fees={fees}";
        }

        static void Main(string[] args)
        {
            Patient p1 = new Patient(14021364, "xyz", "uio", 23, "A+", 2300.00);
            Console.WriteLine(p1.Print());
        }
    }
}
