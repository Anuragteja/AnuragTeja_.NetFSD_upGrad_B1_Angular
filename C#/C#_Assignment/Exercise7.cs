using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnReadingValueFromConsole
{
    internal class Exercise7
    {
        static void Main()
        {
            Console.Write("Enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter speed: ");
            double speed = Convert.ToDouble(Console.ReadLine());

            double time = distance / speed;

            Console.WriteLine("Time taken = " + time);
        }
    }
}
