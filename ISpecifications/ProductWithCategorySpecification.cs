using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models;

namespace TazaFood_Core.ISpecifications
{
    public class ProductWithCategorySpecification:BaseSpecification<Product>
    {
        public ProductWithCategorySpecification() 
        {
            Includes.Add(P => P.Category);
        }
        public ProductWithCategorySpecification(string sort)
        {
            Includes.Add(P => P.Category);
            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "price":
                        OrderBy = p => p.Price;
                        break;
                    case "category":
                        OrderBy = p => p.Category.Name;
                        break;
                    case "rate":
                        OrderBy = p => p.Rate;
                        break;
                    default:
                        OrderBy = p => p.Name;
                        break;
                }
            }
        }
        public ProductWithCategorySpecification(int id):base(p=>p.Id==id)
        {
            Includes.Add(P => P.Category);
        }
    }
}
