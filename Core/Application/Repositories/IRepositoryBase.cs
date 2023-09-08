using System.Linq.Expressions;

namespace Application.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll(bool tracking = true); // Hepsini Getir.
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<T> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(T model); // Data ekle.
        Task<bool> AddRangeAsync(List<T> datas); // Datalar ekle.
        bool Remove(T model); // Data çıkar.
        bool RemoveRange(List<T> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(T model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
