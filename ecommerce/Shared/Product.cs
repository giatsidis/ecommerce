using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; } = "https://via.placeholder.com/250x250";
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}