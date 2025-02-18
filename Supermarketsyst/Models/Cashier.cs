using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarketsyst.Models
{
    class Cashier : User
    {
        public Cashier(int id, string name)
        {
            Id = id;
            Name = name;
            Role = "Cashier";
        }
        public override void ShowDashboard()
        {
            Console.WriteLine("Welcome Cashier! Process customer transactions.");
        }

        public void ProcessSale(Order order)
        {
            Console.WriteLine($"Processing sale for order {order.Id}...");
        }
    }
}
