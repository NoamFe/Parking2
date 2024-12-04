namespace Parking;

public class ParkingLot
{
    protected List<ParkingSpot> _takenSpots;
    protected List<ParkingSpot> _availableSpots;

    public bool CanPark(Vehicle vehicle)
    {
        if (!SupportedVehicleTypes.Contains(vehicle.VehicleType))
            return false;

        return IsAvailableToSize(vehicle);
    }

    public ParkingSpot ParkVehicle(Vehicle vehicle)
    {
        if (_availableSpots.Count > 0)
        {
            var spot = _availableSpots.First();
            _availableSpots.Remove(spot);

            spot.ParkVehicle(vehicle);

            _takenSpots.Add(spot);
            return spot;
        }

        return null;
    }

    public virtual ParkingSpot AssignParkingSpot(Vehicle vehicle) => _availableSpots.First();


    public virtual bool IsAvailableToSize(Vehicle vehicle) => _availableSpots.Any();

    public virtual IEnumerable<VehicleType> SupportedVehicleTypes
        => new List<VehicleType> { VehicleType.Motorcycle, VehicleType.Car, VehicleType.Bus };
}
