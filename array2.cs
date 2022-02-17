using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void AddOne(ref int x)
        {
            x++; // Increment x
            Console.WriteLine("value inside addone method is " + x); 
        }
        static void Main()
        {
            int k = 6;
            AddOne(ref k);
            Console.WriteLine("value after calling method in main " + k); 

        }
    }
}


