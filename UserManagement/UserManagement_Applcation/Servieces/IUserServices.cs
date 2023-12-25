using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement_Applcation.Servieces
{
    public interface IUserServices<T> where T : class
    
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(T id);
        Task<T> GetByUsernameAsync(string username);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        // Additional methods for general entity management can be added here.
    }
}
