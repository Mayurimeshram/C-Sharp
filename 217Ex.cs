using System;
namespace AccessSpecifiers
{
    class Program
    {
        private string name = "Mayuri";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            
            Console.WriteLine("Hello " + program.name);
           
            program.Msg("Mona");
        }
    }
}
