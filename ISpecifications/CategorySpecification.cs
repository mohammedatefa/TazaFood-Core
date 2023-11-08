using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models;

namespace TazaFood_Core.ISpecifications
{
    public class CategorySpecification:BaseSpecification<Category>
    {
       
        public CategorySpecification(int id):base(cr=>cr.Id==id)
        {
        }
    }
}
