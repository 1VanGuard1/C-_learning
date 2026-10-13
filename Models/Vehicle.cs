namespace CSharpLearning.Models
{
    public abstract class Vehicle : IMaintainable
    {

        Engine engine;
        public string Brand { get; private set; }
        public string Model { get; private set; }

        public int Year { get; private set; }
        public int Mileage { get; private set; }
        public string VIN {  get; }
        public DateOnly LastServiceDate { get; set; }

        protected Vehicle(string brand, string model, int year, int mileage, Engine engine, String vin)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(brand);
            ArgumentException.ThrowIfNullOrWhiteSpace(model);
            ArgumentOutOfRangeException.ThrowIfLessThan(year, 1886);
            ArgumentOutOfRangeException.ThrowIfLessThan(mileage, 0);
            ArgumentNullException.ThrowIfNull(engine);
            

            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            this.engine = engine;

            if (vin.Length != 17)
                throw new ArgumentException("Неверная длинна VIN", nameof(vin));
            VIN = vin.ToUpper();
        }
        public abstract void StartEngine();
        public override string ToString()
        {
            return ($"Brand: {Brand}\nModel: {Model}\nYear: {Year}\nMileage: {Mileage}");
        }
        public void Drive(int km)
        {
            if (km < 0)
                throw new ArgumentException();
            Mileage += km;
        }

        public void PerformMaintenance()
        {
            LastServiceDate = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine("ТО для автомобиля выполнена");
        }
    }
}


