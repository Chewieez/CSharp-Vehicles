using System;
public class SportUtilityVehicle : IVehicle, IVehicleLand, IVehicleEngine, IVehicleWheeled, IEngineTransmission
{
    public int Wheels { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 8;
    public string TransmissionType { get; set; } = "Automatic";
    public double EngineVolume { get; set; } = 4.1;
    public double MaxLandSpeed { get; set; } = 110.2;

    public void Drive()
    {
        Console.WriteLine("The Sport Utility Vehicle crawls over the most extreme terrain.");
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
