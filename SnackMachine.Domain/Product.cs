using System;
using System.Collections.Generic;
using System.Text;

namespace SnackMachines.Domain
{
    public sealed class Product
    {
        public int ProductId { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {

        }

        public static IList<Product> GetProducts()
        {
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
