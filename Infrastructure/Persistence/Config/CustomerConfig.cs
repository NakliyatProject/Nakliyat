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
    class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CustomerName).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.CustomerSurname).IsRequired();


            builder.HasData(
                    new Customer() { Id = Guid.NewGuid(), CustomerName = "Customer1", CustomerSurname = "Surname", Email = "user1@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Customer() { Id = Guid.NewGuid(), CustomerName = "Customer2", CustomerSurname = "Surname", Email = "user2@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Customer() { Id = Guid.NewGuid(), CustomerName = "Customer3", CustomerSurname = "Surname", Email = "user3@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Customer() { Id = Guid.NewGuid(), CustomerName = "Customer4", CustomerSurname = "Surname", Email = "user4@gmail.com", CreatedDate = DateTime.UtcNow },
                    new Customer() { Id = Guid.NewGuid(), CustomerName = "Customer5", CustomerSurname = "Surname", Email = "user5@gmail.com", CreatedDate = DateTime.UtcNow }
                );
        }
    }
}