using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1
{
    internal class MedicalTest
    {
        public int TestId;
        public string TestName;
        public int TestCost;

        // Parameterized Constructor
        public MedicalTest(int id, string name, int cost)
        {
            TestId = id;
            TestName = name;
            TestCost = cost;
        }

        static void Main(string[] args)
        {
            // Creating objects using constructor
            MedicalTest t1 = new MedicalTest(1, "Blood Test", 500);
            MedicalTest t2 = new MedicalTest(2, "X-Ray", 1500);

            Console.WriteLine("Test ID: " + t1.TestId);
            Console.WriteLine("Test Name: " + t1.TestName);
            Console.WriteLine("Test Cost: " + t1.TestCost);

            Console.WriteLine();

            Console.WriteLine("Test ID: " + t2.TestId);
            Console.WriteLine("Test Name: " + t2.TestName);
            Console.WriteLine("Test Cost: " + t2.TestCost);
        }
    }
}
