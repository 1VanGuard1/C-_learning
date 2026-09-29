namespace CSharpLearning.Models
{
    public class Engine
    {
        public double Power { get; set; }
        public string Type { get; set; }
        public Engine(double power, string type)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(power, 0);
            ArgumentException.ThrowIfNullOrEmpty(type);

            Power = power;
            Type = type;
        }
    }
}

