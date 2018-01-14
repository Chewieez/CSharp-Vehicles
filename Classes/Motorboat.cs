using System;
public class Motorboat : IVehicleWater, IVehicleEngine, IWaterDrive
{

    public int PassengerCapacity { get; set; } = 8;
    public double EngineVolume { get; set; } = 2.8;
    public double MaxWaterSpeed { get; set; } = 20.5;

    public void Drive()
    {
        Console.WriteLine($"The motorboat pushed through the waves with the large motors");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
    public Motorboat()
    {
        this.PassengerCapacity = PassengerCapacity;
        this.EngineVolume = EngineVolume;
        this.MaxWaterSpeed = MaxWaterSpeed;
    }

    public Motorboat(int passengerCapacity)
    {
        this.PassengerCapacity = passengerCapacity;
        this.EngineVolume = EngineVolume;
        this.MaxWaterSpeed = MaxWaterSpeed;
    }
    public Motorboat(int passengerCapacity, double engineVolume)
    {
        this.PassengerCapacity = passengerCapacity;
        this.EngineVolume = engineVolume;
        this.MaxWaterSpeed = MaxWaterSpeed;
    }
    public Motorboat(int passengerCapacity, double engineVolume, double maxWaterSpeed)
    {
        this.PassengerCapacity = passengerCapacity;
        this.EngineVolume = engineVolume;
        this.MaxWaterSpeed = maxWaterSpeed;
    }
}
