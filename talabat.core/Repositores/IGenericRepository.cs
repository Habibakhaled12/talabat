using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using talabat.core.entites;

namespace talabat.core.Repositores
{
    public interface IGenericRepository<T> where T:BaseClass
    {
        Task<IEnumerable<T>> GetAllasync();
        Task<T> GetByIdAsync(int id);
    }
}
