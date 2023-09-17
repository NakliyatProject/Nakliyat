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
        private readonly IRepositoryManager _manager;

        public CustomerService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Customer> GetAll(bool tracking = true)
        {
            return _manager.CustomerRepository.GetAll(tracking);
        }
        public IEnumerable<Customer> GetWhere(Expression<Func<Customer, bool>> method, bool tracking = true)
        {
            return _manager.CustomerRepository.GetWhere(method, tracking);
        }
        public Task<Customer> GetSingleAsync(Expression<Func<Customer, bool>> method, bool tracking = true)
        {
            return _manager.CustomerRepository.GetSingleAsync(method, tracking);
        }
        public Task<Customer> GetByIdAsync(string id, bool tracking = true)
        {
            return _manager.CustomerRepository.GetByIdAsync(id, tracking);
        }
        public Task<bool> AddAsync(Customer model)
        {
            return _manager.CustomerRepository.AddAsync(model);
        }
        public Task<bool> AddRangeAsync(List<Customer> datas)
        {
            return _manager.CustomerRepository.AddRangeAsync(datas);
        }
        public bool Remove(Customer model)
        {
            return _manager.CustomerRepository.Remove(model);
        }
        public bool RemoveRange(List<Customer> datas)
        {
            return _manager.CustomerRepository.RemoveRange(datas);
        }
        public Task<bool> RemoveAsync(string id)
        {
            return _manager.CustomerRepository.RemoveAsync(id);
        }
        public bool UpdateData(Customer model)
        {
            return _manager.CustomerRepository.UpdateData(model);
        }
        public Task<int> SaveAsync()
        {
            return _manager.CustomerRepository.SaveAsync();
        }

    }
}
