using System;

namespace Inheritance_Assignment
{
    public class Vehicle
    {
        public int VehicleNumber { get; set; }
        public string Brand { get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle started");
        }
    }

    public class Car : Vehicle
    {
        public string FuelType { get; set; }
    }

    public class Bike : Car
    {

    }

    public sealed class ElectricCar : Car
    {

    }
    /*
    public class Tesla : ElectricCar
    {
    }
    */

    internal class Vehicle_Management_System
    {
        static void Main()
        {
            Car car = new Car()
            {
                VehicleNumber = 101,
                Brand = "Toyota",
                FuelType = "Petrol"
            };

            car.StartVehicle();
            Console.WriteLine($"Car Brand: {car.Brand}, Fuel: {car.FuelType}");

            Bike bike = new Bike()
            {
                VehicleNumber = 202,
                Brand = "Yamaha",
                FuelType = "Petrol"
            };

            bike.StartVehicle();
            Console.WriteLine($"Bike Brand: {bike.Brand}");

            ElectricCar eCar = new ElectricCar()
            {
                VehicleNumber = 303,
                Brand = "Tesla",
                FuelType = "Electric"
            };

            eCar.StartVehicle();
            Console.WriteLine($"Electric Car Brand: {eCar.Brand}, Fuel: {eCar.FuelType}");

            // ❌ Not allowed (uncomment to see error)
            // Tesla t = new Tesla();
        }
    }
}