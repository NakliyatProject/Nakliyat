using Application.Repositories;
using Application.Service;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Persistence.Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UserService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IQueryable<User> GetAll(bool tracking = true)
        {
            return _repositoryManager.UserRepository.GetAll(tracking);
        }
        public IQueryable<User> GetWhere(Expression<Func<User, bool>> method, bool tracking = true)
        {
            return _repositoryManager.UserRepository.GetWhere(method, tracking);
        }
        public Task<User> GetSingleAsync(Expression<Func<User, bool>> method, bool tracking = true)
        {
            return _repositoryManager.UserRepository.GetSingleAsync(method, tracking);
        }
        public Task<User> GetByIdAsync(string id, bool tracking = true)
        {
            return _repositoryManager.UserRepository.GetByIdAsync(id, tracking);
        }
        public Task<bool> AddAsync(User model)
        {
            return _repositoryManager.UserRepository.AddAsync(model);
        }
        public Task<bool> AddRangeAsync(List<User> datas)
        {
            return _repositoryManager.UserRepository.AddRangeAsync(datas);
        }
        public bool Remove(User model)
        {
            return _repositoryManager.UserRepository.Remove(model);
        }
        public bool RemoveRange(List<User> datas)
        {
            return _repositoryManager.UserRepository.RemoveRange(datas);
        }
        public Task<bool> RemoveAsync(string id)
        {
            return _repositoryManager.UserRepository.RemoveAsync(id);
        }
        public bool UpdateData(User model)
        {
            return _repositoryManager.UserRepository.UpdateData(model);
        }
        public Task<int> SaveAsync()
        {
            return _repositoryManager.UserRepository.SaveAsync();
        }

    }
}
