namespace CSharpLearning.Models
{
    internal class Garage
    {
        private readonly List<Vehicle> _vehicles;

        public void AddVehicles(Vehicle vehicle)
        {
            if (_vehicles.GroupBy(x => x.VIN).Any(group => group.Count() < 1))
            {
                _vehicles.Add(vehicle);
            }
        }
    }
}
