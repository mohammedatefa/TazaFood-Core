﻿using System;
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
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);


        //get model useng the specification class instead of using the normal way to include any property 
        public Task<IEnumerable<T>> GetAllWithSpec(ISpecification<T> spec);
        public Task<T> GetByIdWithSpec(ISpecification<T> spec);

    }
}