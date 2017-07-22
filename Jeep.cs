using System;

namespace interfaces
{
    public class Jeep : ILand, IDriveable
    {
        public int Wheels { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 4;
        public int Doors { get; set; } = 4;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxSpeed { get; set; } = 160.4;
        public void Drive()
        {
            Console.WriteLine("The Jeep is for Jeep People");
        }

        public void Start()
        {
            Console.WriteLine("The Jeep starts");
        }

        public void Stop()
        {
            Console.WriteLine("The Jeep stops");
        }
    }

}
