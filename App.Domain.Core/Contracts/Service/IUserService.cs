using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.Service
{
    public interface IUserService
    {
        void Register(User newUser);
        User GetUserById(int id);
        ICollection<User> GetAllUsers();
        void UpdateUser(int id, User updatedUser);
        void DeleteUserById(int id);
    }
}
