namespace CSharpLearning.Models
{
    public class Motorcycle : Vehicle
    {

        public Motorcycle(string brand, string model, int year, int mileage, double engineVolumeLiters, Engine engine, string vin) : base(brand, model, year, mileage, engine, vin)
        {
        }
        public override void StartEngine()
        {
            Console.WriteLine("Врууууууууууу");
        }
        public void GetInfo()
        {
            base.ToString();
        }
    }
}
