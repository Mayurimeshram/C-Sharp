using System;
namespace AccessSpeciFiers
{
    class InternalTest
    {
        internal string name = "Mayuri";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
       class Program
    {
        static void Main(string[] args)
        {
            InternalTest internalTest = new InternalTest();
            Console.WriteLine("Hello" + internalTest.name);
            internalTest.Msg("Mona");


        }
            
    }
}
