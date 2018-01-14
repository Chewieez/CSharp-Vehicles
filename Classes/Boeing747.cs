using System;
public class Boeing747 : IVehicle, IVehicleAir, IVehicleEngine, IVehicleWheeled, IVehicleDoors
{
    public int Wheels { get; set; } = 10;
    public double EngineVolume { get; set; } = 4.2;
    public double MaxAirSpeed { get; set; } = 600.0;
    public int PassengerCapacity { get; set; } = 524;
    public int Doors { get; set; } = 8;

    public void Fly()
    {
        Console.WriteLine("The Boeing747 cruises through the air carrying a crowd in style.");
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
