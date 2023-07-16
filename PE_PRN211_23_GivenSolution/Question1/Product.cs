using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }

        public Product()
        {
            
        }

        public Product(int productId, string productName, double price, bool isActive)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            IsActive = isActive;
        }
    }
}
