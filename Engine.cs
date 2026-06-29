using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

