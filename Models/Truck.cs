namespace CSharpLearning.Models
{
    public class Truck : Vehicle, IMaintainable
    {
        public DateOnly LastServiceDate { get; set; }
        public double MaxLoadKg { get; private set; }

        public Truck(string brand, string model, int year, int mileage, double maxLoadKg, Engine engine) : base(brand, model, year, mileage, engine)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(maxLoadKg, 0);
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
