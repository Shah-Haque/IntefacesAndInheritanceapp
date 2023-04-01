using MiniProjectInheritance.interfaces;
using MiniProjectInheritance.Models;
using System;

namespace MiniProjectInheritance
{
    public class ExcavatorModel : InventoryItemModel, Interfaces.IRentalable, IExcavatorModel
    {
        public void Dig()
        {
            Console.WriteLine("I am digging");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("the excavator has been returned");
        }
    }
}