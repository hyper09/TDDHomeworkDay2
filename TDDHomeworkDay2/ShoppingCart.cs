using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomeworkDay2
{
    public class ShoppingCart
    {
        public decimal Checkout(IEnumerable<Product> books) {
            return default(decimal);
        }
    }

    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
