using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    interface Bank
    {
        string Deposit(int Actno, int Amt);
        }
    class Saving : Bank
    {
        int Actno;
        int Bal = 2000;
        public string Deposit(int Actno, int Amt)
        {
            this.Actno = Actno; ;
            Bal = Bal + Amt;
            return "deposited successfully successfully ,Bal is " + Bal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b = new Saving();
            String str = b.Deposit(1, 200);
            Console.WriteLine(str);

        }
    }

}
