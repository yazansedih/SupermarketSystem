using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarketsyst.Models
{
    public abstract class User
    {
        private static int _nextId = 1; 

        public int Id { get; private set; }  
        public string Name { get; set; }
        public string Role { get; set; }

        public User(string name)
        {
            Id = _nextId++;  
            Name = name;
        }

        public abstract void ShowDashboard();
    }
}
