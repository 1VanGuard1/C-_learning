namespace CSharpLearning.Models
{
    public abstract class Vehicle
    {
        Engine engine;
        public string Brand { get; private set; }
        public string Model { get; private set; }

        public int Year { get; private set; }
        public int Mileage { get; private set; }

        public Vehicle(string brand, string model, int year, int mileage, Engine engine)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(brand);
            ArgumentException.ThrowIfNullOrWhiteSpace(model);
            ArgumentOutOfRangeException.ThrowIfLessThan(year, 1886);
            ArgumentOutOfRangeException.ThrowIfLessThan(mileage, 0);
            ArgumentNullException.ThrowIfNull(engine);


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
}

