using MiniProjectInheritance.Interfaces;
using MiniProjectInheritance.Models;
using System;
using System.Collections.Generic;

namespace MiniProjectInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRentalable> rentalables = new List<IRentalable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel {DealerFee = 25, ProductName = "Shah optimus" };
            var book = new BookModel { ProductName = "A tale of two cities", NumberOfPages = 350 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentalables.Add(vehicle);
            rentalables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.Write("Do you want to rent or purchase something: (rent, purchase) ");
            string rentalDescision = Console.ReadLine();

            if (rentalDescision.ToLower() == "rent")
            {
                foreach (var item in rentalables)
                {
                    Console.WriteLine($"item: {item.ProductName}");
                    Console.Write("Do you want to rent this item (yes/no)");
                    string wantToRent = Console.ReadLine();
                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.Write("Do you want to return this item (yes/no)");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach(var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}" );
                    Console.Write("Do you want to purchase this product (yes/no) ");
                    string WantToPurchase = Console.ReadLine();

                    if (WantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }

                }

            }
            Console.WriteLine("We are done");
            Console.ReadLine();
        }
    }
}