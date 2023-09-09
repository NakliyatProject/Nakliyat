using Domain.Entities;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net.Sockets;

namespace Persistence.Context
{
    public class NakliyatDbContext : DbContext
    {
        public NakliyatDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyReview> CompanyReviews { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<TransportationTeam> TransportationTeams { get; set; }
        public DbSet<TransportRequest> TransportRequests { get; set; }
        public DbSet<UsedVehicle> UsedVehicles { get; set; }




        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker : Entityler üzerinden yapılan değişikliklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir.
            // Update operasyonlarında Track Edilen verileri yakalayıp elde etmemizi sağlar.

            var datas = ChangeTracker
                        .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasData(
                    new User() { Id = Guid.NewGuid(), UserName = "User 1", UserSurname = "Surname", Email = "user1@gmail.com", UserRole = "Company", CreatedDate = DateTime.UtcNow },
                    new User() { Id = Guid.NewGuid(), UserName = "User 2", UserSurname = "Surname", Email = "user2@gmail.com", UserRole = "Customer", CreatedDate = DateTime.UtcNow },
                    new User() { Id = Guid.NewGuid(), UserName = "User 3", UserSurname = "Surname", Email = "user3@gmail.com", UserRole = "Customer", CreatedDate = DateTime.UtcNow },
                    new User() { Id = Guid.NewGuid(), UserName = "User 4", UserSurname = "Surname", Email = "user4@gmail.com", UserRole = "Company", CreatedDate = DateTime.UtcNow },
                    new User() { Id = Guid.NewGuid(), UserName = "User 5", UserSurname = "Surname", Email = "user5@gmail.com", UserRole = "Customer", CreatedDate = DateTime.UtcNow }
                );

        }
    }
}
