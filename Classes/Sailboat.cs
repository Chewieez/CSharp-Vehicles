using System;
public class Sailboat : IVehicle, IVehicleWater, IVehicleEngine, IWaterSail, IWaterDrive
{
    public int PassengerCapacity { get; set; } = 8;
    public double EngineVolume { get; set; } = 2.8;
    public double MaxWaterSpeed { get; set; } = 20.5;

    public void Drive()
    {
        Console.WriteLine("The sailboat chugs slowly through the water with it's small engine.");
    }

    public void Sail()
    {
        Console.WriteLine("The sailboat silently cuts through the water like a needle. ");
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
