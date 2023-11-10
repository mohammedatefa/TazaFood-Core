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

        //where specification
        public ProductWithCategorySpecification(int id) : base(p => p.Id == id)
        {
            Includes.Add(P => P.Category);
        }

        //fillteration specification
        public ProductWithCategorySpecification(int? price,int? rate,string? category):base(
            p=>(!price.HasValue||p.Price>=price.Value)&&
            (!rate.HasValue||p.Rate>=rate.Value)&&
            (category==null||p.Category.Name==category))
        {
            Includes.Add(P => P.Category);
        }

        //sorting specification
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

        //pagination specification with sorting and filteration
        public ProductWithCategorySpecification(ProductPaginationParams pagination):base(
            p=>(!pagination.FilterByPrice.HasValue||p.Price>=pagination.FilterByPrice.Value)&&
            (!pagination.FilterByRate.HasValue||p.Rate>=pagination.FilterByRate.Value)&&
            (pagination.FilterBycategory==null||p.Category.Name==pagination.FilterBycategory)&&
            (string.IsNullOrEmpty(pagination.Search)||p.Name.ToLower().Contains(pagination.Search)))
        {
            Includes.Add(P => P.Category);
           
            if (!string.IsNullOrEmpty(pagination.sortBy))
            {
                switch (pagination.sortBy)
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

            ApplyPagination(pagination.Pagesize * (pagination.pageIndex - 1), pagination.Pagesize);
        }
    }
}
