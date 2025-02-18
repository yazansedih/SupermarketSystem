using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarketsyst.Models
{
    class StockManager
    {
        public StockManager() { }
        public StockManager(string name) { }

        private List<Product> products = new List<Product>();
    }
}
