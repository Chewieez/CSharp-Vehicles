using System;
public class SportsCar : IVehicleLand, IVehicleEngine, IEngineTransmission, IVehicleWheeled
{
    public int Wheels { get; set; } = 4;
    public double EngineVolume { get; set; } = 3.7;
    public string TransmissionType { get; set; } = "Manual";
    public double MaxLandSpeed { get; set; } = 190.0;
    public int PassengerCapacity { get; set; } = 2;

    public void Drive()
    {
        Console.WriteLine("The sports car arrives quickly.");
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
