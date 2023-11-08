using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TazaFood_Core.Models
{
    public class Category:BaseModel
    {
        public string  Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public IEnumerable<Product> Products {  get; set; }
    }
}
