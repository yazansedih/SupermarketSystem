using Supermarketsyst.Models;
using Supermarketsyst.Services;

    class Program
    {
        static void Main()
        {
            StockManager stockManager = StockManager.Instance;
            OrderService orderService = new OrderService();

            while (true)
            {
                Console.WriteLine("\nSupermarket System");
                Console.WriteLine("1. Admin Panel");
                Console.WriteLine("2. Cashier Panel");
                Console.WriteLine("3. Stock Manager");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Admin admin = new Admin("Yazan");
                            admin.ShowDashboard();
                            break;

                        case "2":
                            Cashier cashier = new Cashier("John");
                            cashier.ShowDashboard();
                            Order order = orderService.CreateOrder();
                            Product apple = new Product(1, "Apple", 1.5m, 100);
                            order.AddProduct(apple, 3);
                            order.PrintInvoice();
                            break;

                        case "3":
                            Console.WriteLine("Stock Manager:");
                            Product banana = new Product(2, "Banana", 0.5m, 50);
                            stockManager.AddProduct(banana);
                            stockManager.ViewStock();
                            break;

                        case "4":
                            Console.WriteLine("Exiting...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
