using System;

namespace SieMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orders = new List<Order>
            {
                new Order
                {
                    CustomerName = "Alice",
                    Items = new List<OrderItem> {
                        new OrderItem
                        {
                            ProductName = "Laptop",
                            Quantity = 1,
                            UnitPrice = 999m
                        },
                        new OrderItem
                        {
                            ProductName = "Mouse",
                            Quantity = 3,
                            UnitPrice = 10m
                        }
                    }
                },
                new Order
                {
                    CustomerName = "Assa",
                    Items = new List<OrderItem> {
                        new OrderItem
                        {
                            ProductName = "GoPro",
                            Quantity = 1,
                            UnitPrice = 120m
                        },
                        new OrderItem
                        {
                            ProductName = "SD Card",
                            Quantity = 3,
                            UnitPrice = 20m
                        }
                    }
                },
                new Order
                {
                    CustomerName = "Alice",
                    Items = new List<OrderItem> {
                        new OrderItem
                        {
                            ProductName = "USB",
                            Quantity = 1,
                            UnitPrice = 20m
                        },
                        new OrderItem
                        {
                            ProductName = "SD Card",
                            Quantity = 1,
                            UnitPrice = 20m
                        }

                    }

                }
            };

            string topSpender = GetTopSpender(orders);
            Console.WriteLine("The Clint who spend the most money is: " + topSpender);

            var mostPopularProduct = GetMostPopularProduct(orders);
            Console.WriteLine("Most popular products:");
            foreach (var product in mostPopularProduct)
            {
                Console.WriteLine($"{product.Key}: {product.Value} sold");
            }
        }

        public static string GetTopSpender(List<Order> orders)
        {
            var topCustomer = orders.
                GroupBy(o => o.CustomerName).
                Select(group => new
                {
                    CustomerName = group.Key,
                    TotalSpent = group.Sum(order => order.CalculateFinalPrice())
                })
                .OrderByDescending(c => c.TotalSpent)
                .FirstOrDefault();

            return topCustomer?.CustomerName ?? "No Customer found";
        }

        public static Dictionary<string, int> GetMostPopularProduct(List<Order> orders)
        {
            var topProducts = orders
            .SelectMany(o => o.Items)
            .GroupBy(i => i.ProductName)
            .OrderByDescending(group => group.Sum(item => item.Quantity))
            .ToDictionary(
                group => group.Key,
                group => group.Sum(item => item.Quantity)
            );

            return topProducts;

        }
    }
}