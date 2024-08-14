using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using talabat.core.entites;
using talabat.core.Repositores;
using talabat.reposatory.Data;

namespace talabat.reposatory.implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
    {
        private readonly storeContext _dbContext;

        public GenericRepository(storeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<T>> GetAllasync()
        
        =>await _dbContext.Set<T>().ToListAsync();
        
        //set is represent a data with type t
        public async Task<T> GetByIdAsync(int id)
        {
       return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
