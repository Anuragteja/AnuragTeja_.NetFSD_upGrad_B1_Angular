using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1
{
    internal class Hospital
    {
        public static string HospitalName;
        public static string HospitalAddress;
        public string PatientName;

        public void display()
        {
            Console.WriteLine($"{HospitalName} Hospital where is {HospitalAddress} patientName {PatientName}"); 
        }
        static void Main(string[] args)
        {
            Hospital H1 = new Hospital();
            H1.display();
            Hospital.HospitalName = "Eyeee";
            Hospital.HospitalAddress = "hyd";
            Hospital H2 = new Hospital() { PatientName="anurag"};
            H2.display();
            Hospital.HospitalName = "Hey";
            Hospital.HospitalAddress = "TS";
            Hospital H3 = new Hospital();
            H3.display();
        }

    }
}
