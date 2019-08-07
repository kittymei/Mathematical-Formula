using System;

namespace homework
{
    class Program
    {
        static void areaOfCircle()
        {
            double radius = 5;
            double area = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);
        }
        static void cicrumOfCircle()
        {
            double radius = 2;
            double circum = 2 * Math.PI * radius;
            Console.WriteLine("The circumference of the circle is: " + circum);
        }
        static void volumeOfHemisphere()
        {
            double radius = 3;
            double volume = ((4 / 3) * Math.PI * radius * radius * radius) / (2);
            Console.WriteLine("The volume of the hemisphere is: " + volume);
        }
        static void areaOfTriangle()
        {
            double a = 5;
            double b = 7;
            double c = 5;

            double p = ((a + b + c) / 2);
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("The area of the triangle is: " + area);
        }

        static void Main(string[] args)
        {
            areaOfCircle();
            cicrumOfCircle();
            volumeOfHemisphere();
            areaOfTriangle();
            Console.ReadLine();

        }
    }
}

