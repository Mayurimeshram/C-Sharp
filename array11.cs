using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int[,] grid = { { 5, 4, 3 }, { 2, 1, 0 } };


            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t " + grid[i, j]);
                }
                Console.WriteLine();
            }


        }

    }
}
