using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TasimaTalebi : BaseEntity
    {

        public string Aciklama { get; set; }
        public string Baslangic { get; set; }
        public string Bitis { get; set; }
        public int Mesafe { get; set; }
        public string? EsyaImgUrl { get; set; }


        //public bool IsActive { get; set; }


        //public List<string> teklifEkipIds { get; set; }
        //public List<decimal> teklifEkipFiyatlar { get; set; }

        public TasimaTalebi() { }
        public TasimaTalebi(string aciklama, string baslangic, string bitis, int mesafe, string? esyaImgUrl)
        {
            Aciklama = aciklama;
            Baslangic = baslangic;
            Bitis = bitis;
            Mesafe = mesafe;
            EsyaImgUrl = esyaImgUrl;
            Id = Guid.NewGuid();
        }



        //public void AddTeklif(Ekip ekip, decimal price)
        //{
        //    if (!IsActive)
        //        throw new ProjectException("Talep aktif durumda değil.");


        //    string? checkEkipId = teklifEkipIds.FirstOrDefault(e => e == ekip.Id.ToString());

        //    if (checkEkipId != null)
        //    {
        //        throw new ProjectException("Daha önce teklif vermişssiniz.");

        //        UpdateTeklif(ekip, price);
        //        return;
        //    }

        //    if (price <= 0)
        //    {
        //        throw new ProjectException("Girilen fiyat 0'dan büyük olmalı");
        //    }

        //    teklifEkipIds.Add(ekip.Id.ToString());
        //    teklifEkipFiyatlar.Add(price);
        //}

        //public void UpdateTeklif(Ekip ekip, decimal price)
        //{

        //}


        //public void AddTeklif(Ekip ekip, decimal price, bool hatalı)
        //{
        //    if (IsActive)
        //    {
        //        string? checkEkipId = teklifEkipIds.FirstOrDefault(e => e == ekip.Id.ToString());

        //        if (checkEkipId == null)
        //        {

        //            if (price > 0)
        //            {
        //                teklifEkipIds.Add(ekip.Id.ToString());
        //                teklifEkipFiyatlar.Add(price);
        //            }
        //            else
        //                throw new ProjectException("Girilen fiyat 0'dan büyük olmalı");
        //        }
        //        else
        //        {
        //            throw new ProjectException("Daha önce teklif vermişssiniz.");
        //        }
        //    }
        //    else
        //    {
        //        throw new ProjectException("Talep aktif değil");
        //    }
        //}
    }
}
