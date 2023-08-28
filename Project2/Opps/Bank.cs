using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Opps
{
    public class Bank
    {
        private double accno;
        private string name;
        private double accbalance;
        public Bank(double accno, string name, double accbalance)
        {
            this.accno = accno;
            this.name = name;
            this.accbalance = accbalance;
        }
        public void Credit(double creditamount)
        {
            accbalance = accbalance + creditamount;

        }
        public string Debite(double debitamount)
        {
            string msg = "";
            if (accbalance <= debitamount)
            {
                accbalance = accbalance - debitamount;
                msg = "Transection is done";
            }
            else
            {
                msg = "Insufficent bank balance";
            }
            return msg;
        }
        public string Print()
        {
            return $" {accno}, {name}, {accbalance}, ";
        }



        static void Main(string[] args)
        {
            Bank b1 = new Bank(14493210005674, "Anantawakle ", 150000.00);
            b1.Credit(100);
            b1.Debite(0);
            Console.WriteLine(b1.Print());
        }
    }
}
