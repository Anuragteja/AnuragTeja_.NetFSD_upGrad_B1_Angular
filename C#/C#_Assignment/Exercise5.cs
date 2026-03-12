using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnReadingValueFromConsole
{
    internal class Exercise5
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is highest");
            }
            else
            {
                Console.WriteLine(num2 + " is highest");
            }
        }
    }
}
