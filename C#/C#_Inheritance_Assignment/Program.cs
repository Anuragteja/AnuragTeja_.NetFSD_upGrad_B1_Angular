namespace Inheritance_Assignment
{
    public class staff
    {
        public int StaffId { get; set;}
        public string Name { get; set;}
        public int BaseSalary { get; set;}

        public virtual double CalculateSalary()

        {
            return BaseSalary;
        }
    }
    public class Doctor:staff
    {
        public double ConsultationFee { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + ConsultationFee;
        }
    }

    public class Nurse : staff
    {
        public double NightShiftAllowance { get; set;}

        public override double CalculateSalary()
        {
            return NightShiftAllowance + BaseSalary;
        }
    }

    public class LabTechnician : staff
    {
        public double EquipmentAllowance { get; set; }

        public override double CalculateSalary()
        {
            return EquipmentAllowance + BaseSalary;
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Doctor doc = new Doctor
            {
                StaffId = 1,
                Name = "Dr.DOM",
                BaseSalary = 500000,
                ConsultationFee = 100
            };

            Nurse nurse = new Nurse
            {
                StaffId = 2,
                Name = "AA",
                BaseSalary = 30000,
                NightShiftAllowance = 500
            };

            LabTechnician lab = new LabTechnician
            {
                StaffId = 3,
                Name = "BB",
                BaseSalary = 25000,
                EquipmentAllowance = 3000
            };

            Console.WriteLine("Doctor Salary: " + doc.CalculateSalary());
            Console.WriteLine("Nurse Salary: " + nurse.CalculateSalary());
            Console.WriteLine("Lab Technician Salary: " + lab.CalculateSalary());
            Console.WriteLine("Hello, World!");
        }
    }
}
