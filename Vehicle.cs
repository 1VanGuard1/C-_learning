using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicle
{
    Engine engine;
    string _brand;
    public string Brand
    {
        get => _brand;
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException();
            _brand = value;
        }
    }
    string _model;
    public string Model
    {
        get => _model;
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException();
            _model = value;
        }
    }
    int _year;
    public int Year
    {
        get => _year;
        set
        {
            if (value < 0)
                throw new ArgumentException();
            _year = value;
        }
    }
    int _mileage;
    public int Mileage
    {
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

