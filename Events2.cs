using System;
using System.Collections.Generic;


namespace ConsoleApp7
{
    class publisher
    {
        //declare a delegate to hold ref to a method with 2 int parameter and which return type is int
        public delegate void del1(int n1, int n2);
        //declaring an event
        public event del1 event1;
        //creating a method to raise the event
        public void raiseevent(int n1, int n2)
        {
            if (event1 != null)
            {
                //raise the event
                event1(n1, n2);
            }
            else
            {
                Console.WriteLine("no subscriber");
            }
        }
    }

    class Program
    {
        //creating a method addition with 2 int parameter and return type is int
        public void addition(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("result " + res);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            publisher pb = new publisher();
            //subscribing an event
            pb.event1 += new publisher.del1(p.addition);
            pb.raiseevent(3, 5);

        }

    }
}
