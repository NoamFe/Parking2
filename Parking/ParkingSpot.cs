namespace Parking;

public class ParkingSpot
{
    public int Number;
    private Vehicle _parkedVehicle;

    public bool ParkVehicle(Vehicle vehicle)
    {
        if (_parkedVehicle != null)
        {
            //Log.Error("Spot is taken");
            return false;
        }

        if (this.MaxWeight < vehicle.Weight)
        {
            //Log.Error("invalid vehicle weight for spot");
            return false;
        }
        _parkedVehicle = vehicle;

        return true;
    }

    public bool IsFree => _parkedVehicle == null;

    public int MaxWeight;
}
