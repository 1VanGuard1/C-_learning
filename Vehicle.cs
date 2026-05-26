using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__learning
{
    public interface IMaintainable
    {
        DateOnly LastServiceDate { get; set; }
        void PerformMaintenance();
    }
    public abstract class Vehicle
    {
        Engine engine;
        string _brand;
        public string Brand { 
            get => _brand;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException();
                _brand = value;
            }
        }
        string _model;
        public string Model{
            get => _model;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException();
                _model = value;
            }
        }
        int _year;
        public int Year { 
            get => _year;
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _year = value;
            }
        }
        int _mileage;
        public int Mileage {
            get => _mileage;
            private set
            {
                if (value < 0)
                    throw new ArgumentException();
                _mileage = value;
            }
        }

        public Vehicle(string brand, string model, int year, int mileage, Engine engine)
        {
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

    public class Car : Vehicle, IMaintainable
    {
        int _numberOfDoors;
        public int NumberOfDoors{
            get => _numberOfDoors;
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _numberOfDoors = value;
            }
        }
        DateOnly _lastServiceDate;
        public DateOnly LastServiceDate {
            get => _lastServiceDate;
            set
            {
                if (value.ToString().Length == 0)
                    throw new ArgumentException();
                _lastServiceDate = value;
            }
        }


        public Car(string brand, string model, int year, int mileage, int numberOfDoors, Engine engine) : base(brand, model, year, mileage, engine) 
        {
            NumberOfDoors = numberOfDoors;
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
        }
        public override void StartEngine()
        {
            Console.WriteLine("Врум-врум");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"NumberOfDoors: {NumberOfDoors}");
        }
        public void PerformMaintenance()
        {
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("ТО для автомобиля выполнена");
        }
    }
    public class Truck : Vehicle, IMaintainable
    {
        DateOnly _lastServiceDate;
        public DateOnly LastServiceDate
        {
            get => _lastServiceDate;
            set
            {
                if (value.ToString().Length == 0)
                    throw new ArgumentException();
                _lastServiceDate = value;
            }
        }
        double _maxLoadKg;
        public double MaxLoadKg { 
            get => _maxLoadKg;
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _maxLoadKg = value;
            }
        }

        public Truck(string brand, string model, int year, int mileage, double maxLoadKg, Engine engine) : base(brand, model, year, mileage, engine)
        {
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            MaxLoadKg = maxLoadKg;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Тру-ту-ту");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"MaxLoadKg: {MaxLoadKg}");
        }
        public void PerformMaintenance()
        {
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("ТО для грузовика выполнена");
        }
    }
    public class Motorcycle : Vehicle, IMaintainable
    {
        DateOnly _lastServiceDate;
        public DateOnly LastServiceDate
        {
            get => _lastServiceDate;
            set
            {
                if (value.ToString().Length == 0)
                    throw new ArgumentException();
                _lastServiceDate = value;
            }
        }
        double _engineVolumeLiters;
        public double EngineVolumeLiters {
            get => _engineVolumeLiters;
            set
            {
                if (value < 0)
                    throw new ArgumentException();
            }
        }

        public Motorcycle(string brand, string model, int year, int mileage, double engineVolumeLiters, Engine engine) : base(brand, model, year, mileage, engine)
        {
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            EngineVolumeLiters = engineVolumeLiters;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Врууууууууууу");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"EngineVolumeLiters: {EngineVolumeLiters}");
        }
        public void PerformMaintenance()
        {
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("ТО для мотоцикла выполнена");
        }
    }

    public class Engine
    {
        double _power;
        string _type;
        public double Power
        {
            get => _power;
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _power = value;
            }
        }
        public string Type
        {
            get => _type;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();
                _type = value;
            }
        }
        public Engine(double power, string type)
        {
            Power = power;
            Type = type;
        }
    }
}
