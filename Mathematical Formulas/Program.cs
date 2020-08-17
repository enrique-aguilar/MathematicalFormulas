using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Mathematical_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            areaCircumference();
            volumeHemisphere();
            areaOfTriangle();
            quadraticEquation();
            Console.ReadLine();
        }
        private static void areaCircumference()
        {
            double circumference, area, r;

            Console.WriteLine("Please enter the radius of your circle");
            r = Double.Parse(Console.ReadLine());

            circumference = 2 * Math.PI * r;
            Console.WriteLine("\n" + "This is the circumference of your circle");
            Console.WriteLine(circumference);

            area = Math.PI * (r * r);
            Console.WriteLine("This is the area of your circle");
            Console.WriteLine(area + "\n" + "\n");

        }
        private static void volumeHemisphere()
        {
            double r, answer,a, b, c, d, e;
            Console.WriteLine("Please enter the radius of your hemisphere");
            r = Double.Parse(Console.ReadLine());

            a = 1.3;
            b = Math.PI;
            c = 2;
            d = r * r * r;

            e = a * b * d;
            answer = e / 2;


            Console.WriteLine("\n" + "This is the volume of your hemisphere");
            Console.WriteLine(answer + "\n" + "\n");
        }
        private static void areaOfTriangle()
        {
            double a, b, c, p, answer;
            Console.WriteLine("Please enter the value of side A for your triangle");
            a = uint.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value of side B for your triangle");
            b = uint.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value of side C for your triangle");
            c = uint.Parse(Console.ReadLine());

            p = (a + b + c) / 2;

            answer = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("\n" + "This is the area of your triangle");
            Console.WriteLine(answer + "\n" + "\n");
        }
        private static void quadraticEquation()
        {
            int a, b, b1, c, p1, p2, p3, p4, p5, p6;
            Console.WriteLine("Please enter the value of a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value of b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value of c");
            c = int.Parse(Console.ReadLine());

            if (b < 0) { b1 = Math.Abs(b); }

            else b1 = (b * (-1));

            p1 = (b1);
            p2 = (b * b);
            p3 = (4 * a * c);
            p4 = (2 * a);
            p5 = Math.Abs(p2 - p3);
            p6 = (int)Math.Sqrt(p5);

            double preanswer1 = (p1 + p6);
            double preanswer2 = (p1 - p6);
            double answer1 = (preanswer1 / p4);
            double answer2 = preanswer2 / p4;

            Console.WriteLine("\n" + $"first answer \n {answer1}");
            Console.WriteLine($"second answer \n {answer2}");
        }
    }
}
    

    

