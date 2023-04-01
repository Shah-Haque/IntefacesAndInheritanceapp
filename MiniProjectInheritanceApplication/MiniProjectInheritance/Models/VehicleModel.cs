using MiniProjectInheritance.Interfaces;
using System;

namespace MiniProjectInheritance.Models
{
    public class VehicleModel : InventoryItemModel, IPurchasable, IRentalable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been implemented");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This vehicle has been returned");
        }
    }
}