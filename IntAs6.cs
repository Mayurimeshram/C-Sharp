using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Person
    {
        string name;
        string address;
        public void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
                
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address:" + address);
                

        }
    }

    public class Employee :Person
    {
        int empno;
        int salary;
        public void getEmployeeData(int empno, int salary)
        {
            this.empno = empno;
            this.salary= salary;
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("empno : " + empno);
            Console.WriteLine("salary : " + salary);

        }
    }
   class TestInheritance
 
        public static void Main(string[] args)
    {
        Employee p1 = new Employee();
        p1.getPersonData("Mayuri", "nagpur");
        p1.getEmployeeData(1, 999);
        p1.displayEmployeeData();
        p1.displayPersonData();

    }


}





