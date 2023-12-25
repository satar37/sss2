using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement_Applcation.Repositories
{
    public interface IUserRoleRepository<UserRole>
    {
        Task<IEnumerable<UserRole>> GetRolesForUserAsync(UserRole Id);
        Task AddUserRoleAsync(UserRole userRole);
        Task RemoveUserRoleAsync(UserRole userRole);
        // Additional methods for user role management can be added here.
    }
}
