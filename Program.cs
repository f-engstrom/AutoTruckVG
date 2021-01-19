using System;

namespace AutoTruck
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu autoTruckMenu = new Menu();
            Vehicles.PopulateWithVehicles();

            autoTruckMenu.MenuSelector();

        }
    }
}
