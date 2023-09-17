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
    }
}
