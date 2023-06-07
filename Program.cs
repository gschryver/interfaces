using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine();
            Console.WriteLine("Electric Vehicles");
            Console.WriteLine("------------------");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The current charge is {ev.CurrentChargePercentage}% for {ev}.");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                Console.WriteLine($"The {ev} is recharging. . .");
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The new percentage after recharging is: {ev.CurrentChargePercentage}% for {ev}.");
            }

            Console.WriteLine();

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            Console.WriteLine("------------------");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The current fuel is {gv.CurrentTankPercentage}% for {gv}.");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                Console.WriteLine($"The {gv} is refueling. . .");
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The new percentage after refueling is: {gv.CurrentTankPercentage}% for {gv}.");
            }

            Console.WriteLine();
            Console.WriteLine("***********************************************");


            var vehicles = new List<Vehicle>
            {
                new Zero { MainColor = "Midnight Blue" },
                new Zero { MainColor = "Black" },
                new Tesla { MainColor = "Burgundy" },
                new Cessna { MainColor = "White" },
                new Ram { MainColor = "Silver" }
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Turn("right");
                vehicle.Stop();
                Console.WriteLine();
            }


        }
    }
}
