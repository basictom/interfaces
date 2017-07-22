using System;

namespace interfaces
{
    public class JetSki : IWater, IDriveable
    {
        public int PassengerCapacity { get; set; } = 2;
        public string TransmissionType { get; set; } = "Automatic";
        public double EngineVolume { get; set; } = 2.3;
        public double MaxSpeed { get; set; } = 65.9;
        public int Doors { get; set; } = 0;
        public int Wheels { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            Console.WriteLine("The jetskiing is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Jetski is stopping");
        }
    }
}
