using System;

namespace C__learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(500, "v12");
            Car car = new Car("VW", "Golf mk4", 2000, 15000, 5, engine);
            car.PerformMaintenance();
            car.Drive(15);

            Truck truck = new Truck("Mercedes", "2", 2000, 15000, 5000, engine);
            Motorcycle motorcycle  = new Motorcycle("Yamaha", "3", 2000, 15000, 0.8, engine);
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