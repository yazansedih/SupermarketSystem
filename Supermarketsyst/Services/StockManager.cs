using Supermarketsyst.Models;

namespace Supermarketsyst.Services
{
    class StockManager
    {
        private static StockManager _instance;

        private static readonly object _lock = new object();

        private List<Product> _products = new List<Product>();

        private StockManager() { }

        public static StockManager Instance
        {
            get
            {
                lock (_lock) // Ensures only one thread can access at a time
                {
                    if (_instance == null)
                        _instance = new StockManager(); // Create instance if it doesn't exist
                    return _instance; // Return the same instance
                }
            }
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
            Console.WriteLine($"Product {product.Name} added to stock.");
        }

        public void ViewStock()
        {
            Console.WriteLine("Stock List:");
            foreach (var product in _products)
                Console.WriteLine($"{product.Id}: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }

    }
}
