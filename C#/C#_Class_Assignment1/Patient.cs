using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1
{
    internal class Patient
    {
        public int Patientid;
        public string Name;
        public byte age;
        public string Disease;

        static void Main()
        {
            Patient p = new Patient();
            p.Patientid = 1;
            p.Name = "Anurag";
            p.age = 53;
            p.Disease = "Cold";
            Console.WriteLine(p.Name+""+p.age+""+p.Disease+""+p.Patientid);
        }

    }
}
