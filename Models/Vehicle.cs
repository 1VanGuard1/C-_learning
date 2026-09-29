using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpLearning.Models
{
    public abstract class Vehicle
    {
        Engine engine;
        public string Brand { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public int Mileage { get; set; }

        public Vehicle(string brand, string model, int year, int mileage, Engine engine)
        {
            ArgumentException.ThrowIfNullOrEmpty(brand);
            ArgumentException.ThrowIfNullOrEmpty(model);
            ArgumentOutOfRangeException.ThrowIfLessThan(year, 1886);
            ArgumentOutOfRangeException.ThrowIfLessThan(year, 0);
            ArgumentNullException.ThrowIfNull(engine);


            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            this.engine = engine;
        }
        public abstract void StartEngine();
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nYear: {Year}\nMileage: {Mileage}");
        }
        public void Drive(int km)
        {
            if (km < 0)
                throw new ArgumentException();
            Mileage += km;
        }
    }
}

