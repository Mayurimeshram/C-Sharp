using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console


{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[3]; 
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;
            //using for loop 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("arr = " + arr[i]);
            }
            //for each loop
            //syntax foreach (datatype variable in arrayname) 
            foreach (int i in arr)
            {
                Console.WriteLine("arr = " + i);
            }
            Console.ReadLine();

        }
    }
}

