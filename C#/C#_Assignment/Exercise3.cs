using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnReadingValueFromConsole
{
    internal class Exercise3
    {
        static void Main()
        {
            int n1, n2, n3, n4, n5;

            Console.Write("Enter first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter fifth number: ");
            n5 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2 + n3 + n4 + n5;
            double avg = sum / 5.0;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + avg);
        }
    }
}
