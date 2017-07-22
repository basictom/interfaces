namespace interfaces
{
    public interface ILand : IVehicle
    {
        double MaxSpeed { get; set; }

        void Drive();
        void Stop();
    }
}
