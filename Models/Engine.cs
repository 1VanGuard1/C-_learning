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
        public double VolumeLiters { get; }
        FuelType Fuel { get; set; }
        public string Type { get; private set; }
        public Engine(double power,double volumeLiters, string type, FuelType fuelType)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(power);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(volumeLiters);
            ArgumentOutOfRangeException.ThrowIfNegative((int)fuelType);
            ArgumentException.ThrowIfNullOrWhiteSpace(type);

            VolumeLiters = volumeLiters;
            Power = power;
            Type = type;
            Fuel = fuelType;

        }
    }
}

