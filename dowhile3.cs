using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("value of i: {0}", i);

                int j = i;
                i++;
                do
                {
                    Console.WriteLine("value of j : {0}", j);
                    j++;
                }
                while (j < 2);
            }
            while (i < 2);
        }
    }
}
