using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class circle
    {
        float radius;
        float area;
        float circle;
        public void areaa(float radius)
        {
            area = 3.14f * radius * radius;

        }
        public void disarea()
        {
            Console.WriteLine("area of circle" + area);
        }
        public void circumference(float radius)
            
            
        {
            circle = 2 * 3.14f * radius;
        }
        public void discircum()
        {
            Console.WriteLine("area of circumfernce" + circle);
        }
    }
    class circle1
    {
        static void main()
        {
            circle c = new circle();
            Console.WriteLine("enter radius");
            float radius = Convert.ToSingle(Console.ReadLine());


            c = area(r);
            c = disarea();
            c = circumference(r);
            c = discircum();

        }
    }
}
