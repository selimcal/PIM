using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Business.Abstract
{
    public interface IUserService
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
