using System;

namespace interfaces
{
    public class JetSki : IVehicle
    {
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed 
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public double MaxAirSpeed 
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public int Wheels 
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

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
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
