using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1
{
    internal class Doctor
    {
        public int DoctorId;
        public string DoctorName;
        public string Specialization;
        public int ConsultationFee;

        static void Main(string[] args)
        {
            Doctor d1 = new Doctor();
            Doctor d2 = new Doctor();
            d1.DoctorId = 101;
            d1.DoctorName = "ANURAG";
            d1.Specialization = "ENT";
            d1.ConsultationFee = 4000;
            Console.WriteLine(d1.DoctorId + " " + d1.DoctorName + " " + d1.Specialization + " " + d1.ConsultationFee);

            d2.DoctorId = 202;
            d2.DoctorName = "Teja";
            d2.Specialization = "Eyes";
            d2.ConsultationFee = 9000;
            Console.WriteLine(d2.DoctorId + " " + d2.DoctorName + " " + d2.Specialization + " " + d2.ConsultationFee);

        }
    }
}
