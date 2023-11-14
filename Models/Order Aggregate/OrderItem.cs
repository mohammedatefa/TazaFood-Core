using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TazaFood_Core.Models.Order_Aggregate
{
    public class OrderItem:BaseModel
    {
        public OrderItem() { }
          
        
        public OrderItem(ProductOrderItem product, int quantity, decimal price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public ProductOrderItem Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
