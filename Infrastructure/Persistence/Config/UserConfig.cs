using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Config
{
    class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.UserSurname).IsRequired();


            builder.HasData(
                    new User() { Id = Guid.NewGuid(), UserName = "User 1", UserSurname = "Surname", Email = "user1@gmail.com", UserRole = "Company", CreatedDate = DateTime.UtcNow },
                    new User() { Id = Guid.NewGuid(), UserName = "User 2", UserSurname = "Surname", Email = "user2@gmail.com", UserRole = "Customer", CreatedDate = DateTime.UtcNow },
                    new User() { Id = Guid.NewGuid(), UserName = "User 3", UserSurname = "Surname", Email = "user3@gmail.com", UserRole = "Customer", CreatedDate = DateTime.UtcNow },
                    new User() { Id = Guid.NewGuid(), UserName = "User 4", UserSurname = "Surname", Email = "user4@gmail.com", UserRole = "Company", CreatedDate = DateTime.UtcNow },
                    new User() { Id = Guid.NewGuid(), UserName = "User 5", UserSurname = "Surname", Email = "user5@gmail.com", UserRole = "Customer", CreatedDate = DateTime.UtcNow }
                );
        }
    }
}