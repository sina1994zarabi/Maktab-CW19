using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Contracts.AppService
{
    public interface IUserAppService
    {
        void CreateNewUser(User newUser);
        ICollection<User> ViewAllUsers();
        void EditUserInfo(int id, User editedUser);
        User DisplayUserInfo(int  id);
        void DeleteUser(int id);

    }
}
