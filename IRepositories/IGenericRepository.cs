using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TazaFood_Core.ISpecifications;
using TazaFood_Core.Models;

namespace TazaFood_Core.IRepositories
{
    public interface IGenericRepository<T> where T:BaseModel
    {

        public Task<T> GetById(int id);
        public Task<IReadOnlyList<T>> GetAll();

        //get model useng the specification class instead of using the normal way to include any property 
        public Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);
        public Task<T> GetByIdWithSpec(ISpecification<T> spec);

        public Task<int> GetCountWithSpec(ISpecification<T> spec);

        public Task Add(T entity);

        public Task Update(int id,T entity);

        public Task Delete(int id);


    }
}
