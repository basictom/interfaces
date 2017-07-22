using System;

namespace interfaces
{
    public class Cessna : IAir
    {
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 31.1;
    public double MaxSpeed { get; set; } = 309.0;
    public string TransmissionType { get; set; } = "direct";

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        Console.WriteLine("Starting Cessna");
    }

    public void Land()
    {
        Console.WriteLine("Stopping Cessna");
    }
    }
}
