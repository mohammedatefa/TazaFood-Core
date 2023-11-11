using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.Models;

namespace TazaFood_Core.IRepositories
{
    public interface ICategoryRepository 
    {
        public Task<Category> GetByName(string name);
    }
}
