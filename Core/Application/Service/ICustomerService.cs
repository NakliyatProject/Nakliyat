using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll(bool tracking = true); // Hepsini Getir.
        IEnumerable<Customer> GetWhere(Expression<Func<Customer, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<Customer> GetSingleAsync(Expression<Func<Customer, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<Customer> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(Customer model); // Data ekle.
        Task<bool> AddRangeAsync(List<Customer> datas); // Datalar ekle.
        bool Remove(Customer model); // Data çıkar.
        bool RemoveRange(List<Customer> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(Customer model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
