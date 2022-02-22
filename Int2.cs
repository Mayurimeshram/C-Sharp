using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class person
    {
        public string name;
        public string address;
    }
    public class student: person
    {
        public int rollno;
        public int masks;
    }
    class Testinheritance
    {
        public static void Main(string[] args)
        {
            student p1 = new student();
            p1.rollno = 129;
            p1.name = "Mayuri";
            p1.address = "Mansar";
            p1.masks = 88;

            Console.WriteLine("rollno:" + p1.rollno);
            Console.WriteLine("name:" + p1.name);
            Console.WriteLine("address:" + p1.address);
            Console.WriteLine("masks:" + p1.masks);

        }
    }
}