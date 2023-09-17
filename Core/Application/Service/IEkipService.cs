using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IEkipService
    {
        IEnumerable<Ekip> GetAll(bool tracking = true); // Hepsini Getir.
        IEnumerable<Ekip> GetWhere(Expression<Func<Ekip, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<Ekip> GetSingleAsync(Expression<Func<Ekip, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<Ekip> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(EkipDto model); // Data ekle.
        Task<bool> AddRangeAsync(List<Ekip> datas); // Datalar ekle.
        bool Remove(Ekip model); // Data çıkar.
        bool RemoveRange(List<Ekip> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(Ekip model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
