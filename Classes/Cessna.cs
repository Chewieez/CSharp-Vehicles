using System;
public class Cessna : IVehicleAir, IVehicleDoors, IVehicleEngine, IVehicleWheeled
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
