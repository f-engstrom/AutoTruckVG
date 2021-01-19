using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTruck
{
    class Truck : Vehicle
    {
        public int LoadCapacity { get; }


        public Truck(string registrationNumber, string brand, string model, int loadCapacity) : base(registrationNumber, brand, model)
        {
            LoadCapacity = loadCapacity;

        }


        public override string GetVehicleType()
        {

            return "Lastbil";

        }

    }
}
