using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Config
{
    public class TasimaTalebiConfig : IEntityTypeConfiguration<TasimaTalebi>
    {
        public void Configure(EntityTypeBuilder<TasimaTalebi> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Aciklama).IsRequired();
            builder.Property(p => p.Baslangic).IsRequired();
            builder.Property(p => p.Bitis).IsRequired();
            builder.Property(p => p.Mesafe).IsRequired();
            builder.HasData(
                    new TasimaTalebi() { Id = Guid.NewGuid(), Aciklama = "tasimatalebi1", Baslangic = "istanbul", Bitis = "kars", Mesafe = 150, EsyaImgUrl = "laptop.jpeg", CreatedDate = DateTime.UtcNow },
                    new TasimaTalebi() { Id = Guid.NewGuid(), Aciklama = "tasimatalebi2", Baslangic = "istanbul", Bitis = "ardahan", Mesafe = 150, EsyaImgUrl = "laptop.jpeg", CreatedDate = DateTime.UtcNow },
                    new TasimaTalebi() { Id = Guid.NewGuid(), Aciklama = "tasimatalebi3", Baslangic = "istanbul", Bitis = "igdir", Mesafe = 150, EsyaImgUrl = "laptop.jpeg", CreatedDate = DateTime.UtcNow },
                    new TasimaTalebi() { Id = Guid.NewGuid(), Aciklama = "tasimatalebi4", Baslangic = "istanbul", Bitis = "agri", Mesafe = 150, EsyaImgUrl = "laptop.jpeg", CreatedDate = DateTime.UtcNow },
                    new TasimaTalebi() { Id = Guid.NewGuid(), Aciklama = "tasimatalebi5", Baslangic = "istanbul", Bitis = "van", Mesafe = 150, EsyaImgUrl = "laptop.jpeg", CreatedDate = DateTime.UtcNow }
                );
        }
    }   
}
