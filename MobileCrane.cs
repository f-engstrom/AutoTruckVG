using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTruck
{
    class MobileCrane : Vehicle
    {

        public int LiftCapacity { get; }


        public MobileCrane(string registrationNumber, string brand, string model, int liftCapacity) : base(registrationNumber,brand, model)
        {
            LiftCapacity = liftCapacity;

        }


        public override string GetVehicleType()
        {

            return "Kranbil";

        }


    }


}
