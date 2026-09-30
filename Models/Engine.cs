namespace CSharpLearning.Models
{
    public class Engine
    {
        public double Power { get; private set; }
        public string Type { get; private set; }
        public Engine(double power, string type)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(power);
            ArgumentException.ThrowIfNullOrWhiteSpace(type);

            Power = power;
            Type = type;
        }
    }
}

