using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character
{
    class Program
    {

        public static void Main()
        {
            char b = 'M';
            Console.WriteLine(" value " + b);
            Console.WriteLine("enter value ");
            b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("value = " + b);



            Console.ReadLine();
        }
    }
}

