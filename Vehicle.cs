using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTruck
{

    public static class Vehicles
    {
        public static Dictionary<string, Vehicle> AllVehicles { get; set; } = new Dictionary<string, Vehicle>();

        public static void PopulateWithVehicles()
        {
            AllVehicles.Add("axc124", new MobileCrane("axc124", "Libherr", " LTM 500", 20));
            AllVehicles.Add("abc154", new Truck("abc154", "Iveco", "Z-Truck", 20));
            AllVehicles.Add("anc124", new MobileCrane("anc124", "Libherr", " LTM 500", 20));
            AllVehicles.Add("abc184", new Truck("abc184", "Iveco", "Z-Truck", 20));
            AllVehicles.Add("abv124", new MobileCrane("abv124", "Libherr", " LTM 500", 20));
            AllVehicles.Add("abc114", new Truck("abc114", "Iveco", "Z-Truck", 20));
            AllVehicles.Add("abc159", new MobileCrane("abc159", "Libherr", " LTM 500", 20));
            AllVehicles.Add("abc134", new Truck("abc134", "Iveco", "Z-Truck", 20));
            AllVehicles.Add("abc164", new Truck("abc164", "Iveco", "Z-Truck", 20));
            AllVehicles.Add("awc124", new MobileCrane("awc124", "Libherr", " LTM 500", 20));
            AllVehicles.Add("abc127", new Truck("abc127", "Iveco", "Z-Truck", 20));
            AllVehicles.Add("abc124", new MobileCrane("abc124", "Libherr", " LTM 500",20));
            AllVehicles.Add("abc125", new Truck("abc125", "Iveco", "Z-Truck", 20));


        }


    }

    public abstract class Vehicle
    {

        public Vehicle(string registrationNumber, string brand, string model)
        {
            RegistrationNumber = registrationNumber;
            Brand = brand;
            Model = model;

        }
        public string RegistrationNumber { get; }
        public string Brand { get; }
        public string Model { get; }


        public abstract string GetVehicleType();



        public override string ToString()
        {
            return $"{Brand}, {Model}";
        }
    }
}
