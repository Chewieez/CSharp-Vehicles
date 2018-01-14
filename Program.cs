using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{

    public static void Main()
    {
        // create some vehicles using the vehicle classes
        JetSki StriperJetSki = new JetSki();
        Motorboat LargeMotorboat = new Motorboat(12);
        Motorboat FastMotorboat = new Motorboat(8, 6.1);
        Sailboat LumberingSailBoat = new Sailboat();
        Motorcycle ZippyMotorcycle = new Motorcycle();
        SportsCar LeMansSportsCar = new SportsCar();
        SportUtilityVehicle Rover = new SportUtilityVehicle();
        Cessna TravelingCessna = new Cessna();
        Boeing747 AirFrance = new Boeing747();
        HangGlider SeeingBrazil = new HangGlider();


        // Build a collection of all vehicles that fly
        List<IVehicleAir> flyingVehicles = new List<IVehicleAir>()
        {
            TravelingCessna,
            AirFrance,
            SeeingBrazil
        };

        // With a single `foreach`, have each vehicle Fly()
        foreach (IVehicleAir vehicle in flyingVehicles)
        {
            vehicle.Fly();
        }


        // Build a collection of all vehicles that operate on roads
        List<IVehicleLand> landVehicles = new List<IVehicleLand>()
        {
            ZippyMotorcycle,
            LeMansSportsCar,
            Rover
        };

        // With a single `foreach`, have each road vehicle Drive()
        foreach (IVehicleLand vehicle in landVehicles)
        {
            vehicle.Drive();
        }


        // Build a collection of all vehicles that operate on water
        List<IWaterDrive> waterVehicles = new List<IWaterDrive>()
        {
            StriperJetSki,
            LumberingSailBoat,
            LargeMotorboat,
            FastMotorboat
        };

        // With a single `foreach`, have each water vehicle Drive()
        foreach (IWaterDrive vehicle in waterVehicles)
        {
            vehicle.Drive();
        }

        // check to see if my overloaded constructor functions for the Motorboat class work
        Console.WriteLine($"LargeMotorboat passenger capacity: {LargeMotorboat.PassengerCapacity}");
        Console.WriteLine($"FastMotorboat Passenger Capacity: {FastMotorboat.PassengerCapacity} Engine Volume: {FastMotorboat.EngineVolume}");

    }

}
