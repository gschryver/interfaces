using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; } = 55;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive() {
            Console.WriteLine($"The {MainColor} Cessna drives past. Zzzzzzzoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna carefully turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
}