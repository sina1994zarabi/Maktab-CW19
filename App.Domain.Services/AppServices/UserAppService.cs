using App.Domain.Core.Contracts.AppService;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.AppServices
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }


        public void CreateNewUser(User newUser)
        {
            _userService.Register(newUser);
        }

        public ICollection<User> ViewAllUsers()
        {
            return _userService.GetAllUsers();
        }

        public void EditUserInfo(int id, User editedUser)
        {
            _userService.UpdateUser(id,editedUser);
        }

        public User DisplayUserInfo(int id)
        {
            return _userService.GetUserById(id);
        }

        public void DeleteUser(int id)
        {
            _userService.DeleteUserById(id);
        }
    }
}
