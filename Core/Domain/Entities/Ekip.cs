using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ekip : BaseEntity
    {
        public string EkipName { get; set; }
        public string AracName { get; set; }
        public string AracPlakasi { get; set; }
        public string EkipLead { get; set; }
        public string AracImgUrl { get; set; }
        public string EkipTelNo { get; set; }
        public Durum durum { get; set; }
        public int EkipYorumSayisi { get; set; }
        public int EkipRank { get; set; }


        public Ekip()
        {
            
        }

        public Ekip(string ekipName, string aracName, string aracPlakasi, string ekipLead, string aracImgUrl, string ekipTelNo)
        {
            EkipName = ekipName;
            AracName = aracName;
            AracPlakasi = aracPlakasi;
            EkipLead = ekipLead;
            AracImgUrl = aracImgUrl;
            EkipTelNo = ekipTelNo;
            durum = Durum.Müsait;
            EkipYorumSayisi = 0;
            EkipRank = 0;
            Id = Guid.NewGuid();
        }

    }
    public enum Durum
    {
        Müsait,
        Taşimada,
        ArizaMevcut,
        Belirtilmemiş
    }

}
