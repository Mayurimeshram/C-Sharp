﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum grade { dist = 90, first = 60, second = 40 }
        public static void Main()
        {
            //write a program to accept character from the user 
            grade gr;

            gr = grade.first;
            Console.WriteLine("grade  = " + gr);
            Console.WriteLine("grade value = " + Convert.ToInt32(gr));

        }
    }
}
