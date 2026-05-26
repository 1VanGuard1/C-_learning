using System;

namespace C__learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("VW", "Golf mk4", 2000, 15000, 5);
            car.PerformMaintenance();
            car.Drive(15);

            Truck truck = new Truck("Mercedes", "2", 2000, 15000, 5000);
            Motorcycle motorcycle  = new Motorcycle("Yamaha", "3", 2000, 15000, 0.8);
            List<Vehicle> list = [car, truck, motorcycle];

            foreach (Vehicle vehicle in list)
            {
                vehicle.GetInfo();
                vehicle.StartEngine();
                Console.WriteLine();
            }
        }
    }
}