using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main()
        {
            Console.WriteLine("addition of 2 no. " + Add(1, 2));

            Console.WriteLine("addition of  3 no " + Add(1, 2, 3));
        }

    }
}

