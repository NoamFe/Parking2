namespace Parking;

public class ParkingGarage : ParkingLot
{
    protected List<ParkingSpot> _availableCompactSpots;

    public int CompactCarWeight => 1500;

    public ParkingGarage()
    {
        _availableCompactSpots = _availableSpots.Where(e=>e.MaxWeight <= CompactCarWeight).ToList();
    }
    public override IEnumerable<VehicleType> SupportedVehicleTypes
        => new List<VehicleType> { VehicleType.Motorcycle, VehicleType.Car };

    public override bool IsAvailableToSize(Vehicle vehicle)
    {
        return _availableSpots.Any(e => e.MaxWeight > vehicle.Length);
    }

    public override ParkingSpot AssignParkingSpot(Vehicle vehicle)
    {
        if (IsCompact(vehicle))
        {
            if (_availableCompactSpots.Count > 0)
            {
                var availableCompactSpot = _availableCompactSpots.First();
                _availableCompactSpots.Remove(availableCompactSpot);

                availableCompactSpot.ParkVehicle(vehicle);
                
                _takenSpots.Add(availableCompactSpot);

                return availableCompactSpot;
            }
        }

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

    private bool IsCompact(Vehicle vehicle) => vehicle.Weight <= CompactCarWeight;
}