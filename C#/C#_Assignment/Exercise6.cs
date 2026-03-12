using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnReadingValueFromConsole
{
    internal class Exercise6
    {
        static void Main()
        {
            // Rectangle
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double rectangleArea = length * width;
            Console.WriteLine("Area of Rectangle = " + rectangleArea);

            // Square
            Console.Write("Enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double squareArea = side * side;
            Console.WriteLine("Area of Square = " + squareArea);
        }
    }
}
