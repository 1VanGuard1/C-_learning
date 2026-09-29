namespace CSharpLearning.Models
{
    public class Car : Vehicle, IMaintainable
    {
        public int NumberOfDoors { get; set; }
        public DateOnly LastServiceDate { get; set; }


        public Car(string brand, string model, int year, int mileage, int numberOfDoors, Engine engine) : base(brand, model, year, mileage, engine)
        {
            ArgumentException.ThrowIfNullOrEmpty(brand);
            ArgumentException.ThrowIfNullOrEmpty(model);
            ArgumentOutOfRangeException.ThrowIfLessThan(year, 1886);
            ArgumentOutOfRangeException.ThrowIfLessThan(mileage, 0);
            ArgumentOutOfRangeException.ThrowIfLessThan(numberOfDoors, 0);
            ArgumentNullException.ThrowIfNull(engine);

            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
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
}

