using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Reflection.Metadata;

namespace AutoTruck
{
    public static class VehicleRegister
    {
        public static void RegisterVehicle()
        {


            ConsoleKeyInfo keyPressed;
            bool invalidKeyPress = true;
            bool validBooking = false;
            Vehicle tempVehicle = null;
            int vehicleChoice = 0;

            do
            {

                Console.SetCursorPosition(5, 7);
                Console.WriteLine("Registreringsnummer: ");
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("(1) Iveco, Z-Truck");
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("(2) Libherr, LTM 5000 ");
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("Fordonstyp: ");
                Console.SetCursorPosition("Registreringsnummer: ".Length + 4, 7);
                string registrationNumber = Console.ReadLine();

                do
                {
                    keyPressed = Console.ReadKey(true);

                    invalidKeyPress = !(keyPressed.Key == ConsoleKey.D1 || keyPressed.Key == ConsoleKey.D2);

                } while (invalidKeyPress);



                if (keyPressed.Key == ConsoleKey.D1)
                {
                    vehicleChoice = 1;
                    Console.Clear();
                    Console.WriteLine($"Registreringsnummer: {registrationNumber}");

                    Console.WriteLine("Fordon: Iveco, Z-Truck");
                    Console.WriteLine("Märke: Iveco");
                    Console.WriteLine("Modell: Z-Truck");
                    Console.WriteLine("Lastkapacitet: 40");

                }

                if (keyPressed.Key == ConsoleKey.D2)
                {
                    vehicleChoice = 2;
                    Console.Clear();
                    Console.WriteLine($"Registreringsnummer: {registrationNumber}");

                    Console.WriteLine("Fordon: Libherr,  LTM 500");
                    Console.WriteLine("Märke: Libherr");
                    Console.WriteLine("Modell:  LTM 500");
                    Console.WriteLine("Lastkapacitet: 40");

                }



                Console.WriteLine("\nÄr detta rätt? (J)a (N)ej");

                if (vehicleChoice == 1)
                {
                    tempVehicle = new Truck(registrationNumber: registrationNumber, "Iveco", model: "Z-Truck", loadCapacity: 40);

                }

                if (vehicleChoice == 2)
                {

                    tempVehicle = new MobileCrane(registrationNumber: registrationNumber, brand: "Libherr", model: " LTM 500", liftCapacity: 18);

                }


                do
                {
                    keyPressed = Console.ReadKey(true);

                    invalidKeyPress = !(keyPressed.Key == ConsoleKey.J || keyPressed.Key == ConsoleKey.N);

                } while (invalidKeyPress);



                if (keyPressed.Key == ConsoleKey.J)
                {
                    if (Vehicles.AllVehicles.ContainsKey(registrationNumber))
                    {
                        Console.Clear();
                        Console.WriteLine("Fordon redan registrerat");
                        validBooking = true;
                        Thread.Sleep(2000);

                    }
                    else
                    {
                        Vehicles.AllVehicles.Add(registrationNumber, tempVehicle);
                        Console.Clear();
                        Console.WriteLine("Fordon registrerat");
                        validBooking = true;
                        Thread.Sleep(2000);


                    }

                }
                if (keyPressed.Key == ConsoleKey.N)
                {
                    Console.Clear();

                }

            } while (!validBooking);




        }
        public static void ListVehicles()
        {

            var sortedVehicles = Vehicles.AllVehicles.Values
                .GroupBy(v => v.GetVehicleType(),
                    (v) => new
                    {
                        key = v.GetVehicleType(),
                        count = v,
                        regstrationNumber = v.RegistrationNumber,
                        brandModel = v.ToString(),
                        typeVehicle = v.GetVehicleType(),


                    }).OrderBy(v => v);


            foreach (var vehicle in sortedVehicles)
            {
                Console.WriteLine("Fordonstyp\tAntal");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"{vehicle.Key}     {vehicle.Count()}");

                Console.WriteLine("Reg. nr\tFordon\tTyp");
                Console.WriteLine("----------------------------------------------------------");
                foreach (var kranLastbil in vehicle)
                {

                    Console.WriteLine($"{kranLastbil.regstrationNumber}   {kranLastbil.brandModel}    {kranLastbil.typeVehicle}");

                }


            }

            Console.ReadKey();

        }

    }
}
