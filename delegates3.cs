using System;
using System.Collections.Generic;


namespace ConsoleApp7
{
    public delegate int del1(int n1, int n2);
    class program
    {
        public int addition(int n1,int n2)
        {
            return n1 + n2;

        }
         public int substraction(int n1,int n2)
        {
            return n1 - n2;
        }
        static void Main(string[] args)
        {
            program p = new program();
            del1 d1 = new del1(p.addition);
            int res = d1(2, 4);
            Console.WriteLine(" addition result " + res);

            del1 d2 = new del1(p.substraction);
             res = d2(4, 2);
            Console.WriteLine("substraction result" + res);
        }



        }
    }
    
