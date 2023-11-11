using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TazaFood_Core.ISpecifications
{
    public class ProductPaginationParams
    {
        public string? sortBy { get; set; }

        public int? FilterByRate { get; set; }
        public int? FilterByPrice { get; set; }
        public string? FilterBycategory { get; set; }

        private string? search;

        public string? Search
        {
            get { return search; }
            set { search = value.ToLower(); }
        }


        private const int maxsize = 10;
        private int pagesize = maxsize;

        public int pageIndex { get; set; } = 1;

        public int Pagesize
        {
            get { return pagesize; }
            set { pagesize = value > 10 ? maxsize : value; }
        }

    }
}
