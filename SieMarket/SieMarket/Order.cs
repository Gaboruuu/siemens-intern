using System;
using System.Collections.Generic;
using System.Text;

namespace SieMarket
{
    internal class Order
    {
        public required string CustomerName { get; init; } 
        public List<OrderItem> Items { get; init; } = new List<OrderItem>();

        public decimal CalculateFinalPrice()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Quantity * item.UnitPrice;
            }

            if (total > 500m)
            {
                total *= 0.9m;
            }

            return total;
        }
    }
}
