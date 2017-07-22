using System.Linq;
using System.Collections.Generic;

namespace interfaces
{

    public class Program
    {
        public static void Main()
        {

            // Build a collection of all vehicles that fly
            var airVehicles = new List<IAir>
            {
                new Cessna(), new G7()
            };

            // With a single `foreach`, have each vehicle Fly()

            foreach (var wings in airVehicles)
            {
                wings.Fly();
                wings.Start();
                wings.Land();
            }


            // Build a collection of all vehicles that operate on roads

            var landVehicles = new List<ILand> { new Motorcycle(), new Jeep() };

            // With a single `foreach`, have each road vehicle Drive()

            foreach (var drive in landVehicles)
            {
                drive.Drive();
                drive.Start();
                drive.Stop();
            }



            // Build a collection of all vehicles that operate on water

            var waterVehicle = new List<IWater> { new JetSki(), new battleShip() };

            // With a single `foreach`, have each water vehicle Drive()

            foreach (var boat in waterVehicle)
            {
                boat.Start();
            }
        }

    }
}
