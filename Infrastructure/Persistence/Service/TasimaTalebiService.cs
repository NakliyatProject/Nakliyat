using Application.Repositories;
using Application.Service;
using AutoMapper;
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
    public class TasimaTalebiService : ITasimaTalebiService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public TasimaTalebiService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public Task<bool> AddAsync(TasimaTalebiDto model)
        {
            TasimaTalebi tasimaTalebi = new TasimaTalebi(model.Aciklama,model.Baslangic,model.Bitis,model.Mesafe,model?.EsyaImgUrl);

            //TasimaTalebi tasimaTalebi = _mapper.Map<TasimaTalebi>(model);
            //_manager.TasimaTalebiRepository.AddAsync(tasimaTalebi);            // AUTOMAPPER ile yazılabilen kod

            return _manager.TasimaTalebiRepository.AddAsync(tasimaTalebi);
        }

        public Task<bool> AddRangeAsync(List<TasimaTalebi> datas)
        {
            return _manager.TasimaTalebiRepository.AddRangeAsync(datas);
        }

        public IEnumerable<TasimaTalebi> GetAll(bool tracking = true)
        {
            return _manager.TasimaTalebiRepository.GetAll(tracking);
        }

        public Task<TasimaTalebi> GetByIdAsync(string id, bool tracking = true)
        {
            return _manager.TasimaTalebiRepository.GetByIdAsync(id, tracking);
        }

        public Task<TasimaTalebi> GetSingleAsync(Expression<Func<TasimaTalebi, bool>> method, bool tracking = true)
        {
            return _manager.TasimaTalebiRepository.GetSingleAsync(method, tracking);
        }

        public IEnumerable<TasimaTalebi> GetWhere(Expression<Func<TasimaTalebi, bool>> method, bool tracking = true)
        {
            return _manager.TasimaTalebiRepository.GetWhere(method, tracking);
        }

        public bool Remove(TasimaTalebi model)
        {
            return _manager.TasimaTalebiRepository.Remove(model);
        }

        public Task<bool> RemoveAsync(string id)
        {
            return _manager.TasimaTalebiRepository.RemoveAsync(id);
        }

        public bool RemoveRange(List<TasimaTalebi> datas)
        {
            return _manager.TasimaTalebiRepository.RemoveRange(datas);
        }

        public Task<int> SaveAsync()
        {
            return _manager.TasimaTalebiRepository.SaveAsync();
        }

        public bool UpdateData(TasimaTalebi model)
        {
            return _manager.TasimaTalebiRepository.UpdateData(model);
        }


        //public async void TeklifOlustur(string talepId, string ekipId, decimal fiyat)
        //{
        //    try
        //    {
        //        TasimaTalebi talep = await _manager.TasimaTalebiRepository.GetByIdAsync(talepId, true);

        //        Ekip ekip = await _manager.EkipRepository.GetByIdAsync(ekipId, true);


        //        talep.AddTeklif(ekip, fiyat);


        //        _manager.TasimaTalebiRepository.SaveAsync();
        //    }
        //    catch (ProjectException)
        //    {
        //        throw;
        //    }
        //    catch (Exception e)
        //    {
        //        //Log(e);
        //        throw new Exception("Beklenmedik Bir Hata Oluştu. Lütfen tekrar deneyiniz");
        //    }
        //}
    }
}
