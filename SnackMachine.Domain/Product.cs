using SnackMachines.Common;
using System.Collections.Generic;

namespace SnackMachines.Domain
{
    public sealed class Product : Entity
    {
        public int ProductId { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static IList<Product> GetProducts()
        {
            //ToDo: get from db
            var products = new List<Product>
            {
                new Product("Çokonat", 1),
                new Product("Tutku", 1.5m),
                new Product("Fıstık", 2),
                new Product("Ğedbull", 5),
            };
            return products;
        }
    }
}
