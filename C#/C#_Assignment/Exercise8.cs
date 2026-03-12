using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnReadingValueFromConsole
{
    internal class Exercise8
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            char ch = char.ToLower(str[2]);

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Third character is Vowel");
            }
            else
            {
                Console.WriteLine("Third character is Consonant");
            }
        }
    }
}
