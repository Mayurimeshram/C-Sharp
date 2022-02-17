using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void AddOne(out int x)
        {
            x = 5;
            x++; 
                 //  Console.WriteLine("value inside addone method is " + x); //6
        }
        static void Main()
        {
            int roi;
            AddOne(out roi);
            Console.WriteLine("rate of interest  " + roi); 

        }
    }
}

