using System;
public class HangGlider : IVehicle, IVehicleAir
{
    public double MaxAirSpeed { get; set; } = 8;
    public int PassengerCapacity { get; set; } = 2;

    public void Fly()
    {
        Console.WriteLine("The hang glider glides effortlessly through the air on the winds.");
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
