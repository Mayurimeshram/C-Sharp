using System;
namespace AccessSpecifiers
{
    class PublicTest
    {
        public String name = "Mayuri Meshram";
        public void msg(String msg)
        {
            Console.WriteLine("Hello " + msg);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicTest publicTest = new PublicTest();

            //Accesing Public Variable
            Console.WriteLine("Hello" + publicTest. name);
                     //Acessing Public Function
                  publicTest.msg("PeterDecosta");
        }
    }
}

