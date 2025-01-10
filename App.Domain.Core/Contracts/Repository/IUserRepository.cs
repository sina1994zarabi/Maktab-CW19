﻿using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace App.Domain.Core.Contracts.Repository
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetById(int id);
        ICollection<User> GetAll();
        void Update(int id, User user);
        void Delete(int id);
    }
}
