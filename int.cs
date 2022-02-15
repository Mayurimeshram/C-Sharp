using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Int

{
    class Program
    {

        public static void Main()

        {
            int b = -25789;
            Console.WriteLine("values" + b);
            Console.WriteLine("enter ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value = " + b);
            //for negative as well as positive no.
            uint b1 = 2389000; //unsigned 
            Console.WriteLine("value " + b1);
            Console.WriteLine("enter ");
            b1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("value = " + b1);


            Console.ReadLine();

        }
    }
}