using System;

namespace interfaces
{
    public class G7 : IAir
    {
    public int Wheels { get; set; } = 7;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 10;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 21.1;
    public double MaxSpeed { get; set; } = 509.0;
    public string TransmissionType { get; set; } = "direct";

    public void Fly()
    {
        Console.WriteLine("I'm fly like a G7");
    }

    public void Start()
    {
        Console.WriteLine("G7 Takikng off");
    }

    public void Land()
    {
        Console.WriteLine("G7 Landing");
    }
    }
}
