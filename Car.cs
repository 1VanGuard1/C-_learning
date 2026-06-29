using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__learning;

public class Car : Vehicle, IMaintainable
{
    int _numberOfDoors;
    public int NumberOfDoors
    {
        get => _numberOfDoors;
        set
        {
            if (value < 0)
                throw new ArgumentException();
            _numberOfDoors = value;
        }
    }
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

