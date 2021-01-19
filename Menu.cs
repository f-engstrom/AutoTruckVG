using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AutoTruck
{
    class Menu
    {
        public void MenuSelector()
        {
            bool shouldNotExit = true;

            while (shouldNotExit)
            {


                Clear();

                WriteLine("1. Skapa leverans");
                WriteLine("2. Lista leveranser");
                WriteLine("3. Registrera fordon");
                WriteLine("4. Lista fordon");
                WriteLine("5. Avsluta");

                ConsoleKeyInfo keyPressed = ReadKey(true);


                switch (keyPressed.Key)
                {

                    case ConsoleKey.D1:
                        Clear();
                        Delivery.CreateDelivery();

                        break;

                    case ConsoleKey.D2:
                        Clear();
                        Delivery.ListDeliveries();

                        break;

                    case ConsoleKey.D3:
                        Clear();
                        VehicleRegister.RegisterVehicle();

                        break;

                    case ConsoleKey.D4:

                        Clear();
                       VehicleRegister.ListVehicles();

                        break;


                    case ConsoleKey.D5:

                        shouldNotExit = false;

                        break;

                }

            }
        }

    
    }
}
