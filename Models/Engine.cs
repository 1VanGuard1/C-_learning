namespace CSharpLearning.Models
{
    public sealed record class Engine
    {
        public enum FuelType
        {
            Petrol,
            Diesel,
            Electric
        }
        public double Power { get; private set; }

        public double VolumeLiters;
        FuelType Fuel { get; set; }
        public string Type { get; private set; }
        public Engine(double power, string type, FuelType fuelType)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(power);
            ArgumentOutOfRangeException.ThrowIfNegative((int)Fuel);
            ArgumentException.ThrowIfNullOrWhiteSpace(type);

            Power = power;
            Type = type;
            Fuel = fuelType;

        }
    }
}

