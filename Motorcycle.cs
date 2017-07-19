using System;

namespace interfaces
{
    public class Motorcycle : IVehicle
    {
        public int Wheels { get; set; } = 2;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxLandSpeed { get; set; } = 160.4;
        public double MaxAirSpeed 
        { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public int Doors 
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public bool Winged 
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public double MaxWaterSpeed 
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }

        public void Fly()
        {
            throw new NotImplementedException();
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

}
