using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTruck
{
    public static class Orders
    {
        public static List<Order> AllOrders { get; set; } = new List<Order>();
    }

    public class Order
    {
        public string Customer { get; }
        public string Destination { get; }
        public string Cargo { get; }
        public DateTime DeliveryDate { get; }
        public string Truck { get; }

        public Order (string customer, string destination, string cargo, DateTime deliveryDate, string truck )
        {
            Truck = truck;
            DeliveryDate = deliveryDate;
            Cargo = cargo;
            Destination = destination;
            Customer = customer;
        }


    }
}
