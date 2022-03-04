using System;
using System.Collections;
namespace ConsoleApp6
{

    class Program
    {

        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("mayuri");
            ar.Add("mona");
            ar.Add("mayu");
            foreach (object obj in ar)
            {
                Console.WriteLine(" student name" + obj);
            }
        }
    }
}
