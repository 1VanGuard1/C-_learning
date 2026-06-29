using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__learning
{

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
        public double MaxLoadKg
        {
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

}
