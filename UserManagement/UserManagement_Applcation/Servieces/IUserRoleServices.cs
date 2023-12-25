using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement_Domain.Entities;

namespace UserManagement_Applcation.Servieces
{
    public interface IUserRoleServices<UserRole>
    {
        Task<IEnumerable<UserRole>> GetRolesForUserAsync(UserRole Id);
        Task AddUserRoleAsync(UserRole userRole);
        Task RemoveUserRoleAsync(UserRole userRole);
        // Additional methods for user role management can be added here.
    }
}
