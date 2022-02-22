using System;
namespace AccessSpecifies
{
    class ProtectedTest
    {
        protected string name = "mayuri";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);

        }

    }
       class Program:ProtectedTest
    {
        static void Main (string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Hello" + program.name);
            program.Msg("Mayuri");



        }
            
    }
}