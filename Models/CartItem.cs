using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TazaFood_Core.Models
{
    public class CartItem:BaseModel
    {
        public string  Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Rate { get; set; }
        public string category { get; set; }
        public int Quantity { get; set; }
    }
}
