using CSharpLearning.Models;
using System;

namespace CSharpLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string VIN = new string("12345678901234567");
            string VIN1 = new string("12345678901234568");
            string VIN2 = new string("12345678901234562");
            Engine engine = new Engine(500, "v12", Engine.FuelType.Electric);
            Car car = new Car("VW", "Golf mk4", 2000, 15000, 5, engine, VIN);
            car.PerformMaintenance();
            car.Drive(15);

            Truck truck = new Truck("Mercedes", "2", 2000, 15000, 5000, engine, VIN1);
            Motorcycle motorcycle  = new Motorcycle("Yamaha", "3", 2000, 15000, 0.8, engine, VIN2);
            List<Vehicle> list = [car, truck, motorcycle];

            foreach (Vehicle vehicle in list)
            {
                
                vehicle.StartEngine();
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}