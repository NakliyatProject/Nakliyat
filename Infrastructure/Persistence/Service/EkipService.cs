using Application.Repositories;
using Application.Service;
using Domain.Dtos;
using Domain.Entities;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Service
{
    public class EkipService : IEkipService
    {
        private readonly IRepositoryManager _manager;

        public EkipService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Task<bool> AddAsync(EkipDto model)
        {
            Ekip ekip = new Ekip(model.EkipName, model.EkipLead, model.EkipTelNo, model.AracName, model.AracPlakasi,model.AracImgUrl);
            return _manager.EkipRepository.AddAsync(ekip);
        }

        public Task<bool> AddRangeAsync(List<Ekip> datas)
        {
            return _manager.EkipRepository.AddRangeAsync(datas);
        }

        public IEnumerable<Ekip> GetAll(bool tracking = true)
        {
            return _manager.EkipRepository.GetAll(tracking);
        }

        public Task<Ekip> GetByIdAsync(string id, bool tracking = true)
        {
            return _manager.EkipRepository.GetByIdAsync(id, tracking);
        }

        public Task<Ekip> GetSingleAsync(Expression<Func<Ekip, bool>> method, bool tracking = true)
        {
            return _manager.EkipRepository.GetSingleAsync(method, tracking);
        }

        public IEnumerable<Ekip> GetWhere(Expression<Func<Ekip, bool>> method, bool tracking = true)
        {
            return _manager.EkipRepository.GetWhere(method, tracking);
        }

        public bool Remove(Ekip model)
        {
            return _manager.EkipRepository.Remove(model);
        }

        public Task<bool> RemoveAsync(string id)
        {
            return _manager.EkipRepository.RemoveAsync(id);
        }

        public bool RemoveRange(List<Ekip> datas)
        {
            return _manager.EkipRepository.RemoveRange(datas);
        }

        public Task<int> SaveAsync()
        {
            return _manager.EkipRepository.SaveAsync();
        }

        public bool UpdateData(Ekip model)
        {
            return _manager.EkipRepository.UpdateData(model);
        }
    }
}
