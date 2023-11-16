using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TazaFood_Core.Models
{
    public class UserCart
    {
        public string Id { get; set; }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public string? ClientSecrete { get; set; }
        public string? PaymentIntentId { get; set; }
        public int? DeleveryMethodId { get; set; }
        public decimal ShippingCost { get; set; }
        public UserCart(string id)
        {
            Id = id;
        }
    }
}
