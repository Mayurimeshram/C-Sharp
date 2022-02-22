using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Person
    {
        public String name;
        public String address;
    }
    public class Employee : Person

    {
        public int Empno;
        public int Salary;
        public string Designation;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Employee p1 = new Employee();
            p1.name= "mayuri";
            p1.Empno = 11;
            p1.address= "mumbai";

            p1.Salary = 888;
            p1.Designation = "Officers";

            Console.WriteLine("name: " + p1.name);
            Console.WriteLine("Empno:"  + p1.Empno);
            Console.WriteLine("address: " + p1.address);
            Console.WriteLine("Salary: " + p1.Salary);
            Console.WriteLine("Designation:" + p1.Designation);

        }
    }

}
