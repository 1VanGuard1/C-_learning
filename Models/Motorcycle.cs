namespace CSharpLearning.Models
{
    public class Motorcycle : Vehicle, IMaintainable
    {
        public DateOnly LastServiceDate { get; set; }
        public double EngineVolumeLiters { get; private set; }

        public Motorcycle(string brand, string model, int year, int mileage, double engineVolumeLiters, Engine engine) : base(brand, model, year, mileage, engine)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(engineVolumeLiters, 0);

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
}
