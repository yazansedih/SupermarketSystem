using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarketsyst.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }      
        public string Role { get; set; }

        public abstract void ShowDashboard();
    }
}
