using System;

namespace interfaces
{
    public class battleShip : IWater
    {
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Automatic";
        public double EngineVolume { get; set; }
        public double MaxSpeed { get; set; }
        public int Doors { get; set; } = 0;
        public int Wheels { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("This battle ship is BAD ASS");
        }

        public void Start()
        {
            Console.WriteLine("Battleship Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Battleship Stoping");
        }
    }
}
