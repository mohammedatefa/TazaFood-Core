using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models;

namespace TazaFood_Core.ISpecifications
{
    public class BaseSpecification<T> : ISpecification<T> where T : BaseModel
    {
        public Expression<Func<T, bool>> Ceritaria { get; set; }
        public List<Expression<Func<T, object>>> Includes { set; get; } = new List<Expression<Func<T, object>>>();
        public Expression<Func<T, object>> OrderBy { get; set; }
        public Expression<Func<T, object>> OrderByDec { get ; set ; }

        public BaseSpecification() { }

        public BaseSpecification(Expression<Func<T, bool>> cr )
        {
           Ceritaria = cr;
        }

    }
}
