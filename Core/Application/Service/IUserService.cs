using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IUserService
    {
        IQueryable<User> GetAll(bool tracking = true); // Hepsini Getir.
        IQueryable<User> GetWhere(Expression<Func<User, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<User> GetSingleAsync(Expression<Func<User, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<User> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(User model); // Data ekle.
        Task<bool> AddRangeAsync(List<User> datas); // Datalar ekle.
        bool Remove(User model); // Data çıkar.
        bool RemoveRange(List<User> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(User model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
