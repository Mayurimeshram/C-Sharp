using System;
namespace AccessSpecifiers
{  
 ..       class PrivateTest
    {
        private string name = "Shantosh Kumar";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrivateTest privateTest = new PrivateTest();
            
            Console.WriteLine("Hello " + privateTest.name);
            
            privateTest.Msg("Peter Decosta");
        }
    }
}
