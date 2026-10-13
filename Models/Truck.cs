using System.Text;

namespace CSharpLearning.Models
{
    public class Truck : Vehicle, IMaintainable
    {
        public DateOnly LastServiceDate { get; set; }
        public double MaxLoadKg { get; private set; }

        public Truck(string brand, string model, int year, int mileage, double maxLoadKg, Engine engine, string vin) : base(brand, model, year, mileage, engine, vin)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(maxLoadKg, 0);
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            MaxLoadKg = maxLoadKg;
        }
        public override void StartEngine()
        {
            Console.WriteLine("Тру-ту-ту");
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(base.ToString());
            info.AppendLine($"MaxLoadKg: {MaxLoadKg}");
            return info.ToString();
        }
        public void PerformMaintenance()
        {
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("ТО для грузовика выполнена");
        }
    }

}
