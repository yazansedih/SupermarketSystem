using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarketsyst.Models
{
    class Admin : User
    {
        public Admin(int id, string name)
        {
            Id = id;
            Name = name;
            Role = "Admin";
        }
        public override void ShowDashboard()
        {
            Console.WriteLine("Welcome Admin! Manage system users and settings.");
        }
    }
}
