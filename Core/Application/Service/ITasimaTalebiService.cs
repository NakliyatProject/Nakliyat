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
    public interface ITasimaTalebiService
    {
        IEnumerable<TasimaTalebi> GetAll(bool tracking = true); // Hepsini Getir.
        IEnumerable<TasimaTalebi> GetWhere(Expression<Func<TasimaTalebi, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<TasimaTalebi> GetSingleAsync(Expression<Func<TasimaTalebi, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<TasimaTalebi> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(TasimaTalebiDto model); // Data ekle.
        Task<bool> AddRangeAsync(List<TasimaTalebi> datas); // Datalar ekle.
        bool Remove(TasimaTalebi model); // Data çıkar.
        bool RemoveRange(List<TasimaTalebi> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(TasimaTalebi model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
