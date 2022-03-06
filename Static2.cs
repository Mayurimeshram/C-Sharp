using System;
 namespace s
{
    class Program
    {
        static void display()
        {
            Console.WriteLine("hello");
        }
        static void Main(string[] args)
        {

            display(); //to access static method display instance is not required
        }
    }

}