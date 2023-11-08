using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TazaFood_Core.Models
{
    public class Product:BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
       
        public string ImageUrl { get; set; }
        public int? Rate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
