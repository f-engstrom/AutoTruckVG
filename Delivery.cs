using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoTruck
{
    public static class Delivery
    {
        public static void CreateDelivery()
        {


            ConsoleKeyInfo keyPressed;
            bool invalidKeyPress = true;
            bool validBooking = false;

            do
            {

                Console.SetCursorPosition(5, 7);
                Console.WriteLine("Kund: ");
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("Destination: ");
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("Last: ");
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("Leveransdatum ( yyyy-mm-dd hh:mm): ");
                Console.SetCursorPosition(5, 15);
                Console.WriteLine("Lastbil (registreringsnummer): ");
                Console.SetCursorPosition("Kund: ".Length + 4, 7);
                string customer = Console.ReadLine();
                Console.SetCursorPosition("Destination: ".Length + 4, 9);
                string destination = Console.ReadLine();
                Console.SetCursorPosition("Last: ".Length + 4, 11);
                string cargo = Console.ReadLine();
                Console.SetCursorPosition("Leveransdatum ( yyyy-mm-dd hh:mm): ".Length + 4, 13);
                DateTime dateofBooking = DateTime.Parse(Console.ReadLine());
                Console.SetCursorPosition("Lastbil (registreringsnummer): ".Length + 4, 15);
                string registstrationNumber = Console.ReadLine();


                Console.WriteLine("\nÄr detta rätt? (J)a (N)ej");


                do
                {
                    keyPressed = Console.ReadKey(true);

                    invalidKeyPress = !(keyPressed.Key == ConsoleKey.J || keyPressed.Key == ConsoleKey.N);

                } while (invalidKeyPress);



                if (keyPressed.Key == ConsoleKey.J)
                {
                    //if (RegisterPerson.MyEmployees.ContainsKey(cargo) && RegisterPerson.MyPatients.ContainsKey(socialSecurityNumber))
                    //{
                        Orders.AllOrders.Add(new Order(
                            customer: customer,
                            destination: destination,
                            cargo: cargo,
                            deliveryDate: dateofBooking,
                            truck: registstrationNumber
                            ));
                        Console.Clear();
                        Console.WriteLine("Leverans skapad");
                        validBooking = true;
                        Thread.Sleep(1000);

                    //}
                    //else
                    //{
                    //    Console.Clear();
                    //    Console.WriteLine("Ogiltig anställd eller personal");
                    //    validBooking = true;
                    //    Thread.Sleep(1000);
                    //}


                }
                if (keyPressed.Key == ConsoleKey.N)
                {
                    Console.Clear();

                }

            } while (!validBooking);




        }


        public static void ListDeliveries()
        {

            Console.WriteLine("Kund\tLast\tLastbil\tLeveransdatum");
            Console.WriteLine("----------------------------------------------------------");

            foreach (var order in Orders.AllOrders)
            {

                Console.WriteLine($"{order.Customer}\t{order.Cargo}\t{order.Truck}\t{order.DeliveryDate}");
                
            }

            Console.ReadKey();

        }

    }
}
