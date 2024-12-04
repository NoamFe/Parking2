namespace Parking;

public abstract class Vehicle
{
    public string Make;
    public string Model;
    public int Length;
    public int Weight;
    public int NumberOfWheels;
    public int NumberOfPassengers;
    public abstract VehicleType VehicleType { get; }
}
