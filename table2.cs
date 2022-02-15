using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        
        static int factorial(int num)
        {
            int fact = 1;

            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            return fact;


        }
        static void Main(string[] args)
        {
            int num = 5;
            int result;
            result = factorial(num);
            Console.WriteLine("fact = {0}", result);
            Console.ReadLine();

        }
    }
}
