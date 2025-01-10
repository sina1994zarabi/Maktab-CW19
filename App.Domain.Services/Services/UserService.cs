using App.Domain.Core.Contracts.Repository;
using App.Domain.Core.Contracts.Service;
using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void DeleteUserById(int id)
        {
            _userRepository.Delete(id);
        }

        public ICollection<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Register(User newUser)
        {
            _userRepository.Add(newUser);
        }

        public void UpdateUser(int id, User updatedUser)
        {
            _userRepository.Update(id,updatedUser);
        }
    }
}
