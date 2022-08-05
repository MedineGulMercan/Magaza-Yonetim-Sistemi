using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface IGenericRepository <T> where T : BaseEntity
    {
        Task<IEnumerable<T>>? GetAllAsync();
        Task<T>? GetAsync(int? id);
        Task ? CreateAsync(T? entity);   
        Task DeleteAsync(int? id);
        Task UpdateAsync(T? entity);

    }
}
