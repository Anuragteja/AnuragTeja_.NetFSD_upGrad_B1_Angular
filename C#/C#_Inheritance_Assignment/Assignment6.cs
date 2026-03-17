using System;

namespace Inheritance_Assignment
{
    public class Furniture
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public double TotalAmt { get; set; }
        public string PaymentMode { get; set; }

        public virtual void GetData()
        {
            Console.WriteLine("Enter Order Id:");
            OrderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order Date (yyyy-mm-dd):");
            OrderDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            Qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Payment Mode (Credit/Debit):");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"OrderId: {OrderId}");
            Console.WriteLine($"OrderDate: {OrderDate.ToShortDateString()}");
            Console.WriteLine($"FurnitureType: {FurnitureType}");
            Console.WriteLine($"Qty: {Qty}");
            Console.WriteLine($"PaymentMode: {PaymentMode}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
        }
    }

    public class Chair : Furniture
    {
        public string ChairType { get; set; }
        public string Purpose { get; set; }
        public string MaterialType { get; set; }
        public double Rate { get; set; }

        public override void GetData()
        {
            FurnitureType = "Chair";
            base.GetData();

            Console.WriteLine("Enter Chair Type (Wood/Steel/Plastic):");
            ChairType = Console.ReadLine();

            Console.WriteLine("Enter Purpose (Home/Office):");
            Purpose = Console.ReadLine();

            if (ChairType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Wood Type (Teak Wood/Rose Wood):");
                MaterialType = Console.ReadLine();
            }
            else if (ChairType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Steel Type (Gray/Green/Brown):");
                MaterialType = Console.ReadLine();
            }
            else if (ChairType.Equals("Plastic", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Color (Green/Red/Blue/White):");
                MaterialType = Console.ReadLine();
            }

            Console.WriteLine("Enter Rate:");
            Rate = double.Parse(Console.ReadLine());

            TotalAmt = Qty * Rate;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"ChairType: {ChairType}");
            Console.WriteLine($"Purpose: {Purpose}");
            Console.WriteLine($"MaterialType: {MaterialType}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }

    public class Cot : Furniture
    {
        public string CotType { get; set; }
        public string MaterialType { get; set; }
        public string Capacity { get; set; }
        public double Rate { get; set; }

        public override void GetData()
        {
            FurnitureType = "Cot";
            base.GetData();

            Console.WriteLine("Enter Cot Type (Wood/Steel):");
            CotType = Console.ReadLine();

            if (CotType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Wood Type (Teak Wood/Rose Wood):");
                MaterialType = Console.ReadLine();
            }
            else if (CotType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Steel Type (Gray/Green/Brown):");
                MaterialType = Console.ReadLine();
            }

            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = Console.ReadLine();

            Console.WriteLine("Enter Rate:");
            Rate = double.Parse(Console.ReadLine());

            TotalAmt = Qty * Rate;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"CotType: {CotType}");
            Console.WriteLine($"MaterialType: {MaterialType}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }

    internal class Assignment6
    {
        static void Main()
        {
            Console.WriteLine("Enter Furniture Type (Chair/Cot):");
            string choice = Console.ReadLine();

            Furniture obj;

            if (choice.Equals("Chair", StringComparison.OrdinalIgnoreCase))
            {
                obj = new Chair();
            }
            else
            {
                obj = new Cot();
            }

            obj.GetData();
            obj.ShowData();
        }
    }
}