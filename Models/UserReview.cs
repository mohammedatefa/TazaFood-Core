using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TazaFood_Core.Models
{
    public class UserReview
    {
        public string Id { get; set; }
        public List<Review> CartItems { get; set; } = new List<Review>();
        public UserReview(string id)
        {
            Id = id;
        }
    }
}
