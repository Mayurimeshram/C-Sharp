﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para
{
    class Program
    {
        
        static void factorial(int num)
        {
            int res = 1;
            int i = 1;
            while (i <= 10)
            {
                res = i * num;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
                i++;
            }


        }
        static void Main(string[] args)
        {
            int num = 5;
            factorial(num);
            Console.ReadLine();

        }
    }
}

