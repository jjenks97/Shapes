using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static int NumberOfIncorrectChecks = 0;

        static void Main(string[] args)
        {
            TestTriangle();
            TestRightTriangle();


            Console.WriteLine($"Number of Incorrect Checks: { NumberOfIncorrectChecks}");

            Console.ReadKey();
        }

        static void TestTriangle()
        {

            Triangle t = new Triangle(3, 4, 5, 0, 5);
            Console.WriteLine(t);
            Console.WriteLine("Area: " + t.Area);
            Check(t.Area, 6);

            Console.WriteLine("Perimeter: " + t.Perimeter);
            Check(t.Perimeter, 12);

            Triangle t2 = new Triangle(4, 5, 6);
            Console.WriteLine(t2);
            Console.WriteLine("Area: " + t2.Area);
            Check(t2.Area, 9.921567);
            Console.WriteLine("Perimeter: " + t2.Perimeter);
            Check(t2.Perimeter, 15);

        }

        static void TestRightTriangle()
        {

            RightTriangle t = new RightTriangle(3, 4);
            Console.WriteLine(t);
            Console.WriteLine("Area: " + t.Area);
            Check(t.Area, 6);

            Console.WriteLine("Perimeter: " + t.Perimeter);
            Check(t.Perimeter, 12);

            Triangle t2 = new Triangle(4, 5, 6);
            Console.WriteLine(t2);
            Console.WriteLine("Area: " + t2.Area);
            Check(t2.Area, 9.921567);
            Console.WriteLine("Perimeter: " + t2.Perimeter);
            Check(t2.Perimeter, 15);

        }


        static void Check(double actual, double expected)
        {
            if (Math.Abs(actual - expected) > 0.001)
            {
                NumberOfIncorrectChecks++;
            }
        }
    }
}