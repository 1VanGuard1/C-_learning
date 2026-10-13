namespace CSharpLearning.Models
{
    internal class Garage
    {
        private readonly List<Vehicle> _vehicles = new List<Vehicle>();

        // чтобы можно было пользоваться списком машин, но не изменять его
        public IReadOnlyList<Vehicle> Vehicles => _vehicles.AsReadOnly();

        public void AddVehicles(Vehicle vehicle)
        {
            if (_vehicles.Any(x => x.VIN == vehicle.VIN))
            {
                throw new InvalidOperationException($"Машина с таким VIN {vehicle.VIN} уже есть в гараже");
            }

            _vehicles.Add(vehicle);
        }
    }
}
