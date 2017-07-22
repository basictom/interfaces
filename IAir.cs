namespace interfaces
{
    public interface IAir : IVehicle
    {
        bool Winged { get; set; }
        double MaxSpeed { get; set; }
        void Fly();
        void Land();
    }
}
