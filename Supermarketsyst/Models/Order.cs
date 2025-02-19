using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarketsyst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Items { get; set; }
        public decimal TotalAmount { get; set; }

        public Order(int id)
        {
            Id = id;
            Items = new List<Product>();
        }

        public void AddProduct(Product product, int quantity)
        {
            if (product.Stock < quantity)
            {
                Console.WriteLine($"Not enough stock for {product.Name}");
                return;
            }

            for (int i = 0; i < quantity; i++)
                Items.Add(product);

            product.Stock -= quantity;
            TotalAmount += product.Price * quantity;
            Console.WriteLine($"Added {quantity} of {product.Name} to order.");
        }

        public void PrintInvoice()
        {
            Console.WriteLine($"Order ID: {Id}");
            Console.WriteLine("Items:");
            foreach (var product in Items)
                Console.WriteLine($"{product.Name} - ${product.Price}");

            Console.WriteLine($"Total: ${TotalAmount}");
        }
    }

}
