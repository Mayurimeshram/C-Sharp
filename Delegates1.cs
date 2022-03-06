using System;
using System.Collections.Generic;


namespace ConsoleApp7
{



    class Program
    {
        //declaring a delegate to hold reference to a method
        delegate void del_display();
        //creating a method
        public void display()
        {
            Console.WriteLine("hello from display method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //creating object of delegate
            del_display d1 = new del_display(p.display);
            //calling the delegate which in turns call the method display
            d1();





        }
    }
}
