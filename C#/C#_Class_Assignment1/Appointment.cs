using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment_1
{
    internal class Appointment
    {
        public int AppointmentId;
        public string PatientName;
        public string DoctorName;
        public DateTime AppointmentDate;

        // Default Constructor
        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Today;
        }

        static void Main(string[] args)
        {
            Appointment a = new Appointment();

            a.AppointmentId = 1;
            a.PatientName = "Anurag";

            Console.WriteLine("Appointment ID: " + a.AppointmentId);
            Console.WriteLine("Patient Name: " + a.PatientName);
            Console.WriteLine("Doctor Name: " + a.DoctorName);
            Console.WriteLine("Appointment Date: " + a.AppointmentDate.ToShortDateString());
        }
    }
}
