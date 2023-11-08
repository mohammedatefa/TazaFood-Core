﻿using System;
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
        public ProductWithCategorySpecification(int id):base(p=>p.Id==id)
        {
            Includes.Add(P => P.Category);
        }
    }
}
