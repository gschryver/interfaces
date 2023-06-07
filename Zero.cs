using System;

namespace Garage {

    public class Zero : Vehicle, IElectricVehicle {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; } = 55;
        public void ChargeBattery () { 
            CurrentChargePercentage = 100;
        }
    public override void Drive() {
        Console.WriteLine($"The {MainColor} Zero drives past. Yeeeeeeowwwww!");
    }
    public override void Turn(string direction) {
        Console.WriteLine($"The Zero carefully turns {direction}.");
    }
    public override void Stop() {
        Console.WriteLine($"The {MainColor} Zero gently rolls to a stop!");
    }
}
}