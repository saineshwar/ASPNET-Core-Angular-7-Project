using System.Collections.Generic;
using AngularCoreGym.Models;
using AngularCoreGym.ViewModels;

namespace AngularCoreGym.Interface
{
    public interface IUsersInRoles
    {
        bool AssignRole(UsersInRoles usersInRoles);
        bool CheckRoleExists(UsersInRoles usersInRoles);
        bool RemoveRole(UsersInRoles usersInRoles);
        List<AssignRolesViewModel> GetAssignRoles();
    }
}