using System;
public class JetSki : IVehicle, IVehicleWater, IVehicleEngine, IWaterDrive
{
    public int PassengerCapacity { get; set; } = 2;
    public double EngineVolume { get; set; } = 1.1;
    public double MaxWaterSpeed { get; set; } = 30.5;

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
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
