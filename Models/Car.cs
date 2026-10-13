using System.Text;

namespace CSharpLearning.Models
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; private set; }

        public Car(string brand, string model, int year, int mileage, int numberOfDoors, Engine engine, string vin) : base(brand, model, year, mileage, engine, vin)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(numberOfDoors, 0);

            NumberOfDoors = numberOfDoors;         
        }
        public override void StartEngine()
        {
            Console.WriteLine("Врум-врум");
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(base.ToString());
            info.AppendLine($"NumberOfDoors: {NumberOfDoors}");
            return info.ToString();
        }
    }
}

