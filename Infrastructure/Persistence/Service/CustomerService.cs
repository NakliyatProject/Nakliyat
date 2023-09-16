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
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repositoryManager;

        public CustomerService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IEnumerable<Customer> GetAll(bool tracking = true)
        {
            return _repositoryManager.CustomerRepository.GetAll(tracking);
        }
        public IEnumerable<Customer> GetWhere(Expression<Func<Customer, bool>> method, bool tracking = true)
        {
            return _repositoryManager.CustomerRepository.GetWhere(method, tracking);
        }
        public Task<Customer> GetSingleAsync(Expression<Func<Customer, bool>> method, bool tracking = true)
        {
            return _repositoryManager.CustomerRepository.GetSingleAsync(method, tracking);
        }
        public Task<Customer> GetByIdAsync(string id, bool tracking = true)
        {
            return _repositoryManager.CustomerRepository.GetByIdAsync(id, tracking);
        }
        public Task<bool> AddAsync(Customer model)
        {
            return _repositoryManager.CustomerRepository.AddAsync(model);
        }
        public Task<bool> AddRangeAsync(List<Customer> datas)
        {
            return _repositoryManager.CustomerRepository.AddRangeAsync(datas);
        }
        public bool Remove(Customer model)
        {
            return _repositoryManager.CustomerRepository.Remove(model);
        }
        public bool RemoveRange(List<Customer> datas)
        {
            return _repositoryManager.CustomerRepository.RemoveRange(datas);
        }
        public Task<bool> RemoveAsync(string id)
        {
            return _repositoryManager.CustomerRepository.RemoveAsync(id);
        }
        public bool UpdateData(Customer model)
        {
            return _repositoryManager.CustomerRepository.UpdateData(model);
        }
        public Task<int> SaveAsync()
        {
            return _repositoryManager.CustomerRepository.SaveAsync();
        }

    }
}
