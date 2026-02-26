using System;
using System.Collections.Generic;
using System.Text;

namespace SieMarket
{
    internal class OrderItem
    {
        public required string ProductName { get; init; }
        public int Quantity { get; init; }
        public decimal UnitPrice { get; init; }
    }
}
