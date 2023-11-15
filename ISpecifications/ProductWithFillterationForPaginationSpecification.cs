using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models;

namespace TazaFood_Core.ISpecifications
{
    public class ProductWithFillterationForPaginationSpecification:BaseSpecification<Product>
    {
        public ProductWithFillterationForPaginationSpecification(ProductPaginationParams pagination) : base(
            p => (!pagination.FilterByPrice.HasValue || p.Price >= pagination.FilterByPrice.Value) &&
            (!pagination.FilterByRate.HasValue || p.Rate >= pagination.FilterByRate.Value) &&
            (pagination.FilterBycategory == null || p.Category.Name.Contains(pagination.FilterBycategory))&&
             (string.IsNullOrEmpty(pagination.Search) || p.Name.ToLower().Contains(pagination.Search)))
        {

        }
    }
}
