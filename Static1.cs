using System;
 namespace S
{
    class Program
    {
        void display()
        {
            Console.WriteLine("hello");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.display();
        }
    }

}