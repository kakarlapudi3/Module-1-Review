// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;

namespace IterationStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of the circle?");
            string radius = Console.ReadLine();
            double rad = double.Parse(radius);
            Circle(rad);

            Console.WriteLine("What is the length and height of the rectangle?");
            string length = Console.ReadLine();
            string ht = Console.ReadLine();
            double baseLength = double.Parse(length);
            double height = double.Parse(ht);
            Triangle(baseLength, height);

            Console.WriteLine("What is the length and width of the rectangle?");
            string lgth = Console.ReadLine();
            string wd = Console.ReadLine();
            double l = double.Parse(lgth);
            double width = double.Parse(wd);
            Rectangle(l, width);

            Console.WriteLine("What is the side of the square?");
            string sd = Console.ReadLine();
            double side = double.Parse(sd);
            Square(side);

        }
        public static double Circle(double radius)
        {
            double area = Math.PI * (radius * radius);
            return area;
        }

        //triangle area method
        public static double Triangle(double baseLength, double height)
        {
            double triArea = 0.5 * baseLength * height;
            return triArea;
        }
        //rectangle area method
        public static double Rectangle(double length, double width)
        {
            double recArea = length * width;
            return recArea;
        }

        //square method
        public static double Square(double side)
        {
            double sqArea = side * side;
            return sqArea;
        }

           
       

    }
}