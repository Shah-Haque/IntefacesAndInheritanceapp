﻿using MiniProjectInheritance.Interfaces;

namespace MiniProjectInheritance.Models
{
    public class InventoryItemModel:IInventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }


    }
}