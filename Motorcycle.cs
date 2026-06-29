using C__learning;
using System;

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
    public double EngineVolumeLiters
    {
        get => _engineVolumeLiters;
        set
        {
            if (value < 0)
                throw new ArgumentException();

            _engineVolumeLiters = value;
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
