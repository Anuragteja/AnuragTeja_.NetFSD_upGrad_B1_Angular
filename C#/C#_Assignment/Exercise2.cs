using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnReadingValueFromConsole
{
    internal class Exercise2
    {
        static void Main()
        {
            Console.Write("Enter distance in kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double meters = km * 1000;

            Console.WriteLine("Distance in meters = " + meters);
        }
    }
}
