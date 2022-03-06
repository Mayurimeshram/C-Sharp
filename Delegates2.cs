using System;
using System.Collections.Generic;


namespace ConsoleApp7
{
    public delegate int del_square(int n1);
    class program
    {
        public int square(int n1)
        {
            return n1 * n1;
        }
        static void Main(string[] args)
        {
            program p = new program();
            del_square d1 = new del_square(p.square);
            int res = d1(4);
            Console.WriteLine("square = " + res);


        }
    }
}
